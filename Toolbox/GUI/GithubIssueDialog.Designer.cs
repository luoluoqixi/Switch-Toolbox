﻿namespace Toolbox
{
    partial class GithubIssueDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stPanel1 = new Toolbox.Library.Forms.STPanel();
            this.stButton2 = new Toolbox.Library.Forms.STButton();
            this.stButton1 = new Toolbox.Library.Forms.STButton();
            this.stLabel3 = new Toolbox.Library.Forms.STLabel();
            this.stLabel2 = new Toolbox.Library.Forms.STLabel();
            this.typeCB = new Toolbox.Library.Forms.STComboBox();
            this.infoTB = new Toolbox.Library.Forms.STTextBox();
            this.stLabel1 = new Toolbox.Library.Forms.STLabel();
            this.titleTB = new Toolbox.Library.Forms.STTextBox();
            this.contentContainer.SuspendLayout();
            this.stPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentContainer
            // 
            this.contentContainer.Controls.Add(this.stPanel1);
            this.contentContainer.Controls.SetChildIndex(this.stPanel1, 0);
            // 
            // stPanel1
            // 
            this.stPanel1.Controls.Add(this.stButton2);
            this.stPanel1.Controls.Add(this.stButton1);
            this.stPanel1.Controls.Add(this.stLabel3);
            this.stPanel1.Controls.Add(this.stLabel2);
            this.stPanel1.Controls.Add(this.typeCB);
            this.stPanel1.Controls.Add(this.infoTB);
            this.stPanel1.Controls.Add(this.stLabel1);
            this.stPanel1.Controls.Add(this.titleTB);
            this.stPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stPanel1.Location = new System.Drawing.Point(0, 25);
            this.stPanel1.Name = "stPanel1";
            this.stPanel1.Size = new System.Drawing.Size(543, 368);
            this.stPanel1.TabIndex = 11;
            // 
            // stButton2
            // 
            this.stButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.stButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton2.Location = new System.Drawing.Point(368, 339);
            this.stButton2.Name = "stButton2";
            this.stButton2.Size = new System.Drawing.Size(75, 23);
            this.stButton2.TabIndex = 7;
            this.stButton2.Text = "Ok";
            this.stButton2.UseVisualStyleBackColor = false;
            // 
            // stButton1
            // 
            this.stButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton1.Location = new System.Drawing.Point(449, 339);
            this.stButton1.Name = "stButton1";
            this.stButton1.Size = new System.Drawing.Size(75, 23);
            this.stButton1.TabIndex = 6;
            this.stButton1.Text = "取消";
            this.stButton1.UseVisualStyleBackColor = false;
            // 
            // stLabel3
            // 
            this.stLabel3.AutoSize = true;
            this.stLabel3.Location = new System.Drawing.Point(12, 112);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(62, 13);
            this.stLabel3.TabIndex = 5;
            this.stLabel3.Text = "信息:";
            // 
            // stLabel2
            // 
            this.stLabel2.AutoSize = true;
            this.stLabel2.Location = new System.Drawing.Point(8, 3);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(34, 13);
            this.stLabel2.TabIndex = 4;
            this.stLabel2.Text = "类型:";
            // 
            // typeCB
            // 
            this.typeCB.BorderColor = System.Drawing.Color.Empty;
            this.typeCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.typeCB.ButtonColor = System.Drawing.Color.Empty;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(11, 19);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(159, 21);
            this.typeCB.TabIndex = 3;
            // 
            // infoTB
            // 
            this.infoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoTB.Location = new System.Drawing.Point(11, 128);
            this.infoTB.Multiline = true;
            this.infoTB.Name = "infoTB";
            this.infoTB.Size = new System.Drawing.Size(512, 205);
            this.infoTB.TabIndex = 2;
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = true;
            this.stLabel1.Location = new System.Drawing.Point(9, 55);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(30, 13);
            this.stLabel1.TabIndex = 1;
            this.stLabel1.Text = "标题:";
            // 
            // titleTB
            // 
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTB.Location = new System.Drawing.Point(12, 71);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(512, 29);
            this.titleTB.TabIndex = 0;
            this.titleTB.TextChanged += new System.EventHandler(this.titleTB_TextChanged);
            // 
            // GithubIssueDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 398);
            this.Name = "GithubIssueDialog";
            this.Text = "Github Issue 对话框";
            this.contentContainer.ResumeLayout(false);
            this.stPanel1.ResumeLayout(false);
            this.stPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Toolbox.Library.Forms.STPanel stPanel1;
        private Toolbox.Library.Forms.STTextBox titleTB;
        private Toolbox.Library.Forms.STButton stButton2;
        private Toolbox.Library.Forms.STButton stButton1;
        private Toolbox.Library.Forms.STLabel stLabel3;
        private Toolbox.Library.Forms.STLabel stLabel2;
        private Toolbox.Library.Forms.STComboBox typeCB;
        private Toolbox.Library.Forms.STTextBox infoTB;
        private Toolbox.Library.Forms.STLabel stLabel1;
    }
}