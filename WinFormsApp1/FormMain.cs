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
        Settings settings = new Settings();
        string SettingsFile = "Settings.xml";
        ToolTip toolTip = new ToolTip();
        private void FormMain_Load(object sender, EventArgs e)
        {
            toolTip.Active = false;
            toolTip.SetToolTip(ButtonAddSchedule, "Настроить и добавить задачу копирования в определенный день.");
            toolTip.SetToolTip(ButtonChangeSchedule, "Выберите одиночным кликом мышки задачу, которую нужно редактировать и нажмите на кнопку.");
            toolTip.SetToolTip(ButtonRemoveSchedule, "Выберите одиночным кликом мышки задачу, которую нужно удалить и нажмите на кнопку.");
            toolTip.SetToolTip(ButtonCopyFiles, "Выберите одиночным кликом мышки задачу, которую нужно копировать незамедлительно.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormScheduler f = new FormScheduler();
            f.Show();
        }

        private void toolStripMenuCopy_Click(object sender, EventArgs e)
        {
            FormCopyingSettings f = new FormCopyingSettings();
            f.Show();
        }



        private void ButtonAddSchedule_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            LabelTips.Text = toolTip.GetToolTip((Button)sender);

        }


        private void ButtonAutoCopyingSettings_Click(object sender, EventArgs e)
        {
            FormCopyingSettings formCopyingSettings = new FormCopyingSettings();
            formCopyingSettings.Show();
        }

        private void ListBoxScheduleCopying_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }

        private void LabelTips_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }

        private void GroupAutoCopying_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }

        private void GroupCopyingProcess_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }

        private void GroupCurrentSettings_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }
    }
}

