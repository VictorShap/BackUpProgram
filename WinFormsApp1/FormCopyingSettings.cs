using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class FormCopyingSettings : Form
    {
        string lableDefault = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
        public FormCopyingSettings()
        {
            InitializeComponent();
        }
        ToolTip toolTip = new ToolTip();
        private void FormCopyingSettings_Load(object sender, EventArgs e)
        {
            toolTip.Active = false;
            toolTip.SetToolTip(LabelDirectoryToCopy, "Директория в которой находятся нужные файлы для копирования");
            toolTip.SetToolTip(LabelTargetDirectory, "Директория в которую нужно копировать файлы");
            toolTip.SetToolTip(LabelTypeExtension, "Для разделителя использовать /\nНапримпер: .txt/.mp3");
            toolTip.SetToolTip(LabelDaysToCopy, "Указав, допустим, цифру 3, будут скопированы файлы созданные за три последних дня");
            toolTip.SetToolTip(CheckBoxCopyAllTheFiles, "Файлы всех типов, находящиеся в выбранной директории, будут скопированы.");
            toolTip.SetToolTip(checkBox1NotifyAboutCopying, "Всплывающие окно предупредит вас об начале и завершении копирования");
            toolTip.SetToolTip(checkBox2ShutDownProgram, "Если копирование сегодня не запланировано, то и программе нет смысла работать");
            toolTip.SetToolTip(checkBox3AbortCopying, "Появится кнопка, которая позволит принудительно прервать процесс копирования");
            toolTip.SetToolTip(checkBox4StartCopyingAgain, "Если копирование было завершено с ошибкой, программа предложит его провоторить");
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GroupAutoCopying_Enter(object sender, EventArgs e)
        {

        }

        private void LabelDirectoryToCopy_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = toolTip.GetToolTip((Label)sender);
        }

        private void CheckBoxCopyAllTheFiles_MouseHover(object sender, EventArgs e)
        {
            LabelTips.Text = toolTip.GetToolTip((CheckBox)sender);
        }

        private void checkBox1NotifyAboutCopying_MouseLeave(object sender, EventArgs e)
        {
            LabelTips.Text = lableDefault;
        }

        private void LabelDirectoryToCopy_MouseLeave(object sender, EventArgs e)
        {
            LabelTips.Text = lableDefault;
        }
    }
}
