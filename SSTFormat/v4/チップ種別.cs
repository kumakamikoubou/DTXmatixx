﻿using System;

namespace SSTFormat.v4
{
    /// <summary>
    ///		チップの種別を表す整数値。
    /// </summary>
    /// <remarks>
    ///		互換性を維持するために、将来にわたって不変な int 型の数値を、明確に定義する。
    ///		同じ理由から、一度廃止した番号の再利用は禁止。新しいメンバには常に新しい値（最終値＋１～）を割り当てること。
    /// </remarks>
    public enum チップ種別 : int
    {
        /// <summary>
        ///     未知。
        /// </summary>
        Unknown = 0,

        // パッド

        #region " シンバル "
        //----------------

        /// <summary>
        ///     クラッシュシンバル（左）。
        /// </summary>
        LeftCrash = 1,

        /// <summary>
        ///     クラッシュシンバル（右）。
        /// </summary>
        RightCrash = 21,

        /// <summary>
        ///     シンバルミュート（左）。v1.2以降。
        /// </summary>
        LeftCymbal_Mute = 27,

        /// <summary>
        ///     シンバルミュート（右）。v1.2以降。
        /// </summary>
        RightCymbal_Mute = 28,

        /// <summary>
        ///     ライドシンバル。
        /// </summary>
        Ride = 2,

        /// <summary>
        ///     ライドシンバルのカップ。
        /// </summary>
        Ride_Cup = 3,

        /// <summary>
        ///     チャイナシンバル。
        /// </summary>
        China = 4,

        /// <summary>
        ///     スプラッシュシンバル。
        /// </summary>
        Splash = 5,

        //----------------
        #endregion

        #region " ハイハット "
        //----------------

        /// <summary>
        ///     ハイハットオープン。
        /// </summary>
        HiHat_Open = 6,

        /// <summary>
        ///     ハイハットハーフオープン（半開き）。
        /// </summary>
        HiHat_HalfOpen = 7,

        /// <summary>
        ///     ハイハットクローズ。
        /// </summary>
        HiHat_Close = 8,

        /// <summary>
        ///     フットハイハット。フットスプラッシュではない。
        /// </summary>
        HiHat_Foot = 9,

        //----------------
        #endregion

        #region " スネア "
        //----------------

        /// <summary>
        ///     スネア。
        /// </summary>
        Snare = 10,

        /// <summary>
        ///     スネアのオープンリムショット。
        /// </summary>
        Snare_OpenRim = 11,

        /// <summary>
        ///     スネアのクローズドリムショット。
        /// </summary>
        Snare_ClosedRim = 12,

        /// <summary>
        ///     スネアのゴーストショット。
        /// </summary>
        Snare_Ghost = 13,

        //----------------
        #endregion

        #region " バス "
        //----------------

        /// <summary>
        ///     バスドラム（右）。
        /// </summary>
        Bass = 14,

        /// <summary>
        ///     バスドラム（左）。v3.1 以降。
        /// </summary>
        LeftBass = 38,

        //----------------
        #endregion

        #region " タム "
        //----------------

        /// <summary>
        ///     ハイタム。
        /// </summary>
        Tom1 = 15,

        /// <summary>
        ///     ハイタムのリムショット。
        /// </summary>
        Tom1_Rim = 16,

        /// <summary>
        ///     ロータム。
        /// </summary>
        Tom2 = 17,

        /// <summary>
        ///     ロータムのリムショット。
        /// </summary>
        Tom2_Rim = 18,

        /// <summary>
        ///     フロアタム。
        /// </summary>
        Tom3 = 19,

        /// <summary>
        ///     フロアタムのリムショット。
        /// </summary>
        Tom3_Rim = 20,

        //----------------
        #endregion


        // 自動再生

        /// <summary>
        ///     動画の再生を開始する。
        /// </summary>
        /// <remarks>
        ///     再生する動画のファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.AVIリスト"/> に格納される。
        ///     ファイルが音声も持つ場合でも、音声は再生されない。
        /// </remarks>
        背景動画 = 25,

        /// <summary>
        ///     ギター音の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        /// </remarks>
        GuitarAuto = 36,

        /// <summary>
        ///     ベース音の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        /// </remarks>
        BassAuto = 37,

        /// <summary>
        ///     BGMの再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     SEとの違いは、多重再生されないこと。
        /// </remarks>
        BGM = 30,

        #region " SE1～32 "
        //----------------

        /// <summary>
        ///     効果音１の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE1 = 31,

        /// <summary>
        ///     効果音２の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE2 = 32,

        /// <summary>
        ///     効果音３の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE3 = 33,

        /// <summary>
        ///     効果音４の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE4 = 34,

        /// <summary>
        ///     効果音５の再生を開始する。v3.0以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE5 = 35,

        /// <summary>
        ///     効果音６の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE6 = 39,

        /// <summary>
        ///     効果音７の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE7 = 40,

        /// <summary>
        ///     効果音８の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE8 = 41,

        /// <summary>
        ///     効果音９の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE9 = 42,

        /// <summary>
        ///     効果音10の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE10 = 43,

        /// <summary>
        ///     効果音11の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE11 = 44,

        /// <summary>
        ///     効果音12の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE12 = 45,

        /// <summary>
        ///     効果音13の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE13 = 46,

        /// <summary>
        ///     効果音14の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE14 = 47,

        /// <summary>
        ///     効果音15の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE15 = 48,

        /// <summary>
        ///     効果音16の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE16 = 49,

        /// <summary>
        ///     効果音17の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE17 = 50,
        
        /// <summary>
        ///     効果音18の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE18 = 51,

        /// <summary>
        ///     効果音19の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE19 = 52,

        /// <summary>
        ///     効果音20の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE20 = 53,

        /// <summary>
        ///     効果音21の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE21 = 54,

        /// <summary>
        ///     効果音22の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE22 = 55,

        /// <summary>
        ///     効果音23の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE23 = 56,

        /// <summary>
        ///     効果音24の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE24 = 57,

        /// <summary>
        ///     効果音25の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE25 = 58,

        /// <summary>
        ///     効果音26の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE26 = 59,

        /// <summary>
        ///     効果音27の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE27 = 60,

        /// <summary>
        ///     効果音28の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE28 = 61,

        /// <summary>
        ///     効果音29の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE29 = 62,

        /// <summary>
        ///     効果音30の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE30 = 63,

        /// <summary>
        ///     効果音31の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE31 = 64,

        /// <summary>
        ///     効果音32の再生を開始する。v4.1以降。
        /// </summary>
        /// <remarks>
        ///     再生するサウンドのファイル名は、<see cref="チップ.チップサブID"/> をキーとする <see cref="スコア.WAVリスト"/> に格納される。
        ///     ファイルが動画も持つ場合でも、動画は再生されない。
        ///     BGM との違いは、多重再生されること。
        /// </remarks>
        SE32 = 65,

        //----------------
        #endregion


        // アクセサリ

        /// <summary>
        ///     BPM（Beat per Minutes；１分間の拍数）を変更する。
        /// </summary>
        /// <remarks>
        ///     BPM 値は、<see cref="チップ.BPM"/> に格納される。
        /// </remarks>
        BPM = 22,

        /// <summary>
        ///     小節の先頭に置かれることが保証される以外に意味はない。v1.2以降。
        /// </summary>
        小節の先頭 = 29,

        /// <summary>
        ///     小節線を配置する。
        /// </summary>
        小節線 = 23,

        /// <summary>
        ///     拍線を配置する。
        /// </summary>
        拍線 = 24,


        #region " 廃止 "
        //----------------
        小節メモ = 26,
        //----------------
        #endregion


        // ※現時点の最終値: 65 → 次は 66 から！
    }
}
