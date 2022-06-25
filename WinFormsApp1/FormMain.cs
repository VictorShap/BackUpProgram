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

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        AutoCopy settings = new AutoCopy();
        string SettingsFile = "Settings.xml";
        private void FormMain_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormScheduler f = new FormScheduler();
            Methods.RemoveLaunchingAlongWithWindows();
            f.Show();
        }

        private void toolStripMenuCopy_Click(object sender, EventArgs e)
        {
            FormAutoCopyingSettings f = new FormAutoCopyingSettings();
            f.Show();
        }



        private void ShowToolTips_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            Control control = sender as Control;
            Methods.ShowTips(control.Name, LabelTips);
        }


        private void ButtonAutoCopyingSettings_Click(object sender, EventArgs e)
        {
            FormAutoCopyingSettings formCopyingSettings = new FormAutoCopyingSettings();
            formCopyingSettings.Show();
        }


        private void ButtonAutoCopyingApply_Click(object sender, EventArgs e)
        {
            FormScheduler formScheduler = new FormScheduler();
            formScheduler.Show();
        }

    }
}

