using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp1.AllProgramSettings
{
    [DataContract]
    public class AutoCopySettings
    {
        #region serializationProperties
        [DataMember(Order = 0)]
        private bool copyOnceEveryDay { get; set; } //копирование раз в день
        [DataMember(Order = 1)]
        private bool copyOnceInThreeDays { get; set; }//копирование раз в три дня
        [DataMember(Order = 2)]
        private bool copyOnceOnceAWeek { get; set; } //копирование раз в неделю
        [DataMember(Order = 3)]
        private bool copyNever { get; set; } //отключить автоматическое копирование
        [DataMember(Order = 4)]
        private string sourceDirectoryPath { get; set; } //основная директория 
        [DataMember(Order = 5)]
        private string targetDirectoryPath { get; set; } //бэкап директория
        [DataMember(Order = 6)]
        private string fileExtensionsToCopy { get; set; } //типы файлов, которые нужно копировать
        [DataMember(Order = 7)]
        private string countDays { get; set; } //количесво дней, за которое нужно скорипровать файлы
        [DataMember(Order = 8)]
        private bool copyAllFilesFromFolder { get; set; } //копировать ли все типы файлов из маин папки

        #endregion
        public AutoCopySettings() { }

        public void SetTimeToCopy(bool copyOnceEveryDay, bool copyOnceInThreeDays, bool copyOnceOnceAWeek, bool copyNever)
        {
            this.copyOnceEveryDay = copyOnceEveryDay;
            this.copyOnceInThreeDays = copyOnceInThreeDays;
            this.copyOnceOnceAWeek = copyOnceOnceAWeek;
            this.copyNever = copyNever;
        }
        public void ShowTimeToCopySettings(RadioButton copyOnceEveryDay, RadioButton copyOnceInThreeDays, RadioButton copyOnceOnceAWeek, RadioButton copyNever)
        {
            copyOnceEveryDay.Checked = this.copyOnceEveryDay;
            copyOnceInThreeDays.Checked = this.copyOnceInThreeDays;
            copyOnceOnceAWeek.Checked = this.copyOnceOnceAWeek;
            copyNever.Checked = this.copyNever;
        }

        public void SetMainSettingsValues(string sourceDirectoryPath, string targetDirectoryPath, string fileExtensionsToCopy, string countDays, bool copyAllFilesFromFolder)
        {
            this.sourceDirectoryPath = sourceDirectoryPath;
            this.targetDirectoryPath = targetDirectoryPath;
            this.fileExtensionsToCopy = fileExtensionsToCopy;
            this.countDays = countDays;
            this.copyAllFilesFromFolder = copyAllFilesFromFolder;
        }
        public void ShowMainSettingsOnForm(ref string sourceDirectoryPath, ref string targetDirectoryPath, TextBox fileExtensionsToCopy, TextBox countDays, CheckBox copyAllFilesFromFolder)
        {
            sourceDirectoryPath = this.sourceDirectoryPath;
            targetDirectoryPath = this.targetDirectoryPath;
            fileExtensionsToCopy.Text = this.fileExtensionsToCopy;
            countDays.Text = this.countDays;
            copyAllFilesFromFolder.Checked = this.copyAllFilesFromFolder;
        }

    }
}
