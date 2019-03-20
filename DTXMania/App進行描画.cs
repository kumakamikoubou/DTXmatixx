﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using FDK;

namespace DTXMania
{
    class App進行描画 : FDK.進行描画
    {

        // グローバルリソース(static)


        public static Random 乱数 { get; protected set; }

        public static システム設定 システム設定 { get; set; }

        public static サウンドデバイス サウンドデバイス { get; protected set; }

        public static SoundTimer サウンドタイマ { get; protected set; }

        public static システムサウンド システムサウンド { get; protected set; }



        // 生成と終了


        protected override void On開始する()
        {
            App進行描画.乱数 = new Random( DateTime.Now.Millisecond );
            //App進行描画.システム設定 = システム設定.読み込む();   --> App() で初期化する。
            App進行描画.サウンドデバイス = new サウンドデバイス( CSCore.CoreAudioAPI.AudioClientShareMode.Shared ) {
                音量 = 0.5f, // マスタ音量（小:0～1:大）... 0.5を超えるとだいたいWASAPI共有モードのリミッターに抑制されるようになる
            };
            App進行描画.サウンドタイマ = new SoundTimer( App進行描画.サウンドデバイス );
            App進行描画.システムサウンド = new システムサウンド();

            this.起動ステージ = new 起動ステージ();
            this.終了ステージ = new 終了ステージ();

            this._fps = new FPS();


            // 最初のステージを設定し、活性化する。

            this.現在のステージ = this.終了ステージ;
            this.終了ステージ.活性化する();
        }

        protected override void On終了する()
        {
            this.現在のステージ = null;

            this._fps?.Dispose();

            this.起動ステージ?.Dispose();
            this.終了ステージ?.Dispose();

            App進行描画.システムサウンド?.Dispose();
            App進行描画.サウンドタイマ?.Dispose();
            App進行描画.サウンドデバイス?.Dispose();
        }



        // 進行と描画


        protected ステージ 現在のステージ;

        protected override void 進行する()
        {
            if( this._fps.FPSをカウントしプロパティを更新する() )
                this._FPSが変更された();

            
            // ステージを進行する。

            this.現在のステージ?.進行する();

            
            // 進行結果により処理分岐。

            switch( this.現在のステージ )
            {
                case 起動ステージ stage:
                    break;
            }
        }

        protected override void 描画する()
        {
            this._fps.VPSをカウントする();


            // ステージを描画する。

            this.現在のステージ.描画する();
        }



        // ステージ


        protected 起動ステージ 起動ステージ;

        protected 終了ステージ 終了ステージ;



        // サイズ変更


        protected override void スワップチェーンに依存するグラフィックリソースを作成する()
        {
            base.スワップチェーンに依存するグラフィックリソースを作成する();
        }

        protected override void スワップチェーンに依存するグラフィックリソースを解放する()
        {
            base.スワップチェーンに依存するグラフィックリソースを解放する();
        }



        // VPS, FPS


        private void _FPSが変更された()
        {
            Debug.WriteLine( $"{this._fps.現在のVPS}vps, {this._fps.現在のFPS}fps" );
        }

        private FPS _fps;



        // IDTXManiaService の実装


        #region " IDTXManiaService.ViewerPlay "
        //----------------
        public AutoResetEvent ViewerPlay( string path, int startPart = 0, bool drumsSound = true )
        {
            var msg = new ViewerPlayメッセージ {
                path = path,
                startPart = startPart,
                drumSound = drumsSound,
            };
            this._メッセージキュー.Enqueue( msg );
            return msg.完了通知;
        }

        private class ViewerPlayメッセージ : 通知メッセージ
        {
            public string path = "";
            public int startPart = 0;
            public bool drumSound = true;
        }

        private void _ViewrePlay( ViewerPlayメッセージ msg )
        {
            // undone: ViewerPlay の実装
            throw new NotImplementedException();
        }
        //----------------
        #endregion

        #region " IDTXManiaService.ViewerStop "
        //----------------
        public AutoResetEvent ViewerStop()
        {
            var msg = new ViewerStopメッセージ();
            this._メッセージキュー.Enqueue( msg );
            return msg.完了通知;
        }

        private class ViewerStopメッセージ : 通知メッセージ
        {
        }

        private void _ViewerStop( ViewerStopメッセージ msg )
        {
            // undone: ViewerStop の実装
            throw new NotImplementedException();
        }
        //----------------
        #endregion

        #region " IDTXManiaService.GetSoundDelay "
        //----------------
        public float GetSoundDelay()    // 常に同期
        {
            // undone: GetSoundDelay の実装
            throw new NotImplementedException();
        }
        //----------------
        #endregion
    }
}
