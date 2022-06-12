using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        static string DirectoryToCopyPath;
        static string TargetDirectoryPath;
        public FormMain()
        {
            InitializeComponent();

        }
        ToolTip toolTip = new ToolTip();
        private void FormMain_Load(object sender, EventArgs e)
        {
            toolTip.Active = false;
            toolTip.SetToolTip(ButtonAddSchedule, "Настроить и добавить задачу копирования в определенный день.");
            toolTip.SetToolTip(ButtonChangeSchedule, "Выберите одиночным кликом мышки задачу, которую нужно редактировать и нажмите на кнопку.");
            toolTip.SetToolTip(ButtonRemoveSchedule, "Выберите одиночным кликом мышки задачу, которую нужно удалить и нажмите на кнопку.");
            toolTip.SetToolTip(ButtonCopyFiles, "Выберите одиночным кликом мышки задачу, которую нужно копировать незамедлительно.");

        }
        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void ButtonArbitraryCopying_Click(object sender, EventArgs e)
        {

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ButtonChooseTargetFolderClick(object sender, EventArgs e)
        {
            Methods.ChooseFolder(out TargetDirectoryPath);
        }

        private void ButtonChooseFolderToCopyClick(object sender, EventArgs e)
        {
            Methods.ChooseFolder(out DirectoryToCopyPath);
        }

        private void ButtonAddSchedule_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            LabelTips.Text = toolTip.GetToolTip((Button)sender);
        }

        private void ButtonAddSchedule_MouseLeave(object sender, EventArgs e)
        {
            LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        }
    }
}
