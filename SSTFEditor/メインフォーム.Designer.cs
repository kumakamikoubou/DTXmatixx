﻿namespace SSTFEditor
{
	partial class メインフォーム
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(メインフォーム));
            this.splitContainer分割パネルコンテナ = new System.Windows.Forms.SplitContainer();
            this.tabControl情報タブコンテナ = new System.Windows.Forms.TabControl();
            this.tabPage基本情報 = new System.Windows.Forms.TabPage();
            this.pictureBoxプレビュー画像 = new System.Windows.Forms.PictureBox();
            this.buttonプレビュー画像参照 = new System.Windows.Forms.Button();
            this.textBoxプレビュー画像 = new System.Windows.Forms.TextBox();
            this.labelプレビュー画像 = new System.Windows.Forms.Label();
            this.buttonプレビューサウンド参照 = new System.Windows.Forms.Button();
            this.textBoxプレビュー音声 = new System.Windows.Forms.TextBox();
            this.labelプレビュー音声 = new System.Windows.Forms.Label();
            this.labelメモ用小節番号 = new System.Windows.Forms.Label();
            this.labelアーティスト名 = new System.Windows.Forms.Label();
            this.textBoxアーティスト名 = new System.Windows.Forms.TextBox();
            this.buttonBGM参照 = new System.Windows.Forms.Button();
            this.labelBGM = new System.Windows.Forms.Label();
            this.textBoxBGM = new System.Windows.Forms.TextBox();
            this.buttonBGV参照 = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.trackBarLevel = new System.Windows.Forms.TrackBar();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textBoxメモ = new System.Windows.Forms.TextBox();
            this.numericUpDownメモ用小節番号 = new System.Windows.Forms.NumericUpDown();
            this.labelメモ小節単位 = new System.Windows.Forms.Label();
            this.labelBGV = new System.Windows.Forms.Label();
            this.textBoxBGV = new System.Windows.Forms.TextBox();
            this.label説明 = new System.Windows.Forms.Label();
            this.textBox説明 = new System.Windows.Forms.TextBox();
            this.label曲名 = new System.Windows.Forms.Label();
            this.textBox曲名 = new System.Windows.Forms.TextBox();
            this.label現在のチップ種別 = new System.Windows.Forms.Label();
            this.labelCurrentChipType = new System.Windows.Forms.Label();
            this.pictureBox譜面パネル = new System.Windows.Forms.PictureBox();
            this.statusStripステータスバー = new System.Windows.Forms.StatusStrip();
            this.menuStripメニューバー = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemファイル = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem新規作成 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem開く = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem上書き保存 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem名前を付けて保存 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem終了 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem編集 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem元に戻す = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemやり直す = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem切り取り = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemコピー = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem貼り付け = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem削除 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemすべて選択 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem選択モード = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem編集モード = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemモード切替え = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem検索 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem表示 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔4分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔6分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔8分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔12分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔16分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔24分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔32分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔36分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔48分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔64分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔128分 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔フリー = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemガイド間隔拡大 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemガイド間隔縮小 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem再生 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem先頭から再生 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem現在位置から再生 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem現在位置からBGMのみ再生 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem再生停止 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemツール = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemオプション = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemヘルプ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemバージョン = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripツールバー = new System.Windows.Forms.ToolStrip();
            this.toolStripButton新規作成 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton開く = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton上書き保存 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton切り取り = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonコピー = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton貼り付け = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton削除 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton元に戻す = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonやり直す = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox譜面拡大率 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxガイド間隔 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton選択モード = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton編集モード = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton先頭から再生 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton現在位置から再生 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton現在位置からBGMのみ再生 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton再生停止 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox再生速度 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton音量Down = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel音量 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton音量UP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.vScrollBar譜面用垂直スクロールバー = new System.Windows.Forms.VScrollBar();
            this.toolTipメインフォーム = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip譜面右メニュー = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem選択チップの切り取り = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem選択チップのコピー = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem選択チップの貼り付け = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem選択チップの削除 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemすべてのチップの選択 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem小節長変更 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem小節の挿入 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem小節の削除 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem音量指定 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem音量8 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer分割パネルコンテナ)).BeginInit();
            this.splitContainer分割パネルコンテナ.Panel1.SuspendLayout();
            this.splitContainer分割パネルコンテナ.Panel2.SuspendLayout();
            this.splitContainer分割パネルコンテナ.SuspendLayout();
            this.tabControl情報タブコンテナ.SuspendLayout();
            this.tabPage基本情報.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxプレビュー画像)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownメモ用小節番号)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox譜面パネル)).BeginInit();
            this.menuStripメニューバー.SuspendLayout();
            this.toolStripツールバー.SuspendLayout();
            this.contextMenuStrip譜面右メニュー.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer分割パネルコンテナ
            // 
            resources.ApplyResources(this.splitContainer分割パネルコンテナ, "splitContainer分割パネルコンテナ");
            this.splitContainer分割パネルコンテナ.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer分割パネルコンテナ.Name = "splitContainer分割パネルコンテナ";
            // 
            // splitContainer分割パネルコンテナ.Panel1
            // 
            resources.ApplyResources(this.splitContainer分割パネルコンテナ.Panel1, "splitContainer分割パネルコンテナ.Panel1");
            this.splitContainer分割パネルコンテナ.Panel1.Controls.Add(this.tabControl情報タブコンテナ);
            this.toolTipメインフォーム.SetToolTip(this.splitContainer分割パネルコンテナ.Panel1, resources.GetString("splitContainer分割パネルコンテナ.Panel1.ToolTip"));
            // 
            // splitContainer分割パネルコンテナ.Panel2
            // 
            resources.ApplyResources(this.splitContainer分割パネルコンテナ.Panel2, "splitContainer分割パネルコンテナ.Panel2");
            this.splitContainer分割パネルコンテナ.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer分割パネルコンテナ.Panel2.Controls.Add(this.label現在のチップ種別);
            this.splitContainer分割パネルコンテナ.Panel2.Controls.Add(this.labelCurrentChipType);
            this.splitContainer分割パネルコンテナ.Panel2.Controls.Add(this.pictureBox譜面パネル);
            this.toolTipメインフォーム.SetToolTip(this.splitContainer分割パネルコンテナ.Panel2, resources.GetString("splitContainer分割パネルコンテナ.Panel2.ToolTip"));
            this.splitContainer分割パネルコンテナ.Panel2.SizeChanged += new System.EventHandler(this.splitContainer分割パネルコンテナ_Panel2_SizeChanged);
            this.splitContainer分割パネルコンテナ.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer分割パネルコンテナ_Panel2_Paint);
            this.toolTipメインフォーム.SetToolTip(this.splitContainer分割パネルコンテナ, resources.GetString("splitContainer分割パネルコンテナ.ToolTip"));
            // 
            // tabControl情報タブコンテナ
            // 
            resources.ApplyResources(this.tabControl情報タブコンテナ, "tabControl情報タブコンテナ");
            this.tabControl情報タブコンテナ.Controls.Add(this.tabPage基本情報);
            this.tabControl情報タブコンテナ.Name = "tabControl情報タブコンテナ";
            this.tabControl情報タブコンテナ.SelectedIndex = 0;
            this.toolTipメインフォーム.SetToolTip(this.tabControl情報タブコンテナ, resources.GetString("tabControl情報タブコンテナ.ToolTip"));
            // 
            // tabPage基本情報
            // 
            resources.ApplyResources(this.tabPage基本情報, "tabPage基本情報");
            this.tabPage基本情報.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage基本情報.Controls.Add(this.pictureBoxプレビュー画像);
            this.tabPage基本情報.Controls.Add(this.buttonプレビュー画像参照);
            this.tabPage基本情報.Controls.Add(this.textBoxプレビュー画像);
            this.tabPage基本情報.Controls.Add(this.labelプレビュー画像);
            this.tabPage基本情報.Controls.Add(this.buttonプレビューサウンド参照);
            this.tabPage基本情報.Controls.Add(this.textBoxプレビュー音声);
            this.tabPage基本情報.Controls.Add(this.labelプレビュー音声);
            this.tabPage基本情報.Controls.Add(this.labelメモ用小節番号);
            this.tabPage基本情報.Controls.Add(this.labelアーティスト名);
            this.tabPage基本情報.Controls.Add(this.textBoxアーティスト名);
            this.tabPage基本情報.Controls.Add(this.buttonBGM参照);
            this.tabPage基本情報.Controls.Add(this.labelBGM);
            this.tabPage基本情報.Controls.Add(this.textBoxBGM);
            this.tabPage基本情報.Controls.Add(this.buttonBGV参照);
            this.tabPage基本情報.Controls.Add(this.textBoxLevel);
            this.tabPage基本情報.Controls.Add(this.trackBarLevel);
            this.tabPage基本情報.Controls.Add(this.labelLevel);
            this.tabPage基本情報.Controls.Add(this.textBoxメモ);
            this.tabPage基本情報.Controls.Add(this.numericUpDownメモ用小節番号);
            this.tabPage基本情報.Controls.Add(this.labelメモ小節単位);
            this.tabPage基本情報.Controls.Add(this.labelBGV);
            this.tabPage基本情報.Controls.Add(this.textBoxBGV);
            this.tabPage基本情報.Controls.Add(this.label説明);
            this.tabPage基本情報.Controls.Add(this.textBox説明);
            this.tabPage基本情報.Controls.Add(this.label曲名);
            this.tabPage基本情報.Controls.Add(this.textBox曲名);
            this.tabPage基本情報.Name = "tabPage基本情報";
            this.toolTipメインフォーム.SetToolTip(this.tabPage基本情報, resources.GetString("tabPage基本情報.ToolTip"));
            // 
            // pictureBoxプレビュー画像
            // 
            resources.ApplyResources(this.pictureBoxプレビュー画像, "pictureBoxプレビュー画像");
            this.pictureBoxプレビュー画像.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxプレビュー画像.Name = "pictureBoxプレビュー画像";
            this.pictureBoxプレビュー画像.TabStop = false;
            this.toolTipメインフォーム.SetToolTip(this.pictureBoxプレビュー画像, resources.GetString("pictureBoxプレビュー画像.ToolTip"));
            // 
            // buttonプレビュー画像参照
            // 
            resources.ApplyResources(this.buttonプレビュー画像参照, "buttonプレビュー画像参照");
            this.buttonプレビュー画像参照.Name = "buttonプレビュー画像参照";
            this.toolTipメインフォーム.SetToolTip(this.buttonプレビュー画像参照, resources.GetString("buttonプレビュー画像参照.ToolTip"));
            this.buttonプレビュー画像参照.UseVisualStyleBackColor = true;
            this.buttonプレビュー画像参照.Click += new System.EventHandler(this.buttonプレビュー画像参照_Click);
            // 
            // textBoxプレビュー画像
            // 
            resources.ApplyResources(this.textBoxプレビュー画像, "textBoxプレビュー画像");
            this.textBoxプレビュー画像.Name = "textBoxプレビュー画像";
            this.toolTipメインフォーム.SetToolTip(this.textBoxプレビュー画像, resources.GetString("textBoxプレビュー画像.ToolTip"));
            this.textBoxプレビュー画像.TextChanged += new System.EventHandler(this.textBoxプレビュー画像_TextChanged);
            this.textBoxプレビュー画像.Validated += new System.EventHandler(this.textBoxプレビュー画像_Validated);
            // 
            // labelプレビュー画像
            // 
            resources.ApplyResources(this.labelプレビュー画像, "labelプレビュー画像");
            this.labelプレビュー画像.Name = "labelプレビュー画像";
            this.toolTipメインフォーム.SetToolTip(this.labelプレビュー画像, resources.GetString("labelプレビュー画像.ToolTip"));
            // 
            // buttonプレビューサウンド参照
            // 
            resources.ApplyResources(this.buttonプレビューサウンド参照, "buttonプレビューサウンド参照");
            this.buttonプレビューサウンド参照.Name = "buttonプレビューサウンド参照";
            this.toolTipメインフォーム.SetToolTip(this.buttonプレビューサウンド参照, resources.GetString("buttonプレビューサウンド参照.ToolTip"));
            this.buttonプレビューサウンド参照.UseVisualStyleBackColor = true;
            this.buttonプレビューサウンド参照.Click += new System.EventHandler(this.buttonプレビュー音声_Click);
            // 
            // textBoxプレビュー音声
            // 
            resources.ApplyResources(this.textBoxプレビュー音声, "textBoxプレビュー音声");
            this.textBoxプレビュー音声.Name = "textBoxプレビュー音声";
            this.toolTipメインフォーム.SetToolTip(this.textBoxプレビュー音声, resources.GetString("textBoxプレビュー音声.ToolTip"));
            this.textBoxプレビュー音声.TextChanged += new System.EventHandler(this.textBoxプレビュー音声_TextChanged);
            this.textBoxプレビュー音声.Validated += new System.EventHandler(this.textBoxプレビュー音声_Validated);
            // 
            // labelプレビュー音声
            // 
            resources.ApplyResources(this.labelプレビュー音声, "labelプレビュー音声");
            this.labelプレビュー音声.Name = "labelプレビュー音声";
            this.toolTipメインフォーム.SetToolTip(this.labelプレビュー音声, resources.GetString("labelプレビュー音声.ToolTip"));
            // 
            // labelメモ用小節番号
            // 
            resources.ApplyResources(this.labelメモ用小節番号, "labelメモ用小節番号");
            this.labelメモ用小節番号.Name = "labelメモ用小節番号";
            this.toolTipメインフォーム.SetToolTip(this.labelメモ用小節番号, resources.GetString("labelメモ用小節番号.ToolTip"));
            // 
            // labelアーティスト名
            // 
            resources.ApplyResources(this.labelアーティスト名, "labelアーティスト名");
            this.labelアーティスト名.Name = "labelアーティスト名";
            this.toolTipメインフォーム.SetToolTip(this.labelアーティスト名, resources.GetString("labelアーティスト名.ToolTip"));
            // 
            // textBoxアーティスト名
            // 
            resources.ApplyResources(this.textBoxアーティスト名, "textBoxアーティスト名");
            this.textBoxアーティスト名.Name = "textBoxアーティスト名";
            this.toolTipメインフォーム.SetToolTip(this.textBoxアーティスト名, resources.GetString("textBoxアーティスト名.ToolTip"));
            this.textBoxアーティスト名.TextChanged += new System.EventHandler(this.textBoxアーティスト名_TextChanged);
            this.textBoxアーティスト名.Validated += new System.EventHandler(this.textBoxアーティスト名_Validated);
            // 
            // buttonBGM参照
            // 
            resources.ApplyResources(this.buttonBGM参照, "buttonBGM参照");
            this.buttonBGM参照.Name = "buttonBGM参照";
            this.toolTipメインフォーム.SetToolTip(this.buttonBGM参照, resources.GetString("buttonBGM参照.ToolTip"));
            this.buttonBGM参照.UseVisualStyleBackColor = true;
            this.buttonBGM参照.Click += new System.EventHandler(this.buttonBGM参照_Click);
            // 
            // labelBGM
            // 
            resources.ApplyResources(this.labelBGM, "labelBGM");
            this.labelBGM.Name = "labelBGM";
            this.toolTipメインフォーム.SetToolTip(this.labelBGM, resources.GetString("labelBGM.ToolTip"));
            // 
            // textBoxBGM
            // 
            resources.ApplyResources(this.textBoxBGM, "textBoxBGM");
            this.textBoxBGM.Name = "textBoxBGM";
            this.toolTipメインフォーム.SetToolTip(this.textBoxBGM, resources.GetString("textBoxBGM.ToolTip"));
            this.textBoxBGM.TextChanged += new System.EventHandler(this.textBoxBGM_TextChanged);
            this.textBoxBGM.Validated += new System.EventHandler(this.textBoxBGM_Validated);
            // 
            // buttonBGV参照
            // 
            resources.ApplyResources(this.buttonBGV参照, "buttonBGV参照");
            this.buttonBGV参照.Name = "buttonBGV参照";
            this.toolTipメインフォーム.SetToolTip(this.buttonBGV参照, resources.GetString("buttonBGV参照.ToolTip"));
            this.buttonBGV参照.UseVisualStyleBackColor = true;
            this.buttonBGV参照.Click += new System.EventHandler(this.buttonBGV参照_Click);
            // 
            // textBoxLevel
            // 
            resources.ApplyResources(this.textBoxLevel, "textBoxLevel");
            this.textBoxLevel.Name = "textBoxLevel";
            this.toolTipメインフォーム.SetToolTip(this.textBoxLevel, resources.GetString("textBoxLevel.ToolTip"));
            this.textBoxLevel.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLevel_Validating);
            this.textBoxLevel.Validated += new System.EventHandler(this.textBoxLevel_Validated);
            // 
            // trackBarLevel
            // 
            resources.ApplyResources(this.trackBarLevel, "trackBarLevel");
            this.trackBarLevel.LargeChange = 50;
            this.trackBarLevel.Maximum = 999;
            this.trackBarLevel.Name = "trackBarLevel";
            this.toolTipメインフォーム.SetToolTip(this.trackBarLevel, resources.GetString("trackBarLevel.ToolTip"));
            this.trackBarLevel.Value = 500;
            this.trackBarLevel.Scroll += new System.EventHandler(this.trackBarLevel_Scroll);
            // 
            // labelLevel
            // 
            resources.ApplyResources(this.labelLevel, "labelLevel");
            this.labelLevel.Name = "labelLevel";
            this.toolTipメインフォーム.SetToolTip(this.labelLevel, resources.GetString("labelLevel.ToolTip"));
            // 
            // textBoxメモ
            // 
            resources.ApplyResources(this.textBoxメモ, "textBoxメモ");
            this.textBoxメモ.Name = "textBoxメモ";
            this.toolTipメインフォーム.SetToolTip(this.textBoxメモ, resources.GetString("textBoxメモ.ToolTip"));
            this.textBoxメモ.TextChanged += new System.EventHandler(this.textBoxメモ_TextChanged);
            this.textBoxメモ.Validated += new System.EventHandler(this.textBoxメモ_Validated);
            // 
            // numericUpDownメモ用小節番号
            // 
            resources.ApplyResources(this.numericUpDownメモ用小節番号, "numericUpDownメモ用小節番号");
            this.numericUpDownメモ用小節番号.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownメモ用小節番号.Name = "numericUpDownメモ用小節番号";
            this.toolTipメインフォーム.SetToolTip(this.numericUpDownメモ用小節番号, resources.GetString("numericUpDownメモ用小節番号.ToolTip"));
            this.numericUpDownメモ用小節番号.ValueChanged += new System.EventHandler(this.numericUpDownメモ用小節番号_ValueChanged);
            // 
            // labelメモ小節単位
            // 
            resources.ApplyResources(this.labelメモ小節単位, "labelメモ小節単位");
            this.labelメモ小節単位.Name = "labelメモ小節単位";
            this.toolTipメインフォーム.SetToolTip(this.labelメモ小節単位, resources.GetString("labelメモ小節単位.ToolTip"));
            // 
            // labelBGV
            // 
            resources.ApplyResources(this.labelBGV, "labelBGV");
            this.labelBGV.Name = "labelBGV";
            this.toolTipメインフォーム.SetToolTip(this.labelBGV, resources.GetString("labelBGV.ToolTip"));
            // 
            // textBoxBGV
            // 
            resources.ApplyResources(this.textBoxBGV, "textBoxBGV");
            this.textBoxBGV.Name = "textBoxBGV";
            this.toolTipメインフォーム.SetToolTip(this.textBoxBGV, resources.GetString("textBoxBGV.ToolTip"));
            this.textBoxBGV.TextChanged += new System.EventHandler(this.textBoxBGV_TextChanged);
            this.textBoxBGV.Validated += new System.EventHandler(this.textBoxBGV_Validated);
            // 
            // label説明
            // 
            resources.ApplyResources(this.label説明, "label説明");
            this.label説明.Name = "label説明";
            this.toolTipメインフォーム.SetToolTip(this.label説明, resources.GetString("label説明.ToolTip"));
            // 
            // textBox説明
            // 
            resources.ApplyResources(this.textBox説明, "textBox説明");
            this.textBox説明.Name = "textBox説明";
            this.toolTipメインフォーム.SetToolTip(this.textBox説明, resources.GetString("textBox説明.ToolTip"));
            this.textBox説明.TextChanged += new System.EventHandler(this.textBox説明_TextChanged);
            this.textBox説明.Validated += new System.EventHandler(this.textBox説明_Validated);
            // 
            // label曲名
            // 
            resources.ApplyResources(this.label曲名, "label曲名");
            this.label曲名.Name = "label曲名";
            this.toolTipメインフォーム.SetToolTip(this.label曲名, resources.GetString("label曲名.ToolTip"));
            // 
            // textBox曲名
            // 
            resources.ApplyResources(this.textBox曲名, "textBox曲名");
            this.textBox曲名.Name = "textBox曲名";
            this.toolTipメインフォーム.SetToolTip(this.textBox曲名, resources.GetString("textBox曲名.ToolTip"));
            this.textBox曲名.TextChanged += new System.EventHandler(this.textBox曲名_TextChanged);
            this.textBox曲名.Validated += new System.EventHandler(this.textBox曲名_Validated);
            // 
            // label現在のチップ種別
            // 
            resources.ApplyResources(this.label現在のチップ種別, "label現在のチップ種別");
            this.label現在のチップ種別.ForeColor = System.Drawing.Color.Red;
            this.label現在のチップ種別.Name = "label現在のチップ種別";
            this.toolTipメインフォーム.SetToolTip(this.label現在のチップ種別, resources.GetString("label現在のチップ種別.ToolTip"));
            // 
            // labelCurrentChipType
            // 
            resources.ApplyResources(this.labelCurrentChipType, "labelCurrentChipType");
            this.labelCurrentChipType.ForeColor = System.Drawing.Color.White;
            this.labelCurrentChipType.Name = "labelCurrentChipType";
            this.toolTipメインフォーム.SetToolTip(this.labelCurrentChipType, resources.GetString("labelCurrentChipType.ToolTip"));
            // 
            // pictureBox譜面パネル
            // 
            resources.ApplyResources(this.pictureBox譜面パネル, "pictureBox譜面パネル");
            this.pictureBox譜面パネル.BackColor = System.Drawing.Color.Black;
            this.pictureBox譜面パネル.Name = "pictureBox譜面パネル";
            this.pictureBox譜面パネル.TabStop = false;
            this.toolTipメインフォーム.SetToolTip(this.pictureBox譜面パネル, resources.GetString("pictureBox譜面パネル.ToolTip"));
            this.pictureBox譜面パネル.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox譜面パネル_Paint);
            this.pictureBox譜面パネル.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox譜面パネル_MouseClick);
            this.pictureBox譜面パネル.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox譜面パネル_MouseDown);
            this.pictureBox譜面パネル.MouseEnter += new System.EventHandler(this.pictureBox譜面パネル_MouseEnter);
            this.pictureBox譜面パネル.MouseLeave += new System.EventHandler(this.pictureBox譜面パネル_MouseLeave);
            this.pictureBox譜面パネル.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox譜面パネル_MouseMove);
            this.pictureBox譜面パネル.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox譜面パネル_PreviewKeyDown);
            // 
            // statusStripステータスバー
            // 
            resources.ApplyResources(this.statusStripステータスバー, "statusStripステータスバー");
            this.statusStripステータスバー.Name = "statusStripステータスバー";
            this.toolTipメインフォーム.SetToolTip(this.statusStripステータスバー, resources.GetString("statusStripステータスバー.ToolTip"));
            // 
            // menuStripメニューバー
            // 
            resources.ApplyResources(this.menuStripメニューバー, "menuStripメニューバー");
            this.menuStripメニューバー.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemファイル,
            this.toolStripMenuItem編集,
            this.toolStripMenuItem表示,
            this.toolStripMenuItem再生,
            this.toolStripMenuItemツール,
            this.toolStripMenuItemヘルプ});
            this.menuStripメニューバー.Name = "menuStripメニューバー";
            this.toolTipメインフォーム.SetToolTip(this.menuStripメニューバー, resources.GetString("menuStripメニューバー.ToolTip"));
            // 
            // toolStripMenuItemファイル
            // 
            resources.ApplyResources(this.toolStripMenuItemファイル, "toolStripMenuItemファイル");
            this.toolStripMenuItemファイル.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem新規作成,
            this.toolStripMenuItem開く,
            this.toolStripMenuItem上書き保存,
            this.toolStripMenuItem名前を付けて保存,
            this.toolStripSeparator1,
            this.toolStripMenuItem終了});
            this.toolStripMenuItemファイル.Name = "toolStripMenuItemファイル";
            // 
            // toolStripMenuItem新規作成
            // 
            resources.ApplyResources(this.toolStripMenuItem新規作成, "toolStripMenuItem新規作成");
            this.toolStripMenuItem新規作成.Name = "toolStripMenuItem新規作成";
            this.toolStripMenuItem新規作成.Click += new System.EventHandler(this.toolStripMenuItem新規作成_Click);
            // 
            // toolStripMenuItem開く
            // 
            resources.ApplyResources(this.toolStripMenuItem開く, "toolStripMenuItem開く");
            this.toolStripMenuItem開く.Name = "toolStripMenuItem開く";
            this.toolStripMenuItem開く.Click += new System.EventHandler(this.toolStripMenuItem開く_Click);
            // 
            // toolStripMenuItem上書き保存
            // 
            resources.ApplyResources(this.toolStripMenuItem上書き保存, "toolStripMenuItem上書き保存");
            this.toolStripMenuItem上書き保存.Name = "toolStripMenuItem上書き保存";
            this.toolStripMenuItem上書き保存.Click += new System.EventHandler(this.toolStripMenuItem上書き保存_Click);
            // 
            // toolStripMenuItem名前を付けて保存
            // 
            resources.ApplyResources(this.toolStripMenuItem名前を付けて保存, "toolStripMenuItem名前を付けて保存");
            this.toolStripMenuItem名前を付けて保存.Name = "toolStripMenuItem名前を付けて保存";
            this.toolStripMenuItem名前を付けて保存.Click += new System.EventHandler(this.toolStripMenuItem名前を付けて保存_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripMenuItem終了
            // 
            resources.ApplyResources(this.toolStripMenuItem終了, "toolStripMenuItem終了");
            this.toolStripMenuItem終了.Name = "toolStripMenuItem終了";
            this.toolStripMenuItem終了.Click += new System.EventHandler(this.toolStripMenuItem終了_Click);
            // 
            // toolStripMenuItem編集
            // 
            resources.ApplyResources(this.toolStripMenuItem編集, "toolStripMenuItem編集");
            this.toolStripMenuItem編集.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem元に戻す,
            this.toolStripMenuItemやり直す,
            this.toolStripSeparator2,
            this.toolStripMenuItem切り取り,
            this.toolStripMenuItemコピー,
            this.toolStripMenuItem貼り付け,
            this.toolStripMenuItem削除,
            this.toolStripSeparator3,
            this.toolStripMenuItemすべて選択,
            this.toolStripSeparator4,
            this.toolStripMenuItem選択モード,
            this.toolStripMenuItem編集モード,
            this.toolStripMenuItemモード切替え,
            this.toolStripSeparator5,
            this.toolStripMenuItem検索});
            this.toolStripMenuItem編集.Name = "toolStripMenuItem編集";
            // 
            // toolStripMenuItem元に戻す
            // 
            resources.ApplyResources(this.toolStripMenuItem元に戻す, "toolStripMenuItem元に戻す");
            this.toolStripMenuItem元に戻す.Name = "toolStripMenuItem元に戻す";
            this.toolStripMenuItem元に戻す.Click += new System.EventHandler(this.toolStripMenuItem元に戻す_Click);
            // 
            // toolStripMenuItemやり直す
            // 
            resources.ApplyResources(this.toolStripMenuItemやり直す, "toolStripMenuItemやり直す");
            this.toolStripMenuItemやり直す.Name = "toolStripMenuItemやり直す";
            this.toolStripMenuItemやり直す.Click += new System.EventHandler(this.toolStripMenuItemやり直す_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripMenuItem切り取り
            // 
            resources.ApplyResources(this.toolStripMenuItem切り取り, "toolStripMenuItem切り取り");
            this.toolStripMenuItem切り取り.Name = "toolStripMenuItem切り取り";
            this.toolStripMenuItem切り取り.Click += new System.EventHandler(this.toolStripMenuItem切り取り_Click);
            // 
            // toolStripMenuItemコピー
            // 
            resources.ApplyResources(this.toolStripMenuItemコピー, "toolStripMenuItemコピー");
            this.toolStripMenuItemコピー.Name = "toolStripMenuItemコピー";
            this.toolStripMenuItemコピー.Click += new System.EventHandler(this.toolStripMenuItemコピー_Click);
            // 
            // toolStripMenuItem貼り付け
            // 
            resources.ApplyResources(this.toolStripMenuItem貼り付け, "toolStripMenuItem貼り付け");
            this.toolStripMenuItem貼り付け.Name = "toolStripMenuItem貼り付け";
            this.toolStripMenuItem貼り付け.Click += new System.EventHandler(this.toolStripMenuItem貼り付け_Click);
            // 
            // toolStripMenuItem削除
            // 
            resources.ApplyResources(this.toolStripMenuItem削除, "toolStripMenuItem削除");
            this.toolStripMenuItem削除.Name = "toolStripMenuItem削除";
            this.toolStripMenuItem削除.Click += new System.EventHandler(this.toolStripMenuItem削除_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripMenuItemすべて選択
            // 
            resources.ApplyResources(this.toolStripMenuItemすべて選択, "toolStripMenuItemすべて選択");
            this.toolStripMenuItemすべて選択.Name = "toolStripMenuItemすべて選択";
            this.toolStripMenuItemすべて選択.Click += new System.EventHandler(this.toolStripMenuItemすべて選択_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripMenuItem選択モード
            // 
            resources.ApplyResources(this.toolStripMenuItem選択モード, "toolStripMenuItem選択モード");
            this.toolStripMenuItem選択モード.Name = "toolStripMenuItem選択モード";
            this.toolStripMenuItem選択モード.Click += new System.EventHandler(this.toolStripMenuItem選択モード_Click);
            // 
            // toolStripMenuItem編集モード
            // 
            resources.ApplyResources(this.toolStripMenuItem編集モード, "toolStripMenuItem編集モード");
            this.toolStripMenuItem編集モード.Name = "toolStripMenuItem編集モード";
            this.toolStripMenuItem編集モード.Click += new System.EventHandler(this.toolStripMenuItem編集モード_Click);
            // 
            // toolStripMenuItemモード切替え
            // 
            resources.ApplyResources(this.toolStripMenuItemモード切替え, "toolStripMenuItemモード切替え");
            this.toolStripMenuItemモード切替え.Name = "toolStripMenuItemモード切替え";
            this.toolStripMenuItemモード切替え.Click += new System.EventHandler(this.toolStripMenuItemモード切替え_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolStripMenuItem検索
            // 
            resources.ApplyResources(this.toolStripMenuItem検索, "toolStripMenuItem検索");
            this.toolStripMenuItem検索.Name = "toolStripMenuItem検索";
            this.toolStripMenuItem検索.Click += new System.EventHandler(this.toolStripMenuItem検索_Click);
            // 
            // toolStripMenuItem表示
            // 
            resources.ApplyResources(this.toolStripMenuItem表示, "toolStripMenuItem表示");
            this.toolStripMenuItem表示.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemガイド間隔});
            this.toolStripMenuItem表示.Name = "toolStripMenuItem表示";
            // 
            // toolStripMenuItemガイド間隔
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔, "toolStripMenuItemガイド間隔");
            this.toolStripMenuItemガイド間隔.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemガイド間隔4分,
            this.toolStripMenuItemガイド間隔6分,
            this.toolStripMenuItemガイド間隔8分,
            this.toolStripMenuItemガイド間隔12分,
            this.toolStripMenuItemガイド間隔16分,
            this.toolStripMenuItemガイド間隔24分,
            this.toolStripMenuItemガイド間隔32分,
            this.toolStripMenuItemガイド間隔36分,
            this.toolStripMenuItemガイド間隔48分,
            this.toolStripMenuItemガイド間隔64分,
            this.toolStripMenuItemガイド間隔128分,
            this.toolStripMenuItemガイド間隔フリー,
            this.toolStripSeparator6,
            this.toolStripMenuItemガイド間隔拡大,
            this.toolStripMenuItemガイド間隔縮小});
            this.toolStripMenuItemガイド間隔.Name = "toolStripMenuItemガイド間隔";
            // 
            // toolStripMenuItemガイド間隔4分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔4分, "toolStripMenuItemガイド間隔4分");
            this.toolStripMenuItemガイド間隔4分.Name = "toolStripMenuItemガイド間隔4分";
            this.toolStripMenuItemガイド間隔4分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔4分_Click);
            // 
            // toolStripMenuItemガイド間隔6分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔6分, "toolStripMenuItemガイド間隔6分");
            this.toolStripMenuItemガイド間隔6分.Name = "toolStripMenuItemガイド間隔6分";
            this.toolStripMenuItemガイド間隔6分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔6分_Click);
            // 
            // toolStripMenuItemガイド間隔8分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔8分, "toolStripMenuItemガイド間隔8分");
            this.toolStripMenuItemガイド間隔8分.Name = "toolStripMenuItemガイド間隔8分";
            this.toolStripMenuItemガイド間隔8分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔8分_Click);
            // 
            // toolStripMenuItemガイド間隔12分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔12分, "toolStripMenuItemガイド間隔12分");
            this.toolStripMenuItemガイド間隔12分.Name = "toolStripMenuItemガイド間隔12分";
            this.toolStripMenuItemガイド間隔12分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔12分_Click);
            // 
            // toolStripMenuItemガイド間隔16分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔16分, "toolStripMenuItemガイド間隔16分");
            this.toolStripMenuItemガイド間隔16分.Name = "toolStripMenuItemガイド間隔16分";
            this.toolStripMenuItemガイド間隔16分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔16分_Click);
            // 
            // toolStripMenuItemガイド間隔24分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔24分, "toolStripMenuItemガイド間隔24分");
            this.toolStripMenuItemガイド間隔24分.Name = "toolStripMenuItemガイド間隔24分";
            this.toolStripMenuItemガイド間隔24分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔24分_Click);
            // 
            // toolStripMenuItemガイド間隔32分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔32分, "toolStripMenuItemガイド間隔32分");
            this.toolStripMenuItemガイド間隔32分.Name = "toolStripMenuItemガイド間隔32分";
            this.toolStripMenuItemガイド間隔32分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔32分_Click);
            // 
            // toolStripMenuItemガイド間隔36分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔36分, "toolStripMenuItemガイド間隔36分");
            this.toolStripMenuItemガイド間隔36分.Name = "toolStripMenuItemガイド間隔36分";
            this.toolStripMenuItemガイド間隔36分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔36分_Click);
            // 
            // toolStripMenuItemガイド間隔48分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔48分, "toolStripMenuItemガイド間隔48分");
            this.toolStripMenuItemガイド間隔48分.Name = "toolStripMenuItemガイド間隔48分";
            this.toolStripMenuItemガイド間隔48分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔48分_Click);
            // 
            // toolStripMenuItemガイド間隔64分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔64分, "toolStripMenuItemガイド間隔64分");
            this.toolStripMenuItemガイド間隔64分.Name = "toolStripMenuItemガイド間隔64分";
            this.toolStripMenuItemガイド間隔64分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔64分_Click);
            // 
            // toolStripMenuItemガイド間隔128分
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔128分, "toolStripMenuItemガイド間隔128分");
            this.toolStripMenuItemガイド間隔128分.Name = "toolStripMenuItemガイド間隔128分";
            this.toolStripMenuItemガイド間隔128分.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔128分_Click);
            // 
            // toolStripMenuItemガイド間隔フリー
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔フリー, "toolStripMenuItemガイド間隔フリー");
            this.toolStripMenuItemガイド間隔フリー.Name = "toolStripMenuItemガイド間隔フリー";
            this.toolStripMenuItemガイド間隔フリー.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔フリー_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // toolStripMenuItemガイド間隔拡大
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔拡大, "toolStripMenuItemガイド間隔拡大");
            this.toolStripMenuItemガイド間隔拡大.Name = "toolStripMenuItemガイド間隔拡大";
            this.toolStripMenuItemガイド間隔拡大.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔拡大_Click);
            // 
            // toolStripMenuItemガイド間隔縮小
            // 
            resources.ApplyResources(this.toolStripMenuItemガイド間隔縮小, "toolStripMenuItemガイド間隔縮小");
            this.toolStripMenuItemガイド間隔縮小.Name = "toolStripMenuItemガイド間隔縮小";
            this.toolStripMenuItemガイド間隔縮小.Click += new System.EventHandler(this.toolStripMenuItemガイド間隔縮小_Click);
            // 
            // toolStripMenuItem再生
            // 
            resources.ApplyResources(this.toolStripMenuItem再生, "toolStripMenuItem再生");
            this.toolStripMenuItem再生.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem先頭から再生,
            this.toolStripMenuItem現在位置から再生,
            this.toolStripMenuItem現在位置からBGMのみ再生,
            this.toolStripMenuItem再生停止});
            this.toolStripMenuItem再生.Name = "toolStripMenuItem再生";
            // 
            // toolStripMenuItem先頭から再生
            // 
            resources.ApplyResources(this.toolStripMenuItem先頭から再生, "toolStripMenuItem先頭から再生");
            this.toolStripMenuItem先頭から再生.Name = "toolStripMenuItem先頭から再生";
            this.toolStripMenuItem先頭から再生.Click += new System.EventHandler(this.toolStripMenuItem先頭から再生_Click);
            // 
            // toolStripMenuItem現在位置から再生
            // 
            resources.ApplyResources(this.toolStripMenuItem現在位置から再生, "toolStripMenuItem現在位置から再生");
            this.toolStripMenuItem現在位置から再生.Name = "toolStripMenuItem現在位置から再生";
            this.toolStripMenuItem現在位置から再生.Click += new System.EventHandler(this.toolStripMenuItem現在位置から再生_Click);
            // 
            // toolStripMenuItem現在位置からBGMのみ再生
            // 
            resources.ApplyResources(this.toolStripMenuItem現在位置からBGMのみ再生, "toolStripMenuItem現在位置からBGMのみ再生");
            this.toolStripMenuItem現在位置からBGMのみ再生.Name = "toolStripMenuItem現在位置からBGMのみ再生";
            this.toolStripMenuItem現在位置からBGMのみ再生.Click += new System.EventHandler(this.toolStripMenuItem現在位置からBGMのみ再生_Click);
            // 
            // toolStripMenuItem再生停止
            // 
            resources.ApplyResources(this.toolStripMenuItem再生停止, "toolStripMenuItem再生停止");
            this.toolStripMenuItem再生停止.Name = "toolStripMenuItem再生停止";
            this.toolStripMenuItem再生停止.Click += new System.EventHandler(this.toolStripMenuItem再生停止_Click);
            // 
            // toolStripMenuItemツール
            // 
            resources.ApplyResources(this.toolStripMenuItemツール, "toolStripMenuItemツール");
            this.toolStripMenuItemツール.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemオプション});
            this.toolStripMenuItemツール.Name = "toolStripMenuItemツール";
            // 
            // toolStripMenuItemオプション
            // 
            resources.ApplyResources(this.toolStripMenuItemオプション, "toolStripMenuItemオプション");
            this.toolStripMenuItemオプション.Name = "toolStripMenuItemオプション";
            this.toolStripMenuItemオプション.Click += new System.EventHandler(this.toolStripMenuItemオプション_Click);
            // 
            // toolStripMenuItemヘルプ
            // 
            resources.ApplyResources(this.toolStripMenuItemヘルプ, "toolStripMenuItemヘルプ");
            this.toolStripMenuItemヘルプ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemバージョン});
            this.toolStripMenuItemヘルプ.Name = "toolStripMenuItemヘルプ";
            // 
            // toolStripMenuItemバージョン
            // 
            resources.ApplyResources(this.toolStripMenuItemバージョン, "toolStripMenuItemバージョン");
            this.toolStripMenuItemバージョン.Name = "toolStripMenuItemバージョン";
            this.toolStripMenuItemバージョン.Click += new System.EventHandler(this.toolStripMenuItemバージョン_Click);
            // 
            // toolStripツールバー
            // 
            resources.ApplyResources(this.toolStripツールバー, "toolStripツールバー");
            this.toolStripツールバー.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton新規作成,
            this.toolStripButton開く,
            this.toolStripButton上書き保存,
            this.toolStripSeparator7,
            this.toolStripButton切り取り,
            this.toolStripButtonコピー,
            this.toolStripButton貼り付け,
            this.toolStripButton削除,
            this.toolStripSeparator8,
            this.toolStripButton元に戻す,
            this.toolStripButtonやり直す,
            this.toolStripSeparator9,
            this.toolStripComboBox譜面拡大率,
            this.toolStripComboBoxガイド間隔,
            this.toolStripButton選択モード,
            this.toolStripButton編集モード,
            this.toolStripSeparator10,
            this.toolStripButton先頭から再生,
            this.toolStripButton現在位置から再生,
            this.toolStripButton現在位置からBGMのみ再生,
            this.toolStripButton再生停止,
            this.toolStripComboBox再生速度,
            this.toolStripSeparator11,
            this.toolStripButton音量Down,
            this.toolStripLabel音量,
            this.toolStripButton音量UP,
            this.toolStripSeparator15});
            this.toolStripツールバー.Name = "toolStripツールバー";
            this.toolTipメインフォーム.SetToolTip(this.toolStripツールバー, resources.GetString("toolStripツールバー.ToolTip"));
            // 
            // toolStripButton新規作成
            // 
            resources.ApplyResources(this.toolStripButton新規作成, "toolStripButton新規作成");
            this.toolStripButton新規作成.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton新規作成.Name = "toolStripButton新規作成";
            this.toolStripButton新規作成.Click += new System.EventHandler(this.toolStripButton新規作成_Click);
            // 
            // toolStripButton開く
            // 
            resources.ApplyResources(this.toolStripButton開く, "toolStripButton開く");
            this.toolStripButton開く.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton開く.Name = "toolStripButton開く";
            this.toolStripButton開く.Click += new System.EventHandler(this.toolStripButton開く_Click);
            // 
            // toolStripButton上書き保存
            // 
            resources.ApplyResources(this.toolStripButton上書き保存, "toolStripButton上書き保存");
            this.toolStripButton上書き保存.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton上書き保存.Name = "toolStripButton上書き保存";
            this.toolStripButton上書き保存.Click += new System.EventHandler(this.toolStripButton上書き保存_Click);
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // toolStripButton切り取り
            // 
            resources.ApplyResources(this.toolStripButton切り取り, "toolStripButton切り取り");
            this.toolStripButton切り取り.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton切り取り.Name = "toolStripButton切り取り";
            this.toolStripButton切り取り.Click += new System.EventHandler(this.toolStripButton切り取り_Click);
            // 
            // toolStripButtonコピー
            // 
            resources.ApplyResources(this.toolStripButtonコピー, "toolStripButtonコピー");
            this.toolStripButtonコピー.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonコピー.Name = "toolStripButtonコピー";
            this.toolStripButtonコピー.Click += new System.EventHandler(this.toolStripButtonコピー_Click);
            // 
            // toolStripButton貼り付け
            // 
            resources.ApplyResources(this.toolStripButton貼り付け, "toolStripButton貼り付け");
            this.toolStripButton貼り付け.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton貼り付け.Name = "toolStripButton貼り付け";
            this.toolStripButton貼り付け.Click += new System.EventHandler(this.toolStripButton貼り付け_Click);
            // 
            // toolStripButton削除
            // 
            resources.ApplyResources(this.toolStripButton削除, "toolStripButton削除");
            this.toolStripButton削除.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton削除.Name = "toolStripButton削除";
            this.toolStripButton削除.Click += new System.EventHandler(this.toolStripButton削除_Click);
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // toolStripButton元に戻す
            // 
            resources.ApplyResources(this.toolStripButton元に戻す, "toolStripButton元に戻す");
            this.toolStripButton元に戻す.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton元に戻す.Name = "toolStripButton元に戻す";
            this.toolStripButton元に戻す.Click += new System.EventHandler(this.toolStripButton元に戻す_Click);
            // 
            // toolStripButtonやり直す
            // 
            resources.ApplyResources(this.toolStripButtonやり直す, "toolStripButtonやり直す");
            this.toolStripButtonやり直す.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonやり直す.Name = "toolStripButtonやり直す";
            this.toolStripButtonやり直す.Click += new System.EventHandler(this.toolStripButtonやり直す_Click);
            // 
            // toolStripSeparator9
            // 
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            // 
            // toolStripComboBox譜面拡大率
            // 
            resources.ApplyResources(this.toolStripComboBox譜面拡大率, "toolStripComboBox譜面拡大率");
            this.toolStripComboBox譜面拡大率.DropDownHeight = 200;
            this.toolStripComboBox譜面拡大率.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox譜面拡大率.DropDownWidth = 75;
            this.toolStripComboBox譜面拡大率.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox譜面拡大率.Items"),
            resources.GetString("toolStripComboBox譜面拡大率.Items1"),
            resources.GetString("toolStripComboBox譜面拡大率.Items2"),
            resources.GetString("toolStripComboBox譜面拡大率.Items3"),
            resources.GetString("toolStripComboBox譜面拡大率.Items4"),
            resources.GetString("toolStripComboBox譜面拡大率.Items5"),
            resources.GetString("toolStripComboBox譜面拡大率.Items6"),
            resources.GetString("toolStripComboBox譜面拡大率.Items7"),
            resources.GetString("toolStripComboBox譜面拡大率.Items8"),
            resources.GetString("toolStripComboBox譜面拡大率.Items9"),
            resources.GetString("toolStripComboBox譜面拡大率.Items10"),
            resources.GetString("toolStripComboBox譜面拡大率.Items11"),
            resources.GetString("toolStripComboBox譜面拡大率.Items12")});
            this.toolStripComboBox譜面拡大率.Name = "toolStripComboBox譜面拡大率";
            this.toolStripComboBox譜面拡大率.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox譜面拡大率_SelectedIndexChanged);
            // 
            // toolStripComboBoxガイド間隔
            // 
            resources.ApplyResources(this.toolStripComboBoxガイド間隔, "toolStripComboBoxガイド間隔");
            this.toolStripComboBoxガイド間隔.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxガイド間隔.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBoxガイド間隔.Items"),
            resources.GetString("toolStripComboBoxガイド間隔.Items1"),
            resources.GetString("toolStripComboBoxガイド間隔.Items2"),
            resources.GetString("toolStripComboBoxガイド間隔.Items3"),
            resources.GetString("toolStripComboBoxガイド間隔.Items4"),
            resources.GetString("toolStripComboBoxガイド間隔.Items5"),
            resources.GetString("toolStripComboBoxガイド間隔.Items6"),
            resources.GetString("toolStripComboBoxガイド間隔.Items7"),
            resources.GetString("toolStripComboBoxガイド間隔.Items8"),
            resources.GetString("toolStripComboBoxガイド間隔.Items9"),
            resources.GetString("toolStripComboBoxガイド間隔.Items10"),
            resources.GetString("toolStripComboBoxガイド間隔.Items11")});
            this.toolStripComboBoxガイド間隔.Name = "toolStripComboBoxガイド間隔";
            this.toolStripComboBoxガイド間隔.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxガイド間隔_SelectedIndexChanged);
            // 
            // toolStripButton選択モード
            // 
            resources.ApplyResources(this.toolStripButton選択モード, "toolStripButton選択モード");
            this.toolStripButton選択モード.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton選択モード.Name = "toolStripButton選択モード";
            this.toolStripButton選択モード.Click += new System.EventHandler(this.toolStripButton選択モード_Click);
            // 
            // toolStripButton編集モード
            // 
            resources.ApplyResources(this.toolStripButton編集モード, "toolStripButton編集モード");
            this.toolStripButton編集モード.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton編集モード.Name = "toolStripButton編集モード";
            this.toolStripButton編集モード.Click += new System.EventHandler(this.toolStripButton編集モード_Click);
            // 
            // toolStripSeparator10
            // 
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            // 
            // toolStripButton先頭から再生
            // 
            resources.ApplyResources(this.toolStripButton先頭から再生, "toolStripButton先頭から再生");
            this.toolStripButton先頭から再生.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton先頭から再生.Name = "toolStripButton先頭から再生";
            this.toolStripButton先頭から再生.Click += new System.EventHandler(this.toolStripButton先頭から再生_Click);
            // 
            // toolStripButton現在位置から再生
            // 
            resources.ApplyResources(this.toolStripButton現在位置から再生, "toolStripButton現在位置から再生");
            this.toolStripButton現在位置から再生.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton現在位置から再生.Name = "toolStripButton現在位置から再生";
            this.toolStripButton現在位置から再生.Click += new System.EventHandler(this.toolStripButton現在位置から再生_Click);
            // 
            // toolStripButton現在位置からBGMのみ再生
            // 
            resources.ApplyResources(this.toolStripButton現在位置からBGMのみ再生, "toolStripButton現在位置からBGMのみ再生");
            this.toolStripButton現在位置からBGMのみ再生.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton現在位置からBGMのみ再生.Name = "toolStripButton現在位置からBGMのみ再生";
            this.toolStripButton現在位置からBGMのみ再生.Click += new System.EventHandler(this.toolStripButton現在位置からBGMのみ再生_Click);
            // 
            // toolStripButton再生停止
            // 
            resources.ApplyResources(this.toolStripButton再生停止, "toolStripButton再生停止");
            this.toolStripButton再生停止.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton再生停止.Name = "toolStripButton再生停止";
            this.toolStripButton再生停止.Click += new System.EventHandler(this.toolStripButton再生停止_Click);
            // 
            // toolStripComboBox再生速度
            // 
            resources.ApplyResources(this.toolStripComboBox再生速度, "toolStripComboBox再生速度");
            this.toolStripComboBox再生速度.DropDownHeight = 150;
            this.toolStripComboBox再生速度.DropDownWidth = 35;
            this.toolStripComboBox再生速度.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox再生速度.Items"),
            resources.GetString("toolStripComboBox再生速度.Items1"),
            resources.GetString("toolStripComboBox再生速度.Items2"),
            resources.GetString("toolStripComboBox再生速度.Items3"),
            resources.GetString("toolStripComboBox再生速度.Items4"),
            resources.GetString("toolStripComboBox再生速度.Items5"),
            resources.GetString("toolStripComboBox再生速度.Items6"),
            resources.GetString("toolStripComboBox再生速度.Items7"),
            resources.GetString("toolStripComboBox再生速度.Items8"),
            resources.GetString("toolStripComboBox再生速度.Items9"),
            resources.GetString("toolStripComboBox再生速度.Items10"),
            resources.GetString("toolStripComboBox再生速度.Items11"),
            resources.GetString("toolStripComboBox再生速度.Items12"),
            resources.GetString("toolStripComboBox再生速度.Items13"),
            resources.GetString("toolStripComboBox再生速度.Items14")});
            this.toolStripComboBox再生速度.Name = "toolStripComboBox再生速度";
            this.toolStripComboBox再生速度.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox再生速度_SelectedIndexChanged);
            // 
            // toolStripSeparator11
            // 
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            // 
            // toolStripButton音量Down
            // 
            resources.ApplyResources(this.toolStripButton音量Down, "toolStripButton音量Down");
            this.toolStripButton音量Down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton音量Down.Name = "toolStripButton音量Down";
            this.toolStripButton音量Down.Click += new System.EventHandler(this.toolStripButton音量Down_Click);
            // 
            // toolStripLabel音量
            // 
            resources.ApplyResources(this.toolStripLabel音量, "toolStripLabel音量");
            this.toolStripLabel音量.Name = "toolStripLabel音量";
            // 
            // toolStripButton音量UP
            // 
            resources.ApplyResources(this.toolStripButton音量UP, "toolStripButton音量UP");
            this.toolStripButton音量UP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton音量UP.Name = "toolStripButton音量UP";
            this.toolStripButton音量UP.Click += new System.EventHandler(this.toolStripButton音量UP_Click);
            // 
            // toolStripSeparator15
            // 
            resources.ApplyResources(this.toolStripSeparator15, "toolStripSeparator15");
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            // 
            // vScrollBar譜面用垂直スクロールバー
            // 
            resources.ApplyResources(this.vScrollBar譜面用垂直スクロールバー, "vScrollBar譜面用垂直スクロールバー");
            this.vScrollBar譜面用垂直スクロールバー.Name = "vScrollBar譜面用垂直スクロールバー";
            this.toolTipメインフォーム.SetToolTip(this.vScrollBar譜面用垂直スクロールバー, resources.GetString("vScrollBar譜面用垂直スクロールバー.ToolTip"));
            this.vScrollBar譜面用垂直スクロールバー.ValueChanged += new System.EventHandler(this.vScrollBar譜面用垂直スクロールバー_ValueChanged);
            // 
            // contextMenuStrip譜面右メニュー
            // 
            resources.ApplyResources(this.contextMenuStrip譜面右メニュー, "contextMenuStrip譜面右メニュー");
            this.contextMenuStrip譜面右メニュー.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem選択チップの切り取り,
            this.toolStripMenuItem選択チップのコピー,
            this.toolStripMenuItem選択チップの貼り付け,
            this.toolStripMenuItem選択チップの削除,
            this.toolStripSeparator12,
            this.toolStripMenuItemすべてのチップの選択,
            this.toolStripSeparator13,
            this.toolStripMenuItem小節長変更,
            this.toolStripSeparator14,
            this.toolStripMenuItem小節の挿入,
            this.toolStripMenuItem小節の削除,
            this.toolStripSeparator16,
            this.toolStripMenuItem音量指定});
            this.contextMenuStrip譜面右メニュー.Name = "contextMenuStrip譜面右メニュー";
            this.toolTipメインフォーム.SetToolTip(this.contextMenuStrip譜面右メニュー, resources.GetString("contextMenuStrip譜面右メニュー.ToolTip"));
            // 
            // toolStripMenuItem選択チップの切り取り
            // 
            resources.ApplyResources(this.toolStripMenuItem選択チップの切り取り, "toolStripMenuItem選択チップの切り取り");
            this.toolStripMenuItem選択チップの切り取り.Name = "toolStripMenuItem選択チップの切り取り";
            this.toolStripMenuItem選択チップの切り取り.Click += new System.EventHandler(this.toolStripMenuItem選択チップの切り取り_Click);
            // 
            // toolStripMenuItem選択チップのコピー
            // 
            resources.ApplyResources(this.toolStripMenuItem選択チップのコピー, "toolStripMenuItem選択チップのコピー");
            this.toolStripMenuItem選択チップのコピー.Name = "toolStripMenuItem選択チップのコピー";
            this.toolStripMenuItem選択チップのコピー.Click += new System.EventHandler(this.toolStripMenuItem選択チップのコピー_Click);
            // 
            // toolStripMenuItem選択チップの貼り付け
            // 
            resources.ApplyResources(this.toolStripMenuItem選択チップの貼り付け, "toolStripMenuItem選択チップの貼り付け");
            this.toolStripMenuItem選択チップの貼り付け.Name = "toolStripMenuItem選択チップの貼り付け";
            this.toolStripMenuItem選択チップの貼り付け.Click += new System.EventHandler(this.toolStripMenuItem選択チップの貼り付け_Click);
            // 
            // toolStripMenuItem選択チップの削除
            // 
            resources.ApplyResources(this.toolStripMenuItem選択チップの削除, "toolStripMenuItem選択チップの削除");
            this.toolStripMenuItem選択チップの削除.Name = "toolStripMenuItem選択チップの削除";
            this.toolStripMenuItem選択チップの削除.Click += new System.EventHandler(this.toolStripMenuItem選択チップの削除_Click);
            // 
            // toolStripSeparator12
            // 
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            // 
            // toolStripMenuItemすべてのチップの選択
            // 
            resources.ApplyResources(this.toolStripMenuItemすべてのチップの選択, "toolStripMenuItemすべてのチップの選択");
            this.toolStripMenuItemすべてのチップの選択.Name = "toolStripMenuItemすべてのチップの選択";
            this.toolStripMenuItemすべてのチップの選択.Click += new System.EventHandler(this.toolStripMenuItemすべてのチップの選択_Click);
            // 
            // toolStripSeparator13
            // 
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            // 
            // toolStripMenuItem小節長変更
            // 
            resources.ApplyResources(this.toolStripMenuItem小節長変更, "toolStripMenuItem小節長変更");
            this.toolStripMenuItem小節長変更.Name = "toolStripMenuItem小節長変更";
            this.toolStripMenuItem小節長変更.Click += new System.EventHandler(this.toolStripMenuItem小節長変更_Click);
            // 
            // toolStripSeparator14
            // 
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            // 
            // toolStripMenuItem小節の挿入
            // 
            resources.ApplyResources(this.toolStripMenuItem小節の挿入, "toolStripMenuItem小節の挿入");
            this.toolStripMenuItem小節の挿入.Name = "toolStripMenuItem小節の挿入";
            this.toolStripMenuItem小節の挿入.Click += new System.EventHandler(this.toolStripMenuItem小節の挿入_Click);
            // 
            // toolStripMenuItem小節の削除
            // 
            resources.ApplyResources(this.toolStripMenuItem小節の削除, "toolStripMenuItem小節の削除");
            this.toolStripMenuItem小節の削除.Name = "toolStripMenuItem小節の削除";
            this.toolStripMenuItem小節の削除.Click += new System.EventHandler(this.toolStripMenuItem小節の削除_Click);
            // 
            // toolStripSeparator16
            // 
            resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            // 
            // toolStripMenuItem音量指定
            // 
            resources.ApplyResources(this.toolStripMenuItem音量指定, "toolStripMenuItem音量指定");
            this.toolStripMenuItem音量指定.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem音量1,
            this.toolStripMenuItem音量2,
            this.toolStripMenuItem音量3,
            this.toolStripMenuItem音量4,
            this.toolStripMenuItem音量5,
            this.toolStripMenuItem音量6,
            this.toolStripMenuItem音量7,
            this.toolStripMenuItem音量8});
            this.toolStripMenuItem音量指定.Name = "toolStripMenuItem音量指定";
            // 
            // toolStripMenuItem音量1
            // 
            resources.ApplyResources(this.toolStripMenuItem音量1, "toolStripMenuItem音量1");
            this.toolStripMenuItem音量1.Name = "toolStripMenuItem音量1";
            this.toolStripMenuItem音量1.Click += new System.EventHandler(this.toolStripMenuItem音量1_Click);
            // 
            // toolStripMenuItem音量2
            // 
            resources.ApplyResources(this.toolStripMenuItem音量2, "toolStripMenuItem音量2");
            this.toolStripMenuItem音量2.Name = "toolStripMenuItem音量2";
            this.toolStripMenuItem音量2.Click += new System.EventHandler(this.toolStripMenuItem音量2_Click);
            // 
            // toolStripMenuItem音量3
            // 
            resources.ApplyResources(this.toolStripMenuItem音量3, "toolStripMenuItem音量3");
            this.toolStripMenuItem音量3.Name = "toolStripMenuItem音量3";
            this.toolStripMenuItem音量3.Click += new System.EventHandler(this.toolStripMenuItem音量3_Click);
            // 
            // toolStripMenuItem音量4
            // 
            resources.ApplyResources(this.toolStripMenuItem音量4, "toolStripMenuItem音量4");
            this.toolStripMenuItem音量4.Name = "toolStripMenuItem音量4";
            this.toolStripMenuItem音量4.Click += new System.EventHandler(this.toolStripMenuItem音量4_Click);
            // 
            // toolStripMenuItem音量5
            // 
            resources.ApplyResources(this.toolStripMenuItem音量5, "toolStripMenuItem音量5");
            this.toolStripMenuItem音量5.Name = "toolStripMenuItem音量5";
            this.toolStripMenuItem音量5.Click += new System.EventHandler(this.toolStripMenuItem音量5_Click);
            // 
            // toolStripMenuItem音量6
            // 
            resources.ApplyResources(this.toolStripMenuItem音量6, "toolStripMenuItem音量6");
            this.toolStripMenuItem音量6.Name = "toolStripMenuItem音量6";
            this.toolStripMenuItem音量6.Click += new System.EventHandler(this.toolStripMenuItem音量6_Click);
            // 
            // toolStripMenuItem音量7
            // 
            resources.ApplyResources(this.toolStripMenuItem音量7, "toolStripMenuItem音量7");
            this.toolStripMenuItem音量7.Name = "toolStripMenuItem音量7";
            this.toolStripMenuItem音量7.Click += new System.EventHandler(this.toolStripMenuItem音量7_Click);
            // 
            // toolStripMenuItem音量8
            // 
            resources.ApplyResources(this.toolStripMenuItem音量8, "toolStripMenuItem音量8");
            this.toolStripMenuItem音量8.Name = "toolStripMenuItem音量8";
            this.toolStripMenuItem音量8.Click += new System.EventHandler(this.toolStripMenuItem音量8_Click);
            // 
            // メインフォーム
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer分割パネルコンテナ);
            this.Controls.Add(this.vScrollBar譜面用垂直スクロールバー);
            this.Controls.Add(this.toolStripツールバー);
            this.Controls.Add(this.statusStripステータスバー);
            this.Controls.Add(this.menuStripメニューバー);
            this.MainMenuStrip = this.menuStripメニューバー;
            this.Name = "メインフォーム";
            this.toolTipメインフォーム.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.メインフォーム_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.メインフォーム_ResizeEnd);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.メインフォーム_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.メインフォーム_DragEnter);
            this.splitContainer分割パネルコンテナ.Panel1.ResumeLayout(false);
            this.splitContainer分割パネルコンテナ.Panel2.ResumeLayout(false);
            this.splitContainer分割パネルコンテナ.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer分割パネルコンテナ)).EndInit();
            this.splitContainer分割パネルコンテナ.ResumeLayout(false);
            this.tabControl情報タブコンテナ.ResumeLayout(false);
            this.tabPage基本情報.ResumeLayout(false);
            this.tabPage基本情報.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxプレビュー画像)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownメモ用小節番号)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox譜面パネル)).EndInit();
            this.menuStripメニューバー.ResumeLayout(false);
            this.menuStripメニューバー.PerformLayout();
            this.toolStripツールバー.ResumeLayout(false);
            this.toolStripツールバー.PerformLayout();
            this.contextMenuStrip譜面右メニュー.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.StatusStrip statusStripステータスバー;
		private System.Windows.Forms.MenuStrip menuStripメニューバー;
		private System.Windows.Forms.ToolStrip toolStripツールバー;
		private System.Windows.Forms.VScrollBar vScrollBar譜面用垂直スクロールバー;
		private System.Windows.Forms.SplitContainer splitContainer分割パネルコンテナ;
		private System.Windows.Forms.PictureBox pictureBox譜面パネル;
		private System.Windows.Forms.TabControl tabControl情報タブコンテナ;
		private System.Windows.Forms.TabPage tabPage基本情報;
		private System.Windows.Forms.TextBox textBox曲名;
		private System.Windows.Forms.Label label説明;
		private System.Windows.Forms.TextBox textBox説明;
		private System.Windows.Forms.Label label曲名;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemファイル;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem新規作成;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem開く;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem上書き保存;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem名前を付けて保存;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem終了;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem編集;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem元に戻す;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemやり直す;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem切り取り;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemコピー;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem貼り付け;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem削除;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemすべて選択;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem選択モード;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem編集モード;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemモード切替え;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem検索;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem表示;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔4分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔8分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔12分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔16分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔24分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔32分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔48分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔64分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔128分;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔フリー;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔拡大;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔縮小;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem再生;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem先頭から再生;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem現在位置から再生;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem現在位置からBGMのみ再生;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem再生停止;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemツール;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemオプション;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemヘルプ;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemバージョン;
		private System.Windows.Forms.ToolStripButton toolStripButton新規作成;
		private System.Windows.Forms.ToolTip toolTipメインフォーム;
		private System.Windows.Forms.ToolStripButton toolStripButton開く;
		private System.Windows.Forms.ToolStripButton toolStripButton上書き保存;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton toolStripButton切り取り;
		private System.Windows.Forms.ToolStripButton toolStripButtonコピー;
		private System.Windows.Forms.ToolStripButton toolStripButton貼り付け;
		private System.Windows.Forms.ToolStripButton toolStripButton削除;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton toolStripButton元に戻す;
		private System.Windows.Forms.ToolStripButton toolStripButtonやり直す;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox譜面拡大率;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxガイド間隔;
		private System.Windows.Forms.ToolStripButton toolStripButton選択モード;
		private System.Windows.Forms.ToolStripButton toolStripButton編集モード;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripButton toolStripButton先頭から再生;
		private System.Windows.Forms.ToolStripButton toolStripButton現在位置から再生;
		private System.Windows.Forms.ToolStripButton toolStripButton現在位置からBGMのみ再生;
		private System.Windows.Forms.ToolStripButton toolStripButton再生停止;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.Label labelBGV;
		private System.Windows.Forms.TextBox textBoxBGV;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip譜面右メニュー;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem選択チップの切り取り;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem選択チップのコピー;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem選択チップの貼り付け;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem選択チップの削除;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemすべてのチップの選択;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem小節長変更;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem小節の挿入;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem小節の削除;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔6分;
		private System.Windows.Forms.Label labelCurrentChipType;
		private System.Windows.Forms.Label label現在のチップ種別;
		private System.Windows.Forms.NumericUpDown numericUpDownメモ用小節番号;
		private System.Windows.Forms.Label labelメモ小節単位;
		private System.Windows.Forms.TextBox textBoxメモ;
		private System.Windows.Forms.ToolStripButton toolStripButton音量Down;
		private System.Windows.Forms.ToolStripButton toolStripButton音量UP;
		private System.Windows.Forms.ToolStripLabel toolStripLabel音量;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemガイド間隔36分;
		private System.Windows.Forms.TextBox textBoxLevel;
		private System.Windows.Forms.TrackBar trackBarLevel;
		private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Button buttonBGV参照;
        private System.Windows.Forms.Button buttonBGM参照;
        private System.Windows.Forms.Label labelBGM;
        private System.Windows.Forms.TextBox textBoxBGM;
        private System.Windows.Forms.Label labelアーティスト名;
        private System.Windows.Forms.TextBox textBoxアーティスト名;
        private System.Windows.Forms.Label labelメモ用小節番号;
        private System.Windows.Forms.TextBox textBoxプレビュー音声;
        private System.Windows.Forms.Label labelプレビュー音声;
        private System.Windows.Forms.Button buttonプレビューサウンド参照;
        private System.Windows.Forms.Label labelプレビュー画像;
        private System.Windows.Forms.Button buttonプレビュー画像参照;
        private System.Windows.Forms.TextBox textBoxプレビュー画像;
        private System.Windows.Forms.PictureBox pictureBoxプレビュー画像;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox再生速度;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量指定;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem音量8;
    }
}

