﻿namespace FirstPlugin.Forms
{
    partial class GFLXMaterialEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stTabControl1 = new Toolbox.Library.Forms.STTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stPanel1 = new Toolbox.Library.Forms.STPanel();
            this.stFlowLayoutPanel1 = new Toolbox.Library.Forms.STFlowLayoutPanel();
            this.stDropDownPanel1 = new Toolbox.Library.Forms.STDropDownPanel();
            this.listViewCustom1 = new Toolbox.Library.Forms.ListViewCustom();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stDropDownPanel2 = new Toolbox.Library.Forms.STDropDownPanel();
            this.stPanel3 = new Toolbox.Library.Forms.STPanel();
            this.stPanel5 = new Toolbox.Library.Forms.STPanel();
            this.uvViewport1 = new Toolbox.Library.Forms.UVViewport();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.stPanel4 = new Toolbox.Library.Forms.STPanel();
            this.stTabControl2 = new Toolbox.Library.Forms.STTabControl();
            this.ParamsTabPage = new System.Windows.Forms.TabPage();
            this.stLabel3 = new Toolbox.Library.Forms.STLabel();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.stLabel1 = new Toolbox.Library.Forms.STLabel();
            this.wrapModeWCB = new Toolbox.Library.Forms.STComboBox();
            this.wrapModeVCB = new Toolbox.Library.Forms.STComboBox();
            this.wrapModeUCB = new Toolbox.Library.Forms.STComboBox();
            this.param6CB = new BarSlider.BarSlider();
            this.param5CB = new BarSlider.BarSlider();
            this.stTextBox2 = new Toolbox.Library.Forms.STTextBox();
            this.stTextBox1 = new Toolbox.Library.Forms.STTextBox();
            this.param4CB = new BarSlider.BarSlider();
            this.param2CB = new BarSlider.BarSlider();
            this.param3CB = new BarSlider.BarSlider();
            this.param1CB = new BarSlider.BarSlider();
            this.TransformTabPage = new System.Windows.Forms.TabPage();
            this.stPanel6 = new Toolbox.Library.Forms.STPanel();
            this.transformParamTB = new Toolbox.Library.Forms.STTextBox();
            this.translateYUD = new BarSlider.BarSlider();
            this.translateXUD = new BarSlider.BarSlider();
            this.scaleYUD = new BarSlider.BarSlider();
            this.scaleXUD = new BarSlider.BarSlider();
            this.stPanel2 = new Toolbox.Library.Forms.STPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stPanel7 = new Toolbox.Library.Forms.STPanel();
            this.stTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.stPanel1.SuspendLayout();
            this.stFlowLayoutPanel1.SuspendLayout();
            this.stDropDownPanel1.SuspendLayout();
            this.stDropDownPanel2.SuspendLayout();
            this.stPanel3.SuspendLayout();
            this.stPanel5.SuspendLayout();
            this.stPanel4.SuspendLayout();
            this.stTabControl2.SuspendLayout();
            this.ParamsTabPage.SuspendLayout();
            this.TransformTabPage.SuspendLayout();
            this.stPanel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // stTabControl1
            // 
            this.stTabControl1.Controls.Add(this.tabPage1);
            this.stTabControl1.Controls.Add(this.tabPage2);
            this.stTabControl1.Controls.Add(this.tabPage3);
            this.stTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stTabControl1.Location = new System.Drawing.Point(0, 0);
            this.stTabControl1.myBackColor = System.Drawing.Color.Empty;
            this.stTabControl1.Name = "stTabControl1";
            this.stTabControl1.SelectedIndex = 0;
            this.stTabControl1.Size = new System.Drawing.Size(575, 769);
            this.stTabControl1.TabIndex = 0;
            this.stTabControl1.SelectedIndexChanged += new System.EventHandler(this.stTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "纹理贴图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stPanel1
            // 
            this.stPanel1.Controls.Add(this.stFlowLayoutPanel1);
            this.stPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel1.Location = new System.Drawing.Point(3, 3);
            this.stPanel1.Name = "stPanel1";
            this.stPanel1.Size = new System.Drawing.Size(561, 734);
            this.stPanel1.TabIndex = 0;
            // 
            // stFlowLayoutPanel1
            // 
            this.stFlowLayoutPanel1.Controls.Add(this.stDropDownPanel1);
            this.stFlowLayoutPanel1.Controls.Add(this.stDropDownPanel2);
            this.stFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stFlowLayoutPanel1.FixedHeight = true;
            this.stFlowLayoutPanel1.FixedWidth = true;
            this.stFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.stFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.stFlowLayoutPanel1.Name = "stFlowLayoutPanel1";
            this.stFlowLayoutPanel1.Size = new System.Drawing.Size(561, 734);
            this.stFlowLayoutPanel1.TabIndex = 0;
            // 
            // stDropDownPanel1
            // 
            this.stDropDownPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stDropDownPanel1.Controls.Add(this.listViewCustom1);
            this.stDropDownPanel1.ExpandedHeight = 0;
            this.stDropDownPanel1.IsExpanded = true;
            this.stDropDownPanel1.Location = new System.Drawing.Point(0, 0);
            this.stDropDownPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.stDropDownPanel1.Name = "stDropDownPanel1";
            this.stDropDownPanel1.PanelName = "Textures";
            this.stDropDownPanel1.PanelValueName = "";
            this.stDropDownPanel1.SetIcon = null;
            this.stDropDownPanel1.SetIconAlphaColor = System.Drawing.Color.Transparent;
            this.stDropDownPanel1.SetIconColor = System.Drawing.Color.Transparent;
            this.stDropDownPanel1.Size = new System.Drawing.Size(561, 207);
            this.stDropDownPanel1.TabIndex = 0;
            // 
            // listViewCustom1
            // 
            this.listViewCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCustom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCustom1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCustom1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewCustom1.HideSelection = false;
            this.listViewCustom1.Location = new System.Drawing.Point(3, 22);
            this.listViewCustom1.Name = "listViewCustom1";
            this.listViewCustom1.OwnerDraw = true;
            this.listViewCustom1.Size = new System.Drawing.Size(570, 185);
            this.listViewCustom1.TabIndex = 1;
            this.listViewCustom1.UseCompatibleStateImageBehavior = false;
            this.listViewCustom1.View = System.Windows.Forms.View.Details;
            this.listViewCustom1.SelectedIndexChanged += new System.EventHandler(this.listViewCustom1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 384;
            // 
            // stDropDownPanel2
            // 
            this.stDropDownPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stDropDownPanel2.Controls.Add(this.stPanel3);
            this.stDropDownPanel2.ExpandedHeight = 0;
            this.stDropDownPanel2.IsExpanded = true;
            this.stDropDownPanel2.Location = new System.Drawing.Point(0, 207);
            this.stDropDownPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.stDropDownPanel2.Name = "stDropDownPanel2";
            this.stDropDownPanel2.PanelName = "Texture Params";
            this.stDropDownPanel2.PanelValueName = "";
            this.stDropDownPanel2.SetIcon = null;
            this.stDropDownPanel2.SetIconAlphaColor = System.Drawing.Color.Transparent;
            this.stDropDownPanel2.SetIconColor = System.Drawing.Color.Transparent;
            this.stDropDownPanel2.Size = new System.Drawing.Size(561, 495);
            this.stDropDownPanel2.TabIndex = 1;
            // 
            // stPanel3
            // 
            this.stPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stPanel3.Controls.Add(this.stPanel5);
            this.stPanel3.Controls.Add(this.splitter1);
            this.stPanel3.Controls.Add(this.stPanel4);
            this.stPanel3.Location = new System.Drawing.Point(3, 28);
            this.stPanel3.Name = "stPanel3";
            this.stPanel3.Size = new System.Drawing.Size(555, 467);
            this.stPanel3.TabIndex = 15;
            // 
            // stPanel5
            // 
            this.stPanel5.Controls.Add(this.uvViewport1);
            this.stPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel5.Location = new System.Drawing.Point(172, 0);
            this.stPanel5.Name = "stPanel5";
            this.stPanel5.Size = new System.Drawing.Size(383, 467);
            this.stPanel5.TabIndex = 17;
            // 
            // uvViewport1
            // 
            this.uvViewport1.ActiveTextureMap = null;
            this.uvViewport1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uvViewport1.Location = new System.Drawing.Point(-1, 0);
            this.uvViewport1.Name = "uvViewport1";
            this.uvViewport1.Size = new System.Drawing.Size(381, 464);
            this.uvViewport1.TabIndex = 14;
            this.uvViewport1.UseGrid = true;
            this.uvViewport1.UseOrtho = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(169, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 467);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // stPanel4
            // 
            this.stPanel4.Controls.Add(this.stTabControl2);
            this.stPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.stPanel4.Location = new System.Drawing.Point(0, 0);
            this.stPanel4.Name = "stPanel4";
            this.stPanel4.Size = new System.Drawing.Size(169, 467);
            this.stPanel4.TabIndex = 15;
            // 
            // stTabControl2
            // 
            this.stTabControl2.Controls.Add(this.ParamsTabPage);
            this.stTabControl2.Controls.Add(this.TransformTabPage);
            this.stTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stTabControl2.Location = new System.Drawing.Point(0, 0);
            this.stTabControl2.myBackColor = System.Drawing.Color.Empty;
            this.stTabControl2.Name = "stTabControl2";
            this.stTabControl2.SelectedIndex = 0;
            this.stTabControl2.Size = new System.Drawing.Size(169, 467);
            this.stTabControl2.TabIndex = 17;
            // 
            // ParamsTabPage
            // 
            this.ParamsTabPage.Controls.Add(this.stLabel3);
            this.ParamsTabPage.Controls.Add(this.stLabel2);
            this.ParamsTabPage.Controls.Add(this.stLabel1);
            this.ParamsTabPage.Controls.Add(this.wrapModeWCB);
            this.ParamsTabPage.Controls.Add(this.wrapModeVCB);
            this.ParamsTabPage.Controls.Add(this.wrapModeUCB);
            this.ParamsTabPage.Controls.Add(this.param6CB);
            this.ParamsTabPage.Controls.Add(this.param5CB);
            this.ParamsTabPage.Controls.Add(this.stTextBox2);
            this.ParamsTabPage.Controls.Add(this.stTextBox1);
            this.ParamsTabPage.Controls.Add(this.param4CB);
            this.ParamsTabPage.Controls.Add(this.param2CB);
            this.ParamsTabPage.Controls.Add(this.param3CB);
            this.ParamsTabPage.Controls.Add(this.param1CB);
            this.ParamsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ParamsTabPage.Name = "ParamsTabPage";
            this.ParamsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParamsTabPage.Size = new System.Drawing.Size(161, 438);
            this.ParamsTabPage.TabIndex = 1;
            this.ParamsTabPage.Text = "参数";
            this.ParamsTabPage.UseVisualStyleBackColor = true;
            // 
            // stLabel3
            // 
            this.stLabel3.AutoSize = true;
            this.stLabel3.Location = new System.Drawing.Point(6, 115);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(47, 13);
            this.stLabel3.TabIndex = 22;
            this.stLabel3.Text = "包装 W";
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(6, 88);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(43, 13);
            this.stLabel2.TabIndex = 21;
            this.stLabel2.Text = "包装 V";
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = true;
            this.stLabel1.Location = new System.Drawing.Point(6, 61);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(44, 13);
            this.stLabel1.TabIndex = 20;
            this.stLabel1.Text = "包装 U";
            // 
            // wrapModeWCB
            // 
            this.wrapModeWCB.BorderColor = System.Drawing.Color.Empty;
            this.wrapModeWCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wrapModeWCB.ButtonColor = System.Drawing.Color.Empty;
            this.wrapModeWCB.FormattingEnabled = true;
            this.wrapModeWCB.IsReadOnly = false;
            this.wrapModeWCB.Location = new System.Drawing.Point(61, 112);
            this.wrapModeWCB.Name = "wrapModeWCB";
            this.wrapModeWCB.Size = new System.Drawing.Size(94, 21);
            this.wrapModeWCB.TabIndex = 19;
            // 
            // wrapModeVCB
            // 
            this.wrapModeVCB.BorderColor = System.Drawing.Color.Empty;
            this.wrapModeVCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wrapModeVCB.ButtonColor = System.Drawing.Color.Empty;
            this.wrapModeVCB.FormattingEnabled = true;
            this.wrapModeVCB.IsReadOnly = false;
            this.wrapModeVCB.Location = new System.Drawing.Point(61, 85);
            this.wrapModeVCB.Name = "wrapModeVCB";
            this.wrapModeVCB.Size = new System.Drawing.Size(94, 21);
            this.wrapModeVCB.TabIndex = 18;
            // 
            // wrapModeUCB
            // 
            this.wrapModeUCB.BorderColor = System.Drawing.Color.Empty;
            this.wrapModeUCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wrapModeUCB.ButtonColor = System.Drawing.Color.Empty;
            this.wrapModeUCB.FormattingEnabled = true;
            this.wrapModeUCB.IsReadOnly = false;
            this.wrapModeUCB.Location = new System.Drawing.Point(61, 58);
            this.wrapModeUCB.Name = "wrapModeUCB";
            this.wrapModeUCB.Size = new System.Drawing.Size(94, 21);
            this.wrapModeUCB.TabIndex = 17;
            // 
            // param6CB
            // 
            this.param6CB.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.param6CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.param6CB.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.param6CB.BarPenColorBottom = System.Drawing.Color.Empty;
            this.param6CB.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.param6CB.BarPenColorTop = System.Drawing.Color.Empty;
            this.param6CB.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.param6CB.DataType = null;
            this.param6CB.DrawSemitransparentThumb = false;
            this.param6CB.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.param6CB.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.param6CB.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.param6CB.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.param6CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.param6CB.IncrementAmount = 0.01F;
            this.param6CB.InputName = "Param6";
            this.param6CB.LargeChange = 5F;
            this.param6CB.Location = new System.Drawing.Point(6, 318);
            this.param6CB.Maximum = 9999999F;
            this.param6CB.Minimum = -9999999F;
            this.param6CB.Name = "param6CB";
            this.param6CB.Precision = 0.01F;
            this.param6CB.ScaleDivisions = 1;
            this.param6CB.ScaleSubDivisions = 2;
            this.param6CB.ShowDivisionsText = false;
            this.param6CB.ShowSmallScale = false;
            this.param6CB.Size = new System.Drawing.Size(149, 25);
            this.param6CB.SmallChange = 1F;
            this.param6CB.TabIndex = 16;
            this.param6CB.Text = "barSlider2";
            this.param6CB.ThumbInnerColor = System.Drawing.Color.Empty;
            this.param6CB.ThumbPenColor = System.Drawing.Color.Empty;
            this.param6CB.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.param6CB.ThumbSize = new System.Drawing.Size(1, 1);
            this.param6CB.TickAdd = 0F;
            this.param6CB.TickColor = System.Drawing.Color.White;
            this.param6CB.TickDivide = 0F;
            this.param6CB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.param6CB.UseInterlapsedBar = true;
            this.param6CB.Value = -9999999F;
            // 
            // param5CB
            // 
            this.param5CB.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.param5CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.param5CB.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.param5CB.BarPenColorBottom = System.Drawing.Color.Empty;
            this.param5CB.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.param5CB.BarPenColorTop = System.Drawing.Color.Empty;
            this.param5CB.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.param5CB.DataType = null;
            this.param5CB.DrawSemitransparentThumb = false;
            this.param5CB.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.param5CB.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.param5CB.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.param5CB.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.param5CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.param5CB.IncrementAmount = 0.01F;
            this.param5CB.InputName = "Param5";
            this.param5CB.LargeChange = 5F;
            this.param5CB.Location = new System.Drawing.Point(6, 287);
            this.param5CB.Maximum = 9999999F;
            this.param5CB.Minimum = -9999999F;
            this.param5CB.Name = "param5CB";
            this.param5CB.Precision = 0.01F;
            this.param5CB.ScaleDivisions = 1;
            this.param5CB.ScaleSubDivisions = 2;
            this.param5CB.ShowDivisionsText = false;
            this.param5CB.ShowSmallScale = false;
            this.param5CB.Size = new System.Drawing.Size(149, 25);
            this.param5CB.SmallChange = 1F;
            this.param5CB.TabIndex = 15;
            this.param5CB.Text = "barSlider3";
            this.param5CB.ThumbInnerColor = System.Drawing.Color.Empty;
            this.param5CB.ThumbPenColor = System.Drawing.Color.Empty;
            this.param5CB.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.param5CB.ThumbSize = new System.Drawing.Size(1, 1);
            this.param5CB.TickAdd = 0F;
            this.param5CB.TickColor = System.Drawing.Color.White;
            this.param5CB.TickDivide = 0F;
            this.param5CB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.param5CB.UseInterlapsedBar = true;
            this.param5CB.Value = -9999999F;
            // 
            // stTextBox2
            // 
            this.stTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stTextBox2.Location = new System.Drawing.Point(6, 32);
            this.stTextBox2.Name = "stTextBox2";
            this.stTextBox2.Size = new System.Drawing.Size(149, 20);
            this.stTextBox2.TabIndex = 14;
            // 
            // stTextBox1
            // 
            this.stTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stTextBox1.Location = new System.Drawing.Point(6, 6);
            this.stTextBox1.Name = "stTextBox1";
            this.stTextBox1.Size = new System.Drawing.Size(149, 20);
            this.stTextBox1.TabIndex = 13;
            // 
            // param4CB
            // 
            this.param4CB.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.param4CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.param4CB.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.param4CB.BarPenColorBottom = System.Drawing.Color.Empty;
            this.param4CB.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.param4CB.BarPenColorTop = System.Drawing.Color.Empty;
            this.param4CB.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.param4CB.DataType = null;
            this.param4CB.DrawSemitransparentThumb = false;
            this.param4CB.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.param4CB.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.param4CB.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.param4CB.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.param4CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.param4CB.IncrementAmount = 0.01F;
            this.param4CB.InputName = "Param4";
            this.param4CB.LargeChange = 5F;
            this.param4CB.Location = new System.Drawing.Point(6, 256);
            this.param4CB.Maximum = 9999999F;
            this.param4CB.Minimum = -9999999F;
            this.param4CB.Name = "param4CB";
            this.param4CB.Precision = 0.01F;
            this.param4CB.ScaleDivisions = 1;
            this.param4CB.ScaleSubDivisions = 2;
            this.param4CB.ShowDivisionsText = false;
            this.param4CB.ShowSmallScale = false;
            this.param4CB.Size = new System.Drawing.Size(149, 25);
            this.param4CB.SmallChange = 1F;
            this.param4CB.TabIndex = 12;
            this.param4CB.Text = "barSlider3";
            this.param4CB.ThumbInnerColor = System.Drawing.Color.Empty;
            this.param4CB.ThumbPenColor = System.Drawing.Color.Empty;
            this.param4CB.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.param4CB.ThumbSize = new System.Drawing.Size(1, 1);
            this.param4CB.TickAdd = 0F;
            this.param4CB.TickColor = System.Drawing.Color.White;
            this.param4CB.TickDivide = 0F;
            this.param4CB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.param4CB.UseInterlapsedBar = true;
            this.param4CB.Value = -9999999F;
            // 
            // param2CB
            // 
            this.param2CB.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.param2CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.param2CB.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.param2CB.BarPenColorBottom = System.Drawing.Color.Empty;
            this.param2CB.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.param2CB.BarPenColorTop = System.Drawing.Color.Empty;
            this.param2CB.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.param2CB.DataType = null;
            this.param2CB.DrawSemitransparentThumb = false;
            this.param2CB.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.param2CB.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.param2CB.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.param2CB.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.param2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.param2CB.IncrementAmount = 0.01F;
            this.param2CB.InputName = "Param2";
            this.param2CB.LargeChange = 5F;
            this.param2CB.Location = new System.Drawing.Point(6, 194);
            this.param2CB.Maximum = 9999999F;
            this.param2CB.Minimum = -9999999F;
            this.param2CB.Name = "param2CB";
            this.param2CB.Precision = 0.01F;
            this.param2CB.ScaleDivisions = 1;
            this.param2CB.ScaleSubDivisions = 2;
            this.param2CB.ShowDivisionsText = false;
            this.param2CB.ShowSmallScale = false;
            this.param2CB.Size = new System.Drawing.Size(149, 25);
            this.param2CB.SmallChange = 1F;
            this.param2CB.TabIndex = 10;
            this.param2CB.Text = "barSlider2";
            this.param2CB.ThumbInnerColor = System.Drawing.Color.Empty;
            this.param2CB.ThumbPenColor = System.Drawing.Color.Empty;
            this.param2CB.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.param2CB.ThumbSize = new System.Drawing.Size(1, 1);
            this.param2CB.TickAdd = 0F;
            this.param2CB.TickColor = System.Drawing.Color.White;
            this.param2CB.TickDivide = 0F;
            this.param2CB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.param2CB.UseInterlapsedBar = true;
            this.param2CB.Value = -9999999F;
            // 
            // param3CB
            // 
            this.param3CB.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.param3CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.param3CB.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.param3CB.BarPenColorBottom = System.Drawing.Color.Empty;
            this.param3CB.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.param3CB.BarPenColorTop = System.Drawing.Color.Empty;
            this.param3CB.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.param3CB.DataType = null;
            this.param3CB.DrawSemitransparentThumb = false;
            this.param3CB.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.param3CB.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.param3CB.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.param3CB.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.param3CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.param3CB.IncrementAmount = 0.01F;
            this.param3CB.InputName = "Param3";
            this.param3CB.LargeChange = 5F;
            this.param3CB.Location = new System.Drawing.Point(6, 225);
            this.param3CB.Maximum = 9999999F;
            this.param3CB.Minimum = -9999999F;
            this.param3CB.Name = "param3CB";
            this.param3CB.Precision = 0.01F;
            this.param3CB.ScaleDivisions = 1;
            this.param3CB.ScaleSubDivisions = 2;
            this.param3CB.ShowDivisionsText = false;
            this.param3CB.ShowSmallScale = false;
            this.param3CB.Size = new System.Drawing.Size(149, 25);
            this.param3CB.SmallChange = 1F;
            this.param3CB.TabIndex = 11;
            this.param3CB.Text = "barSlider4";
            this.param3CB.ThumbInnerColor = System.Drawing.Color.Empty;
            this.param3CB.ThumbPenColor = System.Drawing.Color.Empty;
            this.param3CB.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.param3CB.ThumbSize = new System.Drawing.Size(1, 1);
            this.param3CB.TickAdd = 0F;
            this.param3CB.TickColor = System.Drawing.Color.White;
            this.param3CB.TickDivide = 0F;
            this.param3CB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.param3CB.UseInterlapsedBar = true;
            this.param3CB.Value = -9999999F;
            // 
            // param1CB
            // 
            this.param1CB.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.param1CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.param1CB.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.param1CB.BarPenColorBottom = System.Drawing.Color.Empty;
            this.param1CB.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.param1CB.BarPenColorTop = System.Drawing.Color.Empty;
            this.param1CB.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.param1CB.DataType = null;
            this.param1CB.DrawSemitransparentThumb = false;
            this.param1CB.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.param1CB.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.param1CB.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.param1CB.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.param1CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.param1CB.IncrementAmount = 0.01F;
            this.param1CB.InputName = "Param1";
            this.param1CB.LargeChange = 5F;
            this.param1CB.Location = new System.Drawing.Point(6, 163);
            this.param1CB.Maximum = 9999999F;
            this.param1CB.Minimum = -9999999F;
            this.param1CB.Name = "param1CB";
            this.param1CB.Precision = 0.01F;
            this.param1CB.ScaleDivisions = 1;
            this.param1CB.ScaleSubDivisions = 2;
            this.param1CB.ShowDivisionsText = false;
            this.param1CB.ShowSmallScale = false;
            this.param1CB.Size = new System.Drawing.Size(149, 25);
            this.param1CB.SmallChange = 1F;
            this.param1CB.TabIndex = 1;
            this.param1CB.Text = "barSlider1";
            this.param1CB.ThumbInnerColor = System.Drawing.Color.Empty;
            this.param1CB.ThumbPenColor = System.Drawing.Color.Empty;
            this.param1CB.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.param1CB.ThumbSize = new System.Drawing.Size(1, 1);
            this.param1CB.TickAdd = 0F;
            this.param1CB.TickColor = System.Drawing.Color.White;
            this.param1CB.TickDivide = 0F;
            this.param1CB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.param1CB.UseInterlapsedBar = true;
            this.param1CB.Value = -9999999F;
            // 
            // TransformTabPage
            // 
            this.TransformTabPage.Controls.Add(this.stPanel6);
            this.TransformTabPage.Controls.Add(this.stPanel2);
            this.TransformTabPage.Location = new System.Drawing.Point(4, 25);
            this.TransformTabPage.Name = "TransformTabPage";
            this.TransformTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TransformTabPage.Size = new System.Drawing.Size(161, 438);
            this.TransformTabPage.TabIndex = 0;
            this.TransformTabPage.Text = "SRT";
            this.TransformTabPage.UseVisualStyleBackColor = true;
            // 
            // stPanel6
            // 
            this.stPanel6.Controls.Add(this.transformParamTB);
            this.stPanel6.Controls.Add(this.translateYUD);
            this.stPanel6.Controls.Add(this.translateXUD);
            this.stPanel6.Controls.Add(this.scaleYUD);
            this.stPanel6.Controls.Add(this.scaleXUD);
            this.stPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel6.Location = new System.Drawing.Point(3, 3);
            this.stPanel6.Name = "stPanel6";
            this.stPanel6.Size = new System.Drawing.Size(155, 432);
            this.stPanel6.TabIndex = 17;
            // 
            // transformParamTB
            // 
            this.transformParamTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transformParamTB.Location = new System.Drawing.Point(3, 3);
            this.transformParamTB.Name = "transformParamTB";
            this.transformParamTB.Size = new System.Drawing.Size(149, 20);
            this.transformParamTB.TabIndex = 17;
            // 
            // translateYUD
            // 
            this.translateYUD.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.translateYUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.translateYUD.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.translateYUD.BarPenColorBottom = System.Drawing.Color.Empty;
            this.translateYUD.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.translateYUD.BarPenColorTop = System.Drawing.Color.Empty;
            this.translateYUD.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.translateYUD.DataType = null;
            this.translateYUD.DrawSemitransparentThumb = false;
            this.translateYUD.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.translateYUD.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.translateYUD.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.translateYUD.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.translateYUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.translateYUD.IncrementAmount = 0.01F;
            this.translateYUD.InputName = "Translate Y";
            this.translateYUD.LargeChange = 5F;
            this.translateYUD.Location = new System.Drawing.Point(3, 25);
            this.translateYUD.Maximum = 99999F;
            this.translateYUD.Minimum = -99999F;
            this.translateYUD.Name = "translateYUD";
            this.translateYUD.Precision = 0.01F;
            this.translateYUD.ScaleDivisions = 1;
            this.translateYUD.ScaleSubDivisions = 2;
            this.translateYUD.ShowDivisionsText = false;
            this.translateYUD.ShowSmallScale = false;
            this.translateYUD.Size = new System.Drawing.Size(149, 25);
            this.translateYUD.SmallChange = 1F;
            this.translateYUD.TabIndex = 14;
            this.translateYUD.Text = "barSlider6";
            this.translateYUD.ThumbInnerColor = System.Drawing.Color.Empty;
            this.translateYUD.ThumbPenColor = System.Drawing.Color.Empty;
            this.translateYUD.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.translateYUD.ThumbSize = new System.Drawing.Size(1, 1);
            this.translateYUD.TickAdd = 0F;
            this.translateYUD.TickColor = System.Drawing.Color.White;
            this.translateYUD.TickDivide = 0F;
            this.translateYUD.TickStyle = System.Windows.Forms.TickStyle.None;
            this.translateYUD.UseInterlapsedBar = true;
            this.translateYUD.Value = 30F;
            // 
            // translateXUD
            // 
            this.translateXUD.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.translateXUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.translateXUD.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.translateXUD.BarPenColorBottom = System.Drawing.Color.Empty;
            this.translateXUD.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.translateXUD.BarPenColorTop = System.Drawing.Color.Empty;
            this.translateXUD.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.translateXUD.DataType = null;
            this.translateXUD.DrawSemitransparentThumb = false;
            this.translateXUD.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.translateXUD.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.translateXUD.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.translateXUD.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.translateXUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.translateXUD.IncrementAmount = 0.01F;
            this.translateXUD.InputName = "Translate X";
            this.translateXUD.LargeChange = 5F;
            this.translateXUD.Location = new System.Drawing.Point(3, 51);
            this.translateXUD.Maximum = 99999F;
            this.translateXUD.Minimum = -99999F;
            this.translateXUD.Name = "translateXUD";
            this.translateXUD.Precision = 0.01F;
            this.translateXUD.ScaleDivisions = 1;
            this.translateXUD.ScaleSubDivisions = 2;
            this.translateXUD.ShowDivisionsText = false;
            this.translateXUD.ShowSmallScale = false;
            this.translateXUD.Size = new System.Drawing.Size(149, 25);
            this.translateXUD.SmallChange = 1F;
            this.translateXUD.TabIndex = 13;
            this.translateXUD.Text = "barSlider5";
            this.translateXUD.ThumbInnerColor = System.Drawing.Color.Empty;
            this.translateXUD.ThumbPenColor = System.Drawing.Color.Empty;
            this.translateXUD.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.translateXUD.ThumbSize = new System.Drawing.Size(1, 1);
            this.translateXUD.TickAdd = 0F;
            this.translateXUD.TickColor = System.Drawing.Color.White;
            this.translateXUD.TickDivide = 0F;
            this.translateXUD.TickStyle = System.Windows.Forms.TickStyle.None;
            this.translateXUD.UseInterlapsedBar = true;
            this.translateXUD.Value = 30F;
            // 
            // scaleYUD
            // 
            this.scaleYUD.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.scaleYUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.scaleYUD.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scaleYUD.BarPenColorBottom = System.Drawing.Color.Empty;
            this.scaleYUD.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.scaleYUD.BarPenColorTop = System.Drawing.Color.Empty;
            this.scaleYUD.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.scaleYUD.DataType = null;
            this.scaleYUD.DrawSemitransparentThumb = false;
            this.scaleYUD.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.scaleYUD.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.scaleYUD.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.scaleYUD.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.scaleYUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.scaleYUD.IncrementAmount = 0.01F;
            this.scaleYUD.InputName = "Scale Y";
            this.scaleYUD.LargeChange = 5F;
            this.scaleYUD.Location = new System.Drawing.Point(3, 103);
            this.scaleYUD.Maximum = 99999F;
            this.scaleYUD.Minimum = -99999F;
            this.scaleYUD.Name = "scaleYUD";
            this.scaleYUD.Precision = 0.01F;
            this.scaleYUD.ScaleDivisions = 1;
            this.scaleYUD.ScaleSubDivisions = 2;
            this.scaleYUD.ShowDivisionsText = false;
            this.scaleYUD.ShowSmallScale = false;
            this.scaleYUD.Size = new System.Drawing.Size(149, 25);
            this.scaleYUD.SmallChange = 1F;
            this.scaleYUD.TabIndex = 16;
            this.scaleYUD.Text = "barSlider7";
            this.scaleYUD.ThumbInnerColor = System.Drawing.Color.Empty;
            this.scaleYUD.ThumbPenColor = System.Drawing.Color.Empty;
            this.scaleYUD.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.scaleYUD.ThumbSize = new System.Drawing.Size(1, 1);
            this.scaleYUD.TickAdd = 0F;
            this.scaleYUD.TickColor = System.Drawing.Color.White;
            this.scaleYUD.TickDivide = 0F;
            this.scaleYUD.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scaleYUD.UseInterlapsedBar = true;
            this.scaleYUD.Value = 30F;
            this.scaleYUD.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barSlider7_Scroll);
            // 
            // scaleXUD
            // 
            this.scaleXUD.ActiveEditColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.scaleXUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.scaleXUD.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.scaleXUD.BarPenColorBottom = System.Drawing.Color.Empty;
            this.scaleXUD.BarPenColorMiddle = System.Drawing.Color.Empty;
            this.scaleXUD.BarPenColorTop = System.Drawing.Color.Empty;
            this.scaleXUD.BorderRoundRectSize = new System.Drawing.Size(32, 32);
            this.scaleXUD.DataType = null;
            this.scaleXUD.DrawSemitransparentThumb = false;
            this.scaleXUD.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(121)))), ((int)(((byte)(180)))));
            this.scaleXUD.ElapsedPenColorBottom = System.Drawing.Color.Empty;
            this.scaleXUD.ElapsedPenColorMiddle = System.Drawing.Color.Empty;
            this.scaleXUD.ElapsedPenColorTop = System.Drawing.Color.Empty;
            this.scaleXUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.scaleXUD.IncrementAmount = 0.01F;
            this.scaleXUD.InputName = "Scale X";
            this.scaleXUD.LargeChange = 5F;
            this.scaleXUD.Location = new System.Drawing.Point(3, 77);
            this.scaleXUD.Maximum = 99999F;
            this.scaleXUD.Minimum = -99999F;
            this.scaleXUD.Name = "scaleXUD";
            this.scaleXUD.Precision = 0.01F;
            this.scaleXUD.ScaleDivisions = 1;
            this.scaleXUD.ScaleSubDivisions = 2;
            this.scaleXUD.ShowDivisionsText = false;
            this.scaleXUD.ShowSmallScale = false;
            this.scaleXUD.Size = new System.Drawing.Size(149, 25);
            this.scaleXUD.SmallChange = 1F;
            this.scaleXUD.TabIndex = 15;
            this.scaleXUD.Text = "barSlider8";
            this.scaleXUD.ThumbInnerColor = System.Drawing.Color.Empty;
            this.scaleXUD.ThumbPenColor = System.Drawing.Color.Empty;
            this.scaleXUD.ThumbRoundRectSize = new System.Drawing.Size(1, 1);
            this.scaleXUD.ThumbSize = new System.Drawing.Size(1, 1);
            this.scaleXUD.TickAdd = 0F;
            this.scaleXUD.TickColor = System.Drawing.Color.White;
            this.scaleXUD.TickDivide = 0F;
            this.scaleXUD.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scaleXUD.UseInterlapsedBar = true;
            this.scaleXUD.Value = 30F;
            // 
            // stPanel2
            // 
            this.stPanel2.Location = new System.Drawing.Point(90, 25);
            this.stPanel2.Name = "stPanel2";
            this.stPanel2.Size = new System.Drawing.Size(8, 8);
            this.stPanel2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "参数";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stPanel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(567, 740);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Json编辑器";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stPanel7
            // 
            this.stPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel7.Location = new System.Drawing.Point(3, 3);
            this.stPanel7.Name = "stPanel7";
            this.stPanel7.Size = new System.Drawing.Size(561, 734);
            this.stPanel7.TabIndex = 0;
            // 
            // GFLXMaterialEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stTabControl1);
            this.Name = "GFLXMaterialEditor";
            this.Size = new System.Drawing.Size(575, 769);
            this.stTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.stPanel1.ResumeLayout(false);
            this.stFlowLayoutPanel1.ResumeLayout(false);
            this.stDropDownPanel1.ResumeLayout(false);
            this.stDropDownPanel1.PerformLayout();
            this.stDropDownPanel2.ResumeLayout(false);
            this.stDropDownPanel2.PerformLayout();
            this.stPanel3.ResumeLayout(false);
            this.stPanel5.ResumeLayout(false);
            this.stPanel4.ResumeLayout(false);
            this.stTabControl2.ResumeLayout(false);
            this.ParamsTabPage.ResumeLayout(false);
            this.ParamsTabPage.PerformLayout();
            this.TransformTabPage.ResumeLayout(false);
            this.stPanel6.ResumeLayout(false);
            this.stPanel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Toolbox.Library.Forms.STTabControl stTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Toolbox.Library.Forms.STPanel stPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private Toolbox.Library.Forms.STFlowLayoutPanel stFlowLayoutPanel1;
        private Toolbox.Library.Forms.STDropDownPanel stDropDownPanel1;
        private Toolbox.Library.Forms.STDropDownPanel stDropDownPanel2;
        private Toolbox.Library.Forms.ListViewCustom listViewCustom1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private BarSlider.BarSlider param1CB;
        private Toolbox.Library.Forms.UVViewport uvViewport1;
        private BarSlider.BarSlider scaleYUD;
        private BarSlider.BarSlider scaleXUD;
        private BarSlider.BarSlider translateYUD;
        private BarSlider.BarSlider translateXUD;
        private Toolbox.Library.Forms.STPanel stPanel3;
        private Toolbox.Library.Forms.STPanel stPanel5;
        private System.Windows.Forms.Splitter splitter1;
        private Toolbox.Library.Forms.STPanel stPanel4;
        private Toolbox.Library.Forms.STTabControl stTabControl2;
        private System.Windows.Forms.TabPage TransformTabPage;
        private System.Windows.Forms.TabPage ParamsTabPage;
        private Toolbox.Library.Forms.STTextBox stTextBox2;
        private Toolbox.Library.Forms.STTextBox stTextBox1;
        private Toolbox.Library.Forms.STPanel stPanel6;
        private Toolbox.Library.Forms.STPanel stPanel2;
        private System.Windows.Forms.TabPage tabPage3;
        private Toolbox.Library.Forms.STPanel stPanel7;
        private Toolbox.Library.Forms.STTextBox transformParamTB;
        private BarSlider.BarSlider param5CB;
        private BarSlider.BarSlider param6CB;
        private BarSlider.BarSlider param4CB;
        private BarSlider.BarSlider param2CB;
        private BarSlider.BarSlider param3CB;
        private Toolbox.Library.Forms.STLabel stLabel3;
        private Toolbox.Library.Forms.STLabel stLabel2;
        private Toolbox.Library.Forms.STLabel stLabel1;
        private Toolbox.Library.Forms.STComboBox wrapModeWCB;
        private Toolbox.Library.Forms.STComboBox wrapModeVCB;
        private Toolbox.Library.Forms.STComboBox wrapModeUCB;
    }
}
