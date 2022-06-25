using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1.AllProgramSettings
{
    [DataContract]
    public class SchedulerSettings
    {
        [DataMember(Order = 0)]
        private string sourceDirectoryPath { get; set; } //основная директория 
        [DataMember(Order = 1)]
        private string targetDirectoryPath { get; set; } //бэкап директория
        [DataMember(Order = 2)]
        private string fileExtensionsToCopy { get; set; } //типы файлов, которые нужно копировать
        [DataMember(Order = 3)]
        private string countDays { get; set; } //количесво дней, за которое нужно скорипровать файлы
        [DataMember(Order = 4)]
        private bool copyAllFilesFromFolder { get; set; } //копировать ли все типы файлов из маин папки
        [DataMember(Order = 5)]
        public DateTime dateTime;

        public SchedulerSettings() { }
        public void SetPlanningSettings(string sourceDirectoryPath, string targetDirectoryPath, string fileExtensionsToCopy, string countDays, bool copyAllFilesFromFolder, DateTime dateTime)
        {
            this.sourceDirectoryPath = sourceDirectoryPath;
            this.targetDirectoryPath = targetDirectoryPath;
            this.fileExtensionsToCopy = fileExtensionsToCopy;
            this.countDays = countDays;
            this.copyAllFilesFromFolder = copyAllFilesFromFolder;
            this.dateTime = dateTime;
        }
        public void ShowPlanningSettings(ref string sourceDirectoryPath, ref string targetDirectoryPath, TextBox fileExtensionsToCopy, TextBox countDays, CheckBox copyAllFilesFromFolder, DateTimePicker dateTimePicker1)
        {
            sourceDirectoryPath = this.sourceDirectoryPath;
            targetDirectoryPath = this.targetDirectoryPath;
            fileExtensionsToCopy.Text = this.fileExtensionsToCopy;
            countDays.Text = this.countDays;
            copyAllFilesFromFolder.Checked = this.copyAllFilesFromFolder;
            dateTimePicker1.Value = dateTime;
        }
    }


}
