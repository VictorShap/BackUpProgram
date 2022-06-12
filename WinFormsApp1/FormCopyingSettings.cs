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
<<<<<<< HEAD
        static string SourceDirectoryPath;
        static string TargetDirectoryPath;
=======
        //файл в котором хранятся все настройки
        Settings settings = new Settings();
        string SettingsFile = "Settings.xml";
>>>>>>> 12123
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
            toolTip.SetToolTip(checkBox3PermissionToStopCopy, "Появится кнопка, которая позволит принудительно прервать процесс копирования");
            toolTip.SetToolTip(checkBox4StartCopyingAgain, "Если копирование было завершено с ошибкой, программа предложит его провоторить");
            DeserializeXML(settings);
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
<<<<<<< HEAD

        private void ButtonChooseDirectoryToCopy_Click(object sender, EventArgs e)
        {
            int index;
            string SourceDirectoryPath1 = SourceDirectoryPath;
            string SourceDirectoryPath2 = Methods.ChooseFolder(SourceDirectoryPath);
            if (SourceDirectoryPath2 != null)
            {
                if (SourceDirectoryPath2 == TargetDirectoryPath) MessageBox.Show("Директории не должны совпадать");
                else
                {
                    SourceDirectoryPath = SourceDirectoryPath2;
                    index = ListBoxDirectoriesResult.Items.IndexOf("Основная директория: " + SourceDirectoryPath1);
                    if (index! != -1) ListBoxDirectoriesResult.Items.Insert(index, "Основная директория: " + SourceDirectoryPath);
                    else ListBoxDirectoriesResult.Items.Add("Основная директория: " + SourceDirectoryPath);
                    ListBoxDirectoriesResult.Items.Remove("Основная директория: " + SourceDirectoryPath1);
                    if (!ListBoxDirectoriesResult.Visible) ListBoxDirectoriesResult.Visible = true;
                }
            }
        }

        private void ButtonChooseTargetDirectory_Click(object sender, EventArgs e)
        {
            int index;
            string TargetDirectoryPath1 = TargetDirectoryPath;
            string TargetDirectoryPath2 = Methods.ChooseFolder(TargetDirectoryPath);
            if (TargetDirectoryPath2 != null)
            {
                if (SourceDirectoryPath == TargetDirectoryPath2) MessageBox.Show("Директории не должны совпадать");
                else
                {
                    TargetDirectoryPath = TargetDirectoryPath2;
                    index = ListBoxDirectoriesResult.Items.IndexOf("Директория назначения: " + TargetDirectoryPath1);
                    if (index != -1) ListBoxDirectoriesResult.Items.Insert(index, "Директория назначения: " + TargetDirectoryPath);
                    else ListBoxDirectoriesResult.Items.Add("Директория назначения: " + TargetDirectoryPath);
                    ListBoxDirectoriesResult.Items.Remove("Директория назначения: " + TargetDirectoryPath1);
                    if (!ListBoxDirectoriesResult.Visible) ListBoxDirectoriesResult.Visible = true;
                }
            }
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {

        }

        private void LabelDirectoryToCopy_Click(object sender, EventArgs e)
        {

        }

        private void LabelTargetDirectory_Click(object sender, EventArgs e)
        {

        }
=======
        private void ButtonApply_Click(object sender, EventArgs e)
        {
            settings.fileExtension = TextBoxTypeExtension.Text;
            settings.countDays = TextBoxDaysToCopy.Text;
            settings.copyAllFilesFromFolder = CheckBoxCopyAllTheFiles.Checked;
            settings.notifyAboutCopy = checkBox1NotifyAboutCopying.Checked;
            settings.programShutdown = checkBox2ShutDownProgram.Checked;
            settings.permissionToStopCopy = checkBox3PermissionToStopCopy.Checked;
            settings.tryСopyingAgain = checkBox4StartCopyingAgain.Checked;
            SerializeXML(settings);
        }



        private void SerializeXML(Settings settings)
        {
            using (var fs = new FileStream(SettingsFile, FileMode.Create))
            {
                var ds = new DataContractSerializer(typeof(Settings));
                ds.WriteObject(fs, settings);
            }
        }
        private void DeserializeXML(Settings settings)
        {
            if (File.Exists(SettingsFile))
            {
                using (var fs = new FileStream(SettingsFile, FileMode.Open))
                {
                    var ds = new DataContractSerializer(typeof(Settings));
                    settings = (Settings)ds.ReadObject(fs);
                }
            }
        }
>>>>>>> 12123
    }
}
