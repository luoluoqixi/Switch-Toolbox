namespace Toolbox.ExtendTools.ExtendForms
{
    partial class Extend_BatchReplaceEquipIconForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extend_BatchReplaceEquipIconForm));
            this.button1 = new System.Windows.Forms.Button();
            this.sbitemicoPath = new System.Windows.Forms.TextBox();
            this.pngPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.equipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(824, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择.sbitemico目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sbitemicoPath
            // 
            this.sbitemicoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbitemicoPath.Location = new System.Drawing.Point(13, 19);
            this.sbitemicoPath.Name = "sbitemicoPath";
            this.sbitemicoPath.Size = new System.Drawing.Size(793, 42);
            this.sbitemicoPath.TabIndex = 1;
            // 
            // pngPath
            // 
            this.pngPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pngPath.Location = new System.Drawing.Point(13, 93);
            this.pngPath.Name = "pngPath";
            this.pngPath.Size = new System.Drawing.Size(793, 42);
            this.pngPath.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(824, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(332, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "选择.png目录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // equipTextBox
            // 
            this.equipTextBox.Location = new System.Drawing.Point(12, 218);
            this.equipTextBox.Name = "equipTextBox";
            this.equipTextBox.Size = new System.Drawing.Size(475, 42);
            this.equipTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "输入装备名称(如Armor_M10)：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(7, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1149, 261);
            this.label2.TabIndex = 6;
            this.label2.Text = "说明：（注意备份原文件）\r\n自动查找.sbitemico目录以下.sbitemico文件进行替换图片操作，如果不存在，则不修改。\r\n图片会自动查找.png目录以下" +
    ".png文件作为替换源，如果不存在，则默认使用 装备名称_XXX.png\r\n1.装备名称_Head.01 到 15的文件\r\n2.装备名称_Lower.01 到 " +
    "15的文件\r\n3.装备名称_Upper.01 到 15的文件\r\n";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(18, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1138, 132);
            this.button3.TabIndex = 7;
            this.button3.Text = "开始！！！";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Extend_BatchReplaceEquipIconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipTextBox);
            this.Controls.Add(this.pngPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sbitemicoPath);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extend_BatchReplaceEquipIconForm";
            this.Text = "批量替换装备图标";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sbitemicoPath;
        private System.Windows.Forms.TextBox pngPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox equipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}