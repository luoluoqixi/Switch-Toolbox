﻿namespace FirstPlugin.Turbo
{
    partial class MK8MapCameraEditor
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
            this.stPropertyGrid1 = new Toolbox.Library.Forms.STPropertyGrid();
            this.leBtnRadio = new System.Windows.Forms.RadioButton();
            this.beBtnRadio = new System.Windows.Forms.RadioButton();
            this.mapCameraViewer1 = new Turbo.MapCameraViewer();
            this.btnCollisionPreview = new Toolbox.Library.Forms.STButton();
            this.SuspendLayout();
            // 
            // stPropertyGrid1
            // 
            this.stPropertyGrid1.AutoScroll = true;
            this.stPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.stPropertyGrid1.Location = new System.Drawing.Point(503, 0);
            this.stPropertyGrid1.Name = "stPropertyGrid1";
            this.stPropertyGrid1.ShowHintDisplay = true;
            this.stPropertyGrid1.Size = new System.Drawing.Size(217, 437);
            this.stPropertyGrid1.TabIndex = 11;
            // 
            // leBtnRadio
            // 
            this.leBtnRadio.AutoSize = true;
            this.leBtnRadio.Location = new System.Drawing.Point(85, 3);
            this.leBtnRadio.Name = "leBtnRadio";
            this.leBtnRadio.Size = new System.Drawing.Size(83, 17);
            this.leBtnRadio.TabIndex = 13;
            this.leBtnRadio.TabStop = true;
            this.leBtnRadio.Text = "小字节序";
            this.leBtnRadio.UseVisualStyleBackColor = true;
            // 
            // beBtnRadio
            // 
            this.beBtnRadio.AutoSize = true;
            this.beBtnRadio.Location = new System.Drawing.Point(3, 3);
            this.beBtnRadio.Name = "beBtnRadio";
            this.beBtnRadio.Size = new System.Drawing.Size(76, 17);
            this.beBtnRadio.TabIndex = 14;
            this.beBtnRadio.TabStop = true;
            this.beBtnRadio.Text = "大字节序";
            this.beBtnRadio.UseVisualStyleBackColor = true;
            this.beBtnRadio.CheckedChanged += new System.EventHandler(this.beBtnRadio_CheckedChanged);
            // 
            // mapCameraViewer1
            // 
            this.mapCameraViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapCameraViewer1.Location = new System.Drawing.Point(3, 26);
            this.mapCameraViewer1.Name = "mapCameraViewer1";
            this.mapCameraViewer1.Size = new System.Drawing.Size(494, 408);
            this.mapCameraViewer1.TabIndex = 15;
            this.mapCameraViewer1.UseGrid = true;
            this.mapCameraViewer1.UseOrtho = true;
            this.mapCameraViewer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapCameraViewer1_MouseDown);
            // 
            // btnCollisionPreview
            // 
            this.btnCollisionPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollisionPreview.Location = new System.Drawing.Point(174, 0);
            this.btnCollisionPreview.Name = "btnCollisionPreview";
            this.btnCollisionPreview.Size = new System.Drawing.Size(149, 23);
            this.btnCollisionPreview.TabIndex = 16;
            this.btnCollisionPreview.Text = "打开KCL(网格预览)";
            this.btnCollisionPreview.UseVisualStyleBackColor = false;
            this.btnCollisionPreview.Click += new System.EventHandler(this.btnCollisionPreview_Click);
            // 
            // MK8MapCameraEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCollisionPreview);
            this.Controls.Add(this.mapCameraViewer1);
            this.Controls.Add(this.beBtnRadio);
            this.Controls.Add(this.leBtnRadio);
            this.Controls.Add(this.stPropertyGrid1);
            this.Name = "MK8MapCameraEditor";
            this.Size = new System.Drawing.Size(720, 437);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MK8MapCameraEditor_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toolbox.Library.Forms.STPropertyGrid stPropertyGrid1;
        private System.Windows.Forms.RadioButton beBtnRadio;
        private System.Windows.Forms.RadioButton leBtnRadio;
        private MapCameraViewer mapCameraViewer1;
        private Toolbox.Library.Forms.STButton btnCollisionPreview;
    }
}
