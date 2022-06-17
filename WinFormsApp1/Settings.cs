using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Settings
    {
        //Хранит путь к корневой директории с файлами
        [DataMember(Name = "MainFolder")] public string mainFolder { get; set; }
        //Хранит путь к директории бэкапа
        [DataMember(Name = "BackupFolder")] public string backupFolder { get; set; }
        //Хранит расширения файлов, которые необходимы для копирования
        [DataMember(Name = "FileExtension")] public string fileExtension { get; set; }
        //Хранит кол-во дней за которое нужно осуществлять копирование 
        [DataMember(Name = "CountDays")] public string countDays { get; set; }
        //Копирование всех файлов из папки(если true, то пункт с выбором расширений будет игнорироваться)
        [DataMember(Name = "CopyAllFilesFromFolder")] public bool copyAllFilesFromFolder;
        //Уведомлять ли о начале и завершении копирования(true - да, false - нет)
        [DataMember(Name = "NotifyAboutCopy")] public bool notifyAboutCopy;
        //Предлагать завершить работу программы, если копирование не запланировано(true - да, false - нет)
        [DataMember(Name = "ProgramShutdown")] public bool programShutdown;
        //Разрешить прерывать процесс копирования(true - да, false - нет)
        [DataMember(Name = "PermissionToStopCopy")] public bool permissionToStopCopy;
        //В случае прерывания копирования предлагать копировать снова(true - да, false - нет)
        [DataMember(Name = "TryСopyingAgain")] public bool tryСopyingAgain;
        //true - Russian, false - English
        [DataMember(Name = "Language")] public bool language;
        //Запуск программы всесте с windows true - да, false - нет
        [DataMember(Name = "StartingWithWindows")] public bool startingWithWindows;
        //Показ подсказок true - да, false - нет
        [DataMember(Name = "DisplayingHints")] public bool displayingHints;

        public Settings() { }
        public Settings(string mainFolder, string backupFolder, string fileExtension, string countDays, bool copyAllFilesFromFolder, bool notifyAboutCopy, bool programShutdown, bool permissionToStopCopy, bool tryСopyingAgain) 
        {
            this.mainFolder = mainFolder;
            this.backupFolder = backupFolder;
            this.fileExtension = fileExtension;
            this.countDays = countDays;
            this.copyAllFilesFromFolder = copyAllFilesFromFolder;
            this.notifyAboutCopy = notifyAboutCopy;
            this.programShutdown = programShutdown;
            this.permissionToStopCopy = permissionToStopCopy;
            this.tryСopyingAgain = tryСopyingAgain;
        }
        public void ReturnSettings(string mainFolder, string backupFolder, TextBox fileExtension, TextBox countDays, CheckBox copyAllFilesFromFolder, CheckBox notifyAboutCopy, CheckBox programShutdown, CheckBox permissionToStopCopy, CheckBox tryСopyingAgain)
        {
            mainFolder = this.mainFolder;
            backupFolder = this.backupFolder;
            fileExtension.Text = this.fileExtension;
            countDays.Text = this.countDays;
            copyAllFilesFromFolder.Checked = this.copyAllFilesFromFolder;
            notifyAboutCopy.Checked = this.notifyAboutCopy;
            programShutdown.Checked = this.programShutdown;
            permissionToStopCopy.Checked = this.permissionToStopCopy;
            tryСopyingAgain.Checked = this.tryСopyingAgain;
        }
    }
}
