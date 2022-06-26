using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.AllProgramSettings;

namespace WinFormsApp1
{
    public partial class FormSchedulerSettings : Form
    {
        static string sourceDirectoryPath;
        static string targetDirectoryPath;
        SchedulerSettings schedulerSettings = new SchedulerSettings();
        FormMain formMain;
        public FormSchedulerSettings(FormMain owner)
        {
            InitializeComponent();
            formMain = owner;
        }

        private void FormScheduler_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileNames.schedulerSettingsFile))
            {
                schedulerSettings = (SchedulerSettings)SaveSettings.DeserializeXML(FileNames.schedulerSettingsFile, schedulerSettings);
                schedulerSettings.ShowPlanningSettings(ref sourceDirectoryPath, ref targetDirectoryPath, TextBoxTypeExtension, TextBoxDaysToCopy, CheckBoxCopyAllTheFiles, dateTimePicker);
                Methods.ShowFolderOnListBox(sourceDirectoryPath, ListBoxDirectoriesResult, Other.mainDirectoryRu);
                Methods.ShowFolderOnListBox(targetDirectoryPath, ListBoxDirectoriesResult, Other.targetDirectoryRu);
            }
        }

        private void ShowToolTips_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            Control control = sender as Control;
            Methods.ShowTips(control.Name, LabelTips);
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            schedulerSettings.SetPlanningSettings(sourceDirectoryPath, targetDirectoryPath, TextBoxTypeExtension.Text, TextBoxDaysToCopy.Text, CheckBoxCopyAllTheFiles.Checked, dateTimePicker.Value);
            SaveSettings.SerializerXML(FileNames.schedulerSettingsFile, schedulerSettings);
            formMain.UpdateSchedulerSettings = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            schedulerSettings = (SchedulerSettings)SaveSettings.DeserializeXML(FileNames.schedulerSettingsFile, schedulerSettings);
            schedulerSettings.ShowPlanningSettings(ref sourceDirectoryPath, ref targetDirectoryPath, TextBoxTypeExtension, TextBoxDaysToCopy, CheckBoxCopyAllTheFiles, dateTimePicker);
            Methods.ShowFolderOnListBox(sourceDirectoryPath, ListBoxDirectoriesResult, Other.mainDirectoryRu);
            Methods.ShowFolderOnListBox(targetDirectoryPath, ListBoxDirectoriesResult, Other.targetDirectoryRu);
        }
        private void ButtonChooseDirectoryToCopy_Click(object sender, EventArgs e)
        {
            Methods.AddFolder(Other.mainDirectoryRu, ref sourceDirectoryPath, in targetDirectoryPath, ListBoxDirectoriesResult);
        }
        private void ButtonChooseTargetDirectory_Click(object sender, EventArgs e)
        {
            Methods.AddFolder(Other.targetDirectoryRu, ref targetDirectoryPath, in sourceDirectoryPath, ListBoxDirectoriesResult);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            if (dateTimePicker.Value <= DateTime.Now) dateTimePicker.Value = DateTime.Today;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            schedulerSettings.SetPlanningSettings(sourceDirectoryPath, targetDirectoryPath, TextBoxTypeExtension.Text, TextBoxDaysToCopy.Text, CheckBoxCopyAllTheFiles.Checked, dateTimePicker.Value);
            SaveSettings.SerializerXML(FileNames.schedulerSettingsFile, schedulerSettings);
            formMain.UpdateSchedulerSettings = true;
            Close();
        }
    }
}
