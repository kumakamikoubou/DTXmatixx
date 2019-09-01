﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SSTFormatCurrent = SSTFormat.v4;
using FDK;

using Record = DTXMania.Record06;

namespace DTXMania
{
    /// <summary>
    ///		現在の演奏状態や成績を保存するクラス。
    ///		描画は行わない。
    /// </summary>
    internal class 成績 : Record
    {
        /// <summary>
        ///     現在のコンボ数。
        ///     AutoPlayチップを含む。
        /// </summary>
        public int Combo { get; protected set; } = 0;

        /// <summary>
        ///     現在までの最大コンボ数。
        ///     AutoPlayチップを含む。
        /// </summary>
        public int MaxCombo { get; protected set; } = 0;
        
        /// <summary>
        ///		エキサイトゲージの割合。空:0～1:最大
        /// </summary>
        public float エキサイトゲージ量 { get; protected set; }

        /// <summary>
        ///		現在の設定において、ヒット対象になるノーツの数を返す。
        ///     AutoPlayチップを含む。
        /// </summary>
        public int 総ノーツ数 { get; protected set; } = 0;

        /// <summary>
        ///		判定種別ごとのヒット数。
        ///     AutoPlayチップを含む。
        /// </summary>
        public IReadOnlyDictionary<判定種別, int> 判定toヒット数 => this._判定toヒット数;

        /// <summary>
        ///		現在の <see cref="判定toヒット数"/> から、判定種別ごとのヒット割合を算出して返す。
        ///		判定種別のヒット割合は、すべて合計すればちょうど 100 になる。
        ///     ヒット数にはAutoPlayチップを含む。
        /// </summary>
        public IReadOnlyDictionary<判定種別, int> 判定toヒット割合 => this._ヒット割合を算出して返す();

        /// <summary>
        ///     最終的に判定されたランク。
        /// </summary>
        public ランク種別 ランク { get; protected set; } = ランク種別.E;



        // static


        /// <summary>
        ///     達成率（0～99.99）を算出して返す。
        /// </summary>
        /// <param name="総ノーツ数"></param>
        /// <param name="Perfect数"></param>
        /// <param name="Great数"></param>
        /// <param name="最大コンボ数"></param>
        /// <param name="オプション補正">0～1。</param>
        public static double 達成率を算出する( int 総ノーツ数, int Perfect数, int Great数, int 最大コンボ数, double オプション補正 )
        {
            double 判定値 = _小数第3位以下切り捨て( ( Perfect数 * 85.0 + Great数 * 35.0 ) / 総ノーツ数 );
            double COMBO値 = _小数第3位以下切り捨て( 最大コンボ数 * 15.0 / 総ノーツ数 );

            // 判定値とCOMBO値にはAutoチップも含まれるので、すべてAutoPlayONであっても、達成率はゼロにはならない。
            // その代わり、オプション補正でガシガシ削る。
            return _小数第3位以下切り捨て( ( 判定値 + COMBO値 ) * オプション補正 );
        }

        /// <summary>
        ///     スキル値（0～199.78）を算出して返す。
        /// </summary>
        public static double スキルを算出する( double 譜面レベル, double 達成率0to100 )
        {
            return _小数第3位以下切り捨て( ( 達成率0to100 * 譜面レベル * 20.0 ) / 100.0 );
        }

        /// <summary>
        ///     達成率(0～99.99)からランクを算出して返す。
        /// </summary>
        public static ランク種別 ランクを算出する( double 達成率0to100 )
        {
            return                                          // 範囲
                ( 97 <= 達成率0to100 ) ? ランク種別.SS :    //  3 %
                ( 92 <= 達成率0to100 ) ? ランク種別.S :     //  5 %
                ( 85 <= 達成率0to100 ) ? ランク種別.A :     //  7 %
                ( 78 <= 達成率0to100 ) ? ランク種別.B :     //  7 %
                ( 68 <= 達成率0to100 ) ? ランク種別.C :     // 10 %
                ( 50 <= 達成率0to100 ) ? ランク種別.D :     // 18 %
                ランク種別.E;                               // 50 %
        }



        // 生成と終了


        public 成績()
        {
            using( Log.Block( FDKUtilities.現在のメソッド名 ) )
            {
                this.Score = 0;
                this.MaxCombo = 0;
                this.エキサイトゲージ量 = 0.75f;
                this.Achievement = 0.0f;
                this.総ノーツ数 = 0;

                this._譜面レベル = 0.5;
                this._判定toヒット数 = new Dictionary<判定種別, int>();
                this._最後にスコアを更新したときの判定toヒット数 = new Dictionary<判定種別, int>();
                foreach( 判定種別 judge in Enum.GetValues( typeof( 判定種別 ) ) )
                {
                    this._判定toヒット数.Add( judge, 0 );
                    this._最後にスコアを更新したときの判定toヒット数.Add( judge, 0 );
                }
            }
        }



        // 操作


        /// <summary>
        ///     譜面情報とユーザ設定情報を設定する。
        ///     以降の成績の計算には、これらの設定値が使用される。
        /// </summary>
        public void スコアと設定を反映する( SSTFormatCurrent.スコア 譜面, ユーザ設定 設定 )
        {
            this._ユーザ設定 = 設定;

            this.総ノーツ数 = ( null != 譜面 && null != 設定 ) ? this._総ノーツ数を算出して返す( 譜面, 設定 ) : 0;

            this._譜面レベル = 譜面?.難易度 ?? 0.5;
        }

        /// <summary>
        ///		判定に応じて成績（エキサイトゲージを除く）を更新する。
        /// </summary>
        public void 成績を更新する( 判定種別 判定, bool autoPlay )
        {
            #region " ヒット数を加算する。"
            //----------------
            this._判定toヒット数[ 判定 ]++;
            //----------------
            #endregion

            #region " コンボを加算する。"
            //----------------
            {
                bool コンボ切れ = ( 判定 == 判定種別.OK || 判定 == 判定種別.MISS );

                if( コンボ切れ )
                {
                    this.Combo = 0;
                }
                else
                {
                    this.Combo++;
                    this.MaxCombo = Math.Max( this.Combo, this.MaxCombo );
                }
            }
            //----------------
            #endregion

            #region " スコアを加算する。"
            //----------------
            {
                if( this.総ノーツ数 == this._判定toヒット数[ 判定種別.PERFECT ] )
                {
                    // Excellent（最後のチップまですべてPERFECT）の場合、スコアは100万点ジャストに調整する。
                    this.Score = 100 * 10000;
                }
                else
                {
                    // それ以外は通常の加点。
                    double 基礎点 = 100_0000.0 / ( 1275.0 + 50.0 * ( this.総ノーツ数 - 50 ) );
                    int コンボ数 = Math.Min( this.Combo, 50 );

                    this.Score += (int) Math.Floor( 基礎点 * コンボ数 * this._判定値表[ 判定 ] );
                }
            }
            //----------------
            #endregion

            double オプション補正0to1 = 1.0;

            #region " オプション補正を算出する。"
            //----------------
            {
                if( this._ユーザ設定.AutoPlayがすべてONである )
                {
                    // (A) すべて ON → 補正なし(x1.0), ただしDBには保存されない。
                    オプション補正0to1 = 1.0;
                }
                else
                {
                    // (B) 一部だけ ON → AutoPlay が ON になっている個所に応じて補正する。
                    foreach( var kvp in this._ユーザ設定.AutoPlay )
                    {
                        if( this._Auto時の補正.ContainsKey( kvp.Key ) )
                        {
                            オプション補正0to1 *= this._Auto時の補正[ kvp.Key ];   // 補正値は累積
                        }
                    }
                }
            }
            //----------------
            #endregion

            #region " 達成率を更新する。"
            //----------------
            this.Achievement = 達成率を算出する(
                this.総ノーツ数,                          // Auto含む
                this._判定toヒット数[ 判定種別.PERFECT ], // Auto含む
                this._判定toヒット数[ 判定種別.GREAT ],   // Auto含む
                this.MaxCombo,                            // Auto含む
                オプション補正0to1 );
            //----------------
            #endregion

            #region " スキル値を更新する。"
            //----------------
            this.Skill = スキルを算出する( this._譜面レベル, this.Achievement );
            //----------------
            #endregion

            #region " ランクを更新する。"
            //----------------
            this.ランク = ランクを算出する( this.Achievement );
            //----------------
            #endregion
        }

        /// <summary>
        ///		判定に応じてエキサイトゲージを加減する。
        /// </summary>
        public void エキサイトゲージを更新する( 判定種別 judge )
        {
            switch( judge )
            {
                case 判定種別.PERFECT: this.エキサイトゲージ量 += 0.025f; break;
                case 判定種別.GREAT: this.エキサイトゲージ量 += 0.01f; break;
                case 判定種別.GOOD: this.エキサイトゲージ量 += 0.005f; break;
                case 判定種別.OK: this.エキサイトゲージ量 += 0f; break;
                case 判定種別.MISS: this.エキサイトゲージ量 -= 0.08f; break;
            }

            this.エキサイトゲージ量 = Math.Max( Math.Min( this.エキサイトゲージ量, 1.0f ), 0.0f );
        }



        // private


        private Dictionary<判定種別, int> _判定toヒット数 = null;

        private Dictionary<判定種別, int> _最後にスコアを更新したときの判定toヒット数 = null;

        private readonly Dictionary<判定種別, double> _判定値表 = new Dictionary<判定種別, double>() {
            { 判定種別.PERFECT, 1.0 },
            { 判定種別.GREAT,   0.5 },
            { 判定種別.GOOD,    0.2 },
            { 判定種別.OK,      0.0 },
            { 判定種別.MISS,    0.0 },
        };

        /// <summary>
        ///     Autoを使用した場合のオプション補正。
        ///     達成率に乗じる数値なので、Autoにすると演奏が簡単になる（と思われる）ものほど補正値は小さくなる。
        /// </summary>
        private readonly Dictionary<AutoPlay種別, double> _Auto時の補正 = new Dictionary<AutoPlay種別, double>() {
            { AutoPlay種別.LeftCrash, 0.9 },
            { AutoPlay種別.HiHat, 0.5 },
            { AutoPlay種別.Foot, 1.0 },       // Foot は判定に使われない。
            { AutoPlay種別.Snare, 0.5 },
            { AutoPlay種別.Bass, 0.5 },
            { AutoPlay種別.Tom1, 0.7 },
            { AutoPlay種別.Tom2, 0.7 },
            { AutoPlay種別.Tom3, 0.8 },
            { AutoPlay種別.RightCrash, 0.9 },
        };

        private double _譜面レベル = 5.0;

        private ユーザ設定 _ユーザ設定 = null;


        private IReadOnlyDictionary<判定種別, int> _ヒット割合を算出して返す()
        {
            // HACK: ヒット割合の計算式は、本家とは一致していない。

            int ヒット数の合計 = 0;
            var ヒット割合_実数 = new Dictionary<判定種別, double>();  // 実値（0～100）
            var ヒット割合_整数 = new Dictionary<判定種別, int>(); // 実値を整数にしてさらに補正した値（0～100）
            var ヒット数リスト = new List<(判定種別 judge, int hits)>();
            var 切り捨てした = new Dictionary<判定種別, bool>();
            判定種別 判定;

            // ヒット数の合計を算出。
            foreach( var kvp in this._判定toヒット数 )
                ヒット数の合計 += kvp.Value;

            // 各判定のヒット割合（実数）を算出。
            foreach( var kvp in this._判定toヒット数 )
            {
                ヒット割合_実数.Add( kvp.Key, ( 100.0 * kvp.Value ) / ヒット数の合計 );
                切り捨てした.Add( kvp.Key, false );   // ついでに初期化。
            }

            // ヒット数の大きいもの順（降順）に、リストを作成。
            foreach( 判定種別 j in Enum.GetValues( typeof( 判定種別 ) ) )
                ヒット数リスト.Add( (j, this.判定toヒット数[ j ]) );

            ヒット数リスト.Sort( ( x, y ) => ( y.hits - x.hits ) );    // 降順

            // ヒット数が一番大きい判定は、ヒット割合の小数部を切り捨てる。
            判定 = ヒット数リスト[ 0 ].judge;
            ヒット割合_整数.Add( 判定, (int) Math.Floor( ヒット割合_実数[ 判定 ] ) );
            切り捨てした[ 判定 ] = true;

            // 以下、二番目以降についてヒット割合（整数）を算出する。
            int 整数割合の合計 = ヒット割合_整数[ 判定 ];

            for( int i = 1; i < ヒット数リスト.Count; i++ )
            {
                判定 = ヒット数リスト[ i ].judge;

                // まずは四捨五入する。
                ヒット割合_整数.Add( 判定, (int) Math.Round( ヒット割合_実数[ 判定 ], MidpointRounding.AwayFromZero ) );

                // 合計が100になり、かつ、まだ後続に非ゼロがいるなら、値を -1 する。
                // → まだ非ゼロの後続がいる場合は、ここで100になってはならない。逆に、後続がすべてゼロなら、ここで100にならなければならない。
                if( 100 <= ( 整数割合の合計 + ヒット割合_整数[ 判定 ] ) )
                {
                    bool 後続にまだ非ゼロがいる = false;
                    for( int n = ( i + 1 ); n < ヒット数リスト.Count; n++ )
                    {
                        if( ヒット数リスト[ n ].hits > 0 )
                        {
                            後続にまだ非ゼロがいる = true;
                            break;
                        }
                    }
                    if( 後続にまだ非ゼロがいる )
                    {
                        ヒット割合_整数[ 判定 ]--;
                        切り捨てした[ 判定 ] = true;
                    }
                }

                // 合計に加算して、次へ。
                整数割合の合計 += ヒット割合_整数[ 判定 ];
            }

            // 合計が100に足りない場合は、「四捨五入した値と実数値との差の絶対値」が一番大きい判定に +1 する。
            // ただし、「ヒット数が一番大きい判定」と、「切り捨てした判定」は除外する。
            if( 100 > 整数割合の合計 )
            {
                var 差の絶対値リスト = new List<(判定種別 judge, double 差の絶対値)>();

                for( int i = 1; i < ヒット数リスト.Count; i++ )    // i = 0 （ヒット数が一番大きい判定）は除く
                {
                    判定 = ヒット数リスト[ i ].judge;
                    差の絶対値リスト.Add( (判定, Math.Abs( ヒット割合_実数[ 判定 ] - ヒット割合_整数[ 判定 ] )) );
                }

                差の絶対値リスト.Sort( ( x, y ) => (int) ( y.差の絶対値 * 1000.0 - x.差の絶対値 * 1000.0 ) );     // 降順; 0.xxxx だと (int) で詰むが、1000倍したらだいたいOk

                // 余るときはたいてい 99 だと思うが、念のため、100になるまで降順に+1していく。
                for( int i = 0; i < 差の絶対値リスト.Count; i++ )
                {
                    判定 = 差の絶対値リスト[ i ].judge;

                    if( 切り捨てした[ 判定 ] )
                        continue;   // 切り捨てした判定は除く

                    ヒット割合_整数[ 判定 ]++;
                    整数割合の合計++;

                    if( 100 <= 整数割合の合計 )
                        break;
                }
            }

            return ヒット割合_整数;
        }

        /// <summary>
        ///     スコアのチップリストのうち、判定対象のチップの数を返す。
        /// </summary>
        private int _総ノーツ数を算出して返す( SSTFormatCurrent.スコア score, ユーザ設定 options )
        {
            int 総ノーツ数 = 0;

            foreach( var chip in score.チップリスト )
            {
                var ドラムチッププロパティ = options.ドラムチッププロパティ管理[ chip.チップ種別 ];
                bool AutoPlayである = options.AutoPlay[ ドラムチッププロパティ.AutoPlay種別 ];
                bool 判定対象である = ( AutoPlayである ) ?
                    ドラムチッププロパティ.AutoPlayON_自動ヒット_判定 :
                    ドラムチッププロパティ.AutoPlayOFF_ユーザヒット_判定;

                if( 判定対象である )
                    総ノーツ数++;
            }

            return 総ノーツ数;
        }

        private static double _小数第3位以下切り捨て( double v )
        {
            return Math.Floor( 100.0 * v ) / 100.0;
        }
    }
}
