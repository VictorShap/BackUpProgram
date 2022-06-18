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
        ToolTip toolTip = new ToolTip();
        private void FormMain_Load(object sender, EventArgs e)
        {
            toolTip.Active = false;
            toolTip.SetToolTip(ButtonAddSchedule, "Настроить и добавить запланированную задачу копирования");
            toolTip.SetToolTip(ButtonChangeSchedule, "Выберите одиночным кликом мышки задачу, которую нужно редактировать, и нажмите на кнопку.");
            toolTip.SetToolTip(ButtonRemoveSchedule, "Выберите одиночным кликом мышки задачу, которую нужно удалить, и нажмите на кнопку.");
            toolTip.SetToolTip(ButtonCopyFiles, "Выберите одиночным кликом мышки задачу, которую нужно копировать незамедлительно, и нажмите на кнопку.");
            toolTip.SetToolTip(GroupScheduleCopying, "Здесь вы можете выполнить и настроить запланированное копирование.");
            toolTip.SetToolTip(GroupAutoCopying, "Здесь вы можете выполнить и настроить регуляроное копирование.");
            toolTip.SetToolTip(GroupCurrentSettings, "Здесь вы можете увидеть текущие настройки программы.");
            toolTip.SetToolTip(ButtonCancelCopying, "Отменить текущий процесс копирования.");
            toolTip.SetToolTip(ButtonAutoCopyingSettings, "Настроить и добавить задачу копирования с определенной регулярностью.");
            toolTip.SetToolTip(ButtonAutoCopyingApply, "Принять текущие настройки для регулярного копирования.");
            toolTip.SetToolTip(GroupCopyingProcess, "Здесь вы можете управлять и наблюдать процесс копирования.");
            toolTip.SetToolTip(RadioButtonEveryDay, "Повторять задачу копирования каждый день.");
            toolTip.SetToolTip(RadioButtonOnceAWeek, "Повторять задачу копирования раз в неделю.");
            toolTip.SetToolTip(RadioButtonOnceInThreeDays, "Повторять задачу копирования каждые 3 дня.");
            toolTip.SetToolTip(RadioButtonNever, "Никогда не повторять задачу копирования.");
            toolTip.SetToolTip(ListBoxScheduleCopying, "Здесь отображаются ранее запланированные задачи копирования.");
            toolTip.SetToolTip(ListBoxCurrentSettings, "Здесь вы можете увидеть текущие настройки программы.");
            toolTip.SetToolTip(LabelTips, "Наведите курсор на любой объект в программе - и тут отобразится подробная информация.");
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



        private void ShowToolTips_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            if (sender is Control) LabelTips.Text = toolTip.GetToolTip((Control)sender);
        }


        private void ButtonAutoCopyingSettings_Click(object sender, EventArgs e)
        {
            FormCopyingSettings formCopyingSettings = new FormCopyingSettings();
            formCopyingSettings.Show();
        }



        private void PanelForButtonsScheduleCopying_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой объект в программе - и тут отобразится подробная информация.";
        }

        private void ButtonAutoCopyingApply_Click(object sender, EventArgs e)
        {
            FormScheduler formScheduler = new FormScheduler();
            formScheduler.Show();
        }

        private void GroupCopyingProcess_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButtonNever_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

