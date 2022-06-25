using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class FormCopyingSettings : Form
    {
        AutoCopy settings = new AutoCopy();
        string SettingsFile = "Settings.xml";
        static string SourceDirectoryPath;
        static string TargetDirectoryPath;
        public FormCopyingSettings()
        {
            InitializeComponent();
        }

        private void FormCopyingSettings_Load(object sender, EventArgs e)
        {

        }

        private void ShowToolTips_MouseHover(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Methods.ShowTips(control.Name, LabelTips);
        }


        private void ButtonChooseDirectoryToCopy_Click(object sender, EventArgs e)
        {
            Methods.AddFolder("Основная директория: ", ref SourceDirectoryPath, in TargetDirectoryPath, ListBoxDirectoriesResult);
        }
        private void ButtonChooseTargetDirectory_Click(object sender, EventArgs e)
        {
            Methods.AddFolder("Директория назначения: ", ref TargetDirectoryPath, in SourceDirectoryPath, ListBoxDirectoriesResult);
        }

        void ButtonApply_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxTypeExtension_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

