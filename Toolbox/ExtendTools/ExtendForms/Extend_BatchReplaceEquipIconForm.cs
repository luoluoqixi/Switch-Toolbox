using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Toolbox.ExtendTools.ExtendForms
{
    public partial class Extend_BatchReplaceEquipIconForm : Form
    {
        private MainForm mainForm;
        public Extend_BatchReplaceEquipIconForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderDialog = new FolderSelectDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            if (string.IsNullOrEmpty(folderDialog.SelectedPath))
            {
                return;
            }
            if (!Directory.Exists(folderDialog.SelectedPath))
            {
                return;
            }
            sbitemicoPath.Text = folderDialog.SelectedPath;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderDialog = new FolderSelectDialog();
            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            if (string.IsNullOrEmpty(folderDialog.SelectedPath))
            {
                return;
            }
            if (!Directory.Exists(folderDialog.SelectedPath))
            {
                return;
            }
            pngPath.Text = folderDialog.SelectedPath;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sbitemicoPath.Text))
            {
                MessageBox.Show("请选择.sbitemico路径");
                return;
            }
            if (string.IsNullOrEmpty(pngPath.Text))
            {
                MessageBox.Show("请选择.png路径");
                return;
            }
            if (string.IsNullOrEmpty(equipTextBox.Text))
            {
                MessageBox.Show("请输入装备名称");
                return;
            }
            string sbitemicoPathText = sbitemicoPath.Text;
            string pngPathText = pngPath.Text;
            string equipName = equipTextBox.Text;

            string[] replaceList = new string[] { "Head", "Lower", "Upper" };
            string[] dyeingList = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15" };

            List<string> successList = new List<string>();

            for (int i = 0; i < replaceList.Length; i++)
            {
                string r = replaceList[i];
                string equipNameMain = equipName + "_" + r;

                string sbitemicoEquipMainPath = Path.Combine(sbitemicoPathText, equipNameMain + ".sbitemico");
                string pngEquipMainPath = Path.Combine(pngPathText, equipNameMain + ".png");

                if (ReplaceIcon(sbitemicoEquipMainPath, pngEquipMainPath, null))
                     successList.Add(equipNameMain);

                for (int j = 0; j < dyeingList.Length; j++)
                {
                    string dveing = dyeingList[j];
                    string equipNameDve = equipNameMain + "." + dveing;

                    string sbitemicoEquipPath = Path.Combine(sbitemicoPathText, equipNameDve + ".sbitemico");
                    string pngEquipPath = Path.Combine(pngPathText, equipNameDve + ".png");

                    if (ReplaceIcon(sbitemicoEquipPath, pngEquipPath, pngEquipMainPath))
                        successList.Add(equipNameDve);
                }
            }
            MessageBox.Show($"成功替换了{successList.Count}个文件。\n{string.Join(", ", successList)}");
        }

        private bool ReplaceIcon(string sbitemicoPath, string iconPath, string defaultIconPath)
        {
            if (!File.Exists(sbitemicoPath))
            {
                return false;
            }
            string useIconPath = iconPath;
            if (!File.Exists(iconPath))
            {
                if (!File.Exists(defaultIconPath))
                    return false;
                useIconPath = defaultIconPath;
            }
            try
            {
                // 示例路径: Armor_M10_Head.bitemico\纹理\Armor_M10_Head
                string localPath = $"{Path.GetFileNameWithoutExtension(sbitemicoPath)}.bitemico\\纹理\\{Path.GetFileNameWithoutExtension(sbitemicoPath)}";
                mainForm.Extend_ReplaceFile_BFRES_Texture(sbitemicoPath, localPath, useIconPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("文件替换失败: " + sbitemicoPath + "\n错误: " + e.Message);
                return false;
            }
            return true;
        }
    }
}
