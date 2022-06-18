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
    [DataContract]
    public class AutoCopy
    {
        [DataMember(Order = 0)]
        public bool copyOnceEveryDay { get; set; } //копирование раз в день
        [DataMember(Order = 1)]
        public bool copyOnceInThreeDays { get; set; }//копирование раз в три дня
        [DataMember(Order = 2)]
        public bool copyOnceOnceAWeek { get; set; } //копирование раз в неделю
        [DataMember(Order = 3)]
        public bool copyNever { get; set; } //отключить автоматическое копирование
        public string sourceDirectoryPath { get; set; } //основная директория 
        [DataMember(Order = 5)]
        public string targetDirectoryPath { get; set; } //бэкап директория
        [DataMember(Order = 6)]
        public string fileExtensionsToCopy { get; set; } //типы файлов, которые нужно копировать
        [DataMember(Order = 7)]
        public string countDays { get; set; } //количесво дней, за которое нужно скорипровать файлы
        [DataMember(Order = 8)]
        public bool copyAllFilesFromFolder { get; set; } //копировать ли все типы файлов из маин папки
        [DataMember(Order = 9)]
        public bool notifyAboutStartCopyAndFinished { get; set; } //оповещать ли о начале и завершении копирования
        [DataMember(Order = 10)]
        public bool proposalToShutdownProgram { get; set; } //преллагать ли завершить работу программы, если по плану копирования нет
        [DataMember(Order = 11)]
        public bool permissionToStopCopy{ get; set; } //разрешить ли прерывать процесс копирования
        [DataMember(Order = 12)]
        public bool proposalToTryСopyingAgain{ get; set; } //предлагать ли повторить копирование, если оно было завершено с ошибкой
        [DataMember(Order = 13)]
        public bool RussianLanguage{ get; set; } //язык интерфейса русский
        [DataMember(Order = 14)]
        public bool EnglishLanguage{ get; set; } //язык интерфейса английский 
        [DataMember(Order = 15)]
        public bool startingWithWindows{ get; set; } //запускать программу вместе с windows
        [DataMember(Order = 16)]
        public bool displayingHints{ get; set; } //показывать ли подсказки 
        public AutoCopy() { }

    }
}
