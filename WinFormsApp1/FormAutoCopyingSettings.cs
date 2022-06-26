using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.AllProgramSettings;

namespace WinFormsApp1
{

    public partial class FormAutoCopyingSettings : Form
    {
        AutoCopySettings autoCopySettings = new AutoCopySettings();
        static string sourceDirectoryPath;
        static string targetDirectoryPath;
        FormMain formMain;

        public FormAutoCopyingSettings(FormMain owner)
        {
            InitializeComponent();
            formMain = owner;
        }

        private void FormCopyingSettings_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileNames.autoCopyFile))
            {
                autoCopySettings = (AutoCopySettings)SaveSettings.DeserializeXML(FileNames.autoCopyFile, autoCopySettings);
                autoCopySettings.ShowMainSettingsOnForm(ref sourceDirectoryPath, ref targetDirectoryPath, TextBoxTypeExtension, TextBoxDaysToCopy, CheckBoxCopyAllTheFiles);
                Methods.ShowFolderOnListBox(sourceDirectoryPath, ListBoxDirectoriesResult, Other.mainDirectoryRu);
                Methods.ShowFolderOnListBox(targetDirectoryPath, ListBoxDirectoriesResult, Other.targetDirectoryRu);
            }
        }
        private void ShowToolTips_MouseHover(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Methods.ShowTips(control.Name, LabelTips);
        }

        private void ButtonChooseDirectoryToCopy_Click(object sender, EventArgs e)
        {
            Methods.AddFolder(Other.mainDirectoryRu, ref sourceDirectoryPath, in targetDirectoryPath, ListBoxDirectoriesResult);
        }
        private void ButtonChooseTargetDirectory_Click(object sender, EventArgs e)
        {
            Methods.AddFolder(Other.targetDirectoryRu, ref targetDirectoryPath, in sourceDirectoryPath, ListBoxDirectoriesResult);
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            autoCopySettings.SetMainSettingsValues(sourceDirectoryPath, targetDirectoryPath, TextBoxTypeExtension.Text, TextBoxDaysToCopy.Text, CheckBoxCopyAllTheFiles.Checked);
            SaveSettings.SerializerXML(FileNames.autoCopyFile, autoCopySettings);
            formMain.UpdateAutoCopySettings = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            autoCopySettings = (AutoCopySettings)SaveSettings.DeserializeXML(FileNames.autoCopyFile, autoCopySettings);
            autoCopySettings.ShowMainSettingsOnForm(ref sourceDirectoryPath, ref targetDirectoryPath, TextBoxTypeExtension, TextBoxDaysToCopy, CheckBoxCopyAllTheFiles);
            Methods.ShowFolderOnListBox(sourceDirectoryPath, ListBoxDirectoriesResult, Other.mainDirectoryRu);
            Methods.ShowFolderOnListBox(targetDirectoryPath, ListBoxDirectoriesResult, Other.targetDirectoryRu);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            autoCopySettings.SetMainSettingsValues(sourceDirectoryPath, targetDirectoryPath, TextBoxTypeExtension.Text, TextBoxDaysToCopy.Text, CheckBoxCopyAllTheFiles.Checked);
            SaveSettings.SerializerXML(FileNames.autoCopyFile, autoCopySettings);
            formMain.UpdateAutoCopySettings = true;
            Close();
        }

        private void FormAutoCopyingSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (formMain.UpdateAutoCopySettings == false)
            //{
            //    DialogResult = MessageBox.Show(Other.saveСhangesRu, Other.attentionRu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (DialogResult == DialogResult.Yes)
            //    {
            //        autoCopySettings.SetMainSettingsValues(sourceDirectoryPath, targetDirectoryPath, TextBoxTypeExtension.Text, TextBoxDaysToCopy.Text, CheckBoxCopyAllTheFiles.Checked);
            //        SaveSettings.SerializerXML(FileNames.autoCopyFile, autoCopySettings);
            //    }
            //} пока хз
        }
    }
}

