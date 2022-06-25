using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.AllProgramSettings;

namespace WinFormsApp1
{
    public partial class FormProgramSettings : Form
    {
        ProgramSettings programSettings = new ProgramSettings();
        FormMain formMain;
        public FormProgramSettings(FormMain owner)
        {
            InitializeComponent();
            formMain = owner;
        }
        private void FormProgramSettings_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileNames.programSettingsFile))
            {
                programSettings = (ProgramSettings)SaveSettings.DeserializeXML(FileNames.programSettingsFile, programSettings);
                programSettings.ShowProgramSettings(checkBox1StartWithWindows, checkBox2DisplayHints, checkBox3NotifyAboutCopying, checkBox4PermissionToStopCopy, checkBox5StartCopyingAgain, checkBox6RunProgramAsServise, RadioButtonRussian, RadioButtonEnglish);
            }
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            programSettings.SetProgramSettings(checkBox1StartWithWindows.Checked, checkBox2DisplayHints.Checked, checkBox3NotifyAboutCopying.Checked, checkBox4PermissionToStopCopy.Checked, checkBox5StartCopyingAgain.Checked, checkBox6RunProgramAsServise.Checked, RadioButtonRussian.Checked, RadioButtonEnglish.Checked);
            SaveSettings.SerializerXML(FileNames.programSettingsFile, programSettings);
            formMain.UpdateProgSettings = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            programSettings.SetProgramSettings(checkBox1StartWithWindows.Checked, checkBox2DisplayHints.Checked, checkBox3NotifyAboutCopying.Checked, checkBox4PermissionToStopCopy.Checked, checkBox5StartCopyingAgain.Checked, checkBox6RunProgramAsServise.Checked, RadioButtonRussian.Checked, RadioButtonEnglish.Checked);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            programSettings.SetProgramSettings(checkBox1StartWithWindows.Checked, checkBox2DisplayHints.Checked, checkBox3NotifyAboutCopying.Checked, checkBox4PermissionToStopCopy.Checked, checkBox5StartCopyingAgain.Checked, checkBox6RunProgramAsServise.Checked, RadioButtonRussian.Checked, RadioButtonEnglish.Checked);
            SaveSettings.SerializerXML(FileNames.programSettingsFile, programSettings);
            formMain.UpdateProgSettings = true;
            Close();
        }
    }
}
