using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [DataContract]
    public class PlanningCopy
    {
        
        [DataMember(Order = 0)]
        public string sourceDirectoryPath { get; set; } //основная директория 
        
        [DataMember(Order = 1)]
        public string targetDirectoryPath { get; set; } //бэкап директория
        [DataMember(Order = 2)]
        public string CopyDay { get; set; } //день, в который запланировано копирование

        [DataMember(Order = 3)]
        public string fileExtensionsToCopy { get; set; } //типы файлов, которые нужно копировать
        
        [DataMember(Order = 4)]
        public string countDays { get; set; } //количесво дней, за которое нужно скорипровать файлы
        
        [DataMember(Order = 5)]
        public bool copyAllFilesFromFolder { get; set; } //копировать ли все типы файлов из маин папки
    }
}
