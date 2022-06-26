using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using WinFormsApp1.AllProgramSettings;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    { 
        AutoCopySettings autoCopySettings = new AutoCopySettings();
        ProgramSettings programSettings = new ProgramSettings();
        SchedulerSettings schedulerSettings = new SchedulerSettings();
        //Три свойства ниже используюся для автообновления(на сновной форме) полей классов настроек, изменённых на дочерних формах
        private bool updateAutoCopySettings;
        public bool UpdateAutoCopySettings
        {
            get
            {
                return updateAutoCopySettings;
            }

            set
            {
                if (value == true)
                    updateAutoCopySettings = true;
                autoCopySettings = (AutoCopySettings)SaveSettings.DeserializeXML(FileNames.autoCopyFile, autoCopySettings);
            }
        }
        public bool UpdateProgSettings
        {
            set
            {
                if (value == true)
                    programSettings = (ProgramSettings)SaveSettings.DeserializeXML(FileNames.programSettingsFile, programSettings);
            }
        }
        public bool UpdateSchedulerSettings
        {
            set
            {
                if (value == true)
                    schedulerSettings = (SchedulerSettings)SaveSettings.DeserializeXML(FileNames.schedulerSettingsFile, schedulerSettings);
            }
        }
        public FormMain()
        {
            InitializeComponent();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileNames.autoCopyFile))
            {
                autoCopySettings = (AutoCopySettings)SaveSettings.DeserializeXML(FileNames.autoCopyFile, autoCopySettings);
                autoCopySettings.ShowTimeToCopySettings(RadioButtonEveryDay, RadioButtonOnceInThreeDays, RadioButtonOnceAWeek, RadioButtonNever);
            }
            if (File.Exists(FileNames.programSettingsFile))
            {
                programSettings = (ProgramSettings)SaveSettings.DeserializeXML(FileNames.programSettingsFile, programSettings);
            }
            if (File.Exists(FileNames.schedulerSettingsFile))
            {
                schedulerSettings = (SchedulerSettings)SaveSettings.DeserializeXML(FileNames.schedulerSettingsFile, schedulerSettings);
            }
        }
        private void ButtonAddScheduleButton1_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormSchedulerSettings>().Any())
            {
                new FormSchedulerSettings(this).Show();
            }
            Methods.RemoveLaunchingAlongWithWindows();


        }
        private void ShowToolTips_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            Control control = sender as Control;
            Methods.ShowTips(control.Name, LabelTips);
        }


        private void ButtonAutoCopyingSettings_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormAutoCopyingSettings>().Any())
            {
                new FormAutoCopyingSettings(this).Show();
            }
        }
        private void ButtonAutoCopyingApply_Click(object sender, EventArgs e)
        {
            autoCopySettings.SetTimeToCopy(RadioButtonEveryDay.Checked, RadioButtonOnceInThreeDays.Checked, RadioButtonOnceAWeek.Checked, RadioButtonNever.Checked);
            SaveSettings.SerializerXML(FileNames.autoCopyFile, autoCopySettings);
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms["FormProgramSettings"] == null)
            if (!Application.OpenForms.OfType<FormProgramSettings>().Any())
            {
                new FormProgramSettings(this).Show();
            }
        }

        private void ButtonCopyFiles_Click(object sender, EventArgs e)
        {

        }
    }
}

