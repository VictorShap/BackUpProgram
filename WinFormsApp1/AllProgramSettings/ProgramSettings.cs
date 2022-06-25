using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.AllProgramSettings
{
    [DataContract]
    public class ProgramSettings
    {
        #region serializationProperties
        [DataMember(Order = 0)]
        public bool startWithWindows { get; set; } //запускать программу вместе с windows
        [DataMember(Order = 1)]
        public bool displayHints { get; set; } //показывать ли подсказки 
        [DataMember(Order = 2)]
        public bool notifyStartFinishCopy { get; set; } //оповещать ли о начале и завершении копирования
        [DataMember(Order = 3)]
        public bool permissionToStopCopy { get; set; } //разрешить ли прерывать процесс копирования
        [DataMember(Order = 4)]
        public bool tryСopyingAgain { get; set; } //предлагать ли повторить копирование, если оно было завершено с ошибкой
        [DataMember(Order = 5)]
        public bool workAsService { get; set; } //разрешение работать программе как служба
        [DataMember(Order = 6)]
        public bool russianLanguage { get; set; } //язык интерфейса русский
        [DataMember(Order = 7)]
        public bool englishLanguage { get; set; } //язык интерфейса английский 
        #endregion


        public ProgramSettings() { }
        public void SetProgramSettings(bool startWithWindows, bool displayHints, bool notifyStartFinishCopy, bool permissionToStopCopy, bool tryСopyingAgain, bool workAsService, bool russianLanguage, bool englishLanguage)
        {
            this.startWithWindows = startWithWindows;
            this.displayHints = displayHints;
            this.notifyStartFinishCopy = notifyStartFinishCopy;
            this.permissionToStopCopy = permissionToStopCopy;
            this.tryСopyingAgain = tryСopyingAgain;
            this.workAsService = workAsService;
            this.russianLanguage = russianLanguage;
            this.englishLanguage = englishLanguage;
        }
        public void ShowProgramSettings(CheckBox startWithWindows, CheckBox displayHints, CheckBox notifyStartFinishCopy, CheckBox permissionToStopCopy, CheckBox tryСopyingAgain, CheckBox workAsService, RadioButton russianLanguage, RadioButton englishLanguage)
        {
            startWithWindows.Checked = this.startWithWindows;
            displayHints.Checked = this.displayHints;
            notifyStartFinishCopy.Checked = this.notifyStartFinishCopy;
            permissionToStopCopy.Checked = this.permissionToStopCopy;
            tryСopyingAgain.Checked = this.tryСopyingAgain;
            workAsService.Checked = this.workAsService;
            russianLanguage.Checked = this.russianLanguage;
            englishLanguage.Checked = this.englishLanguage;
        }

    }
}
