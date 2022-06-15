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
        Settings settings = new Settings();
        string SettingsFile = "Settings.xml";
        static string SourceDirectoryPath;
        static string TargetDirectoryPath;
        string lableDefault = "Наведите курсор на любой из заголовков - и тут отобразится подробная информация.";
        public FormCopyingSettings()
        {
            InitializeComponent();
        }
        ToolTip toolTip = new ToolTip();
        private void FormCopyingSettings_Load(object sender, EventArgs e)
        {
            toolTip.Active = false;
            toolTip.SetToolTip(LabelDirectoryToCopy, "Нажмите на кнопку справа, чтобы выбрать директорию с файлами для копирования.");
            toolTip.SetToolTip(LabelTargetDirectory, "Нажмите на кнопку справа, чтобы выбрать директорию, в которую нужно скопировать файлы, выбранные выше.");
            toolTip.SetToolTip(ListBoxDirectoriesResult, "Здесь отображаются выбранные директории.");
            toolTip.SetToolTip(GroupAutoCopying, "Здесь вы можете задать настройки для регулярного копирования.");
            toolTip.SetToolTip(LabelTypeExtension, "Укажите, с каким расширением файлы нужно копировать. Разширения указывайте, разделяя запятой.");
            toolTip.SetToolTip(LabelDaysToCopy, "Укажите, за сколько последних дней осуществлять копирование. Дни указывайте числом.");
            toolTip.SetToolTip(CheckBoxCopyAllTheFiles, "Будут скопированы все файлы из выбранной директории.");
            toolTip.SetToolTip(GroupAdditionalSettings, "Здесь вы можете добавить дополнительные настройки.");
            toolTip.SetToolTip(LabelTips, lableDefault);
            toolTip.SetToolTip(menuStrip1, lableDefault);
            toolTip.SetToolTip(checkBox1NotifyAboutCopying, "Программа оповестит вас о начале и завершении копирования");
            toolTip.SetToolTip(checkBox2ShutDownProgram, "Вам будет предложено завершить работу программы, если нету запланированного копированя.");
            toolTip.SetToolTip(checkBox3PermissionToStopCopy, "На в начальном окне программы появится кнопка, позволяющая прервать процесс копированя.");
            toolTip.SetToolTip(checkBox4StartCopyingAgain, "В случае прерывания процесса копирования будет предложено повторить его попытку.");
            toolTip.SetToolTip(ButtonApply, "Применить все выбранные настройки.");
            toolTip.SetToolTip(ButtonCancel, "Отменить все выбранные настройки и вернуться на начальное окно программы.");
            toolTip.SetToolTip(ButtonOk, "Применить все выбранные настройки и вернуться на начальное окно программы.");
            toolTip.SetToolTip(ButtonChooseDirectoryToCopy, "Выберите директорию с файлами для копирования.");
            toolTip.SetToolTip(ButtonChooseTargetDirectory, "Выберите директорию, в которую будет осуществляться копирование.");
            toolTip.SetToolTip(TextBoxTypeExtension, "Укажите, с каким расширением файлы нужно копировать. Разширения указывайте, разделяя запятой.");
            toolTip.SetToolTip(TextBoxDaysToCopy, "Укажите, за сколько последних дней осуществлять копирование. Дни указывайте числом.");
        }

        void ShowToolTips_MouseHover(object sender, EventArgs e)
        {
            if (sender is Control) LabelTips.Text = toolTip.GetToolTip((Control)sender);
        }


        void ButtonChooseDirectoryToCopy_Click(object sender, EventArgs e)
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

        void ButtonChooseTargetDirectory_Click(object sender, EventArgs e)
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
        void ButtonApply_Click(object sender, EventArgs e)
        {

        }
        void SerializeXML(Settings settings)
        {
            using (var fs = new FileStream(SettingsFile, FileMode.Create))
            {
                var ds = new DataContractSerializer(typeof(Settings));
                ds.WriteObject(fs, settings);
            }
        }
        void DeserializeXML(Settings settings)
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

    }
}

