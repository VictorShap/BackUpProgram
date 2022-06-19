using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class ToolTips
    {
        static string RussianLabelDefault = "Наведите курсор на любой объект в программе - и тут отобразится подробная информация.";
        static string EnglishLabelDefault = "Hover the cursor over any object in the program and detailed information will be displayed here.";
        public static Dictionary<string, string> RussianToolTips = new Dictionary<string, string>()
        {
            {"ButtonAddSchedule", "Настроить и добавить запланированную задачу копирования"},
            {"ButtonChangeSchedule", "Выберите одиночным кликом мышки задачу, которую нужно редактировать, и нажмите на кнопку."},
            {"ButtonRemoveSchedule", "Выберите одиночным кликом мышки задачу, которую нужно удалить, и нажмите на кнопку."},
            {"ButtonCopyFiles", "Выберите одиночным кликом мышки задачу, которую нужно копировать незамедлительно, и нажмите на кнопку."},
            {"GroupScheduleCopying", "Здесь вы можете выполнить и настроить запланированное копирование."},
            {"GroupAutoCopying", "Здесь вы можете выполнить и настроить регуляроное копирование."},
            {"GroupCurrentSettings", "Здесь вы можете увидеть текущие настройки программы."},
            {"ButtonCancelCopying", "Отменить текущий процесс копирования."},
            {"ButtonAutoCopyingSettings", "Настроить и добавить задачу копирования с определенной регулярностью."},
            {"ButtonAutoCopyingApply", "Принять текущие настройки для регулярного копирования."},
            {"GroupCopyingProcess", "Здесь вы можете управлять и наблюдать процесс копирования."},
            {"RadioButtonEveryDay", "Повторять задачу копирования каждый день."},
            {"RadioButtonOnceAWeek", "Повторять задачу копирования раз в неделю."},
            {"RadioButtonOnceInThreeDays", "Повторять задачу копирования каждые 3 дня."},
            {"RadioButtonNever", "Никогда не повторять задачу копирования."},
            {"ListBoxScheduleCopying", "Здесь отображаются ранее запланированные задачи копирования."},
            {"ListBoxCurrentSettings", "Здесь вы можете увидеть текущие настройки программы."},
            {"LabelDirectoryToCopy", "Нажмите на кнопку справа, чтобы выбрать директорию с файлами для копирования."},
            {"LabelTargetDirectory", "Нажмите на кнопку справа, чтобы выбрать директорию, в которую нужно скопировать файлы, выбранные выше."},
            {"ListBoxDirectoriesResult", "Здесь отображаются выбранные директории."},
            {"LabelTypeExtension", "Укажите, с каким расширением файлы нужно копировать. Раcширения указывайте, разделяя запятой."},
            {"LabelDaysToCopy", "Укажите, за сколько последних дней осуществлять копирование. Дни указывайте числом."},
            {"CheckBoxCopyAllTheFiles", "Будут скопированы все файлы из выбранной директории."},
            {"GroupAdditionalSettings", "Здесь вы можете добавить дополнительные настройки."},
            {"LabelTips", RussianLabelDefault},
            {"menuStrip1", RussianLabelDefault},
            {"checkBox1NotifyAboutCopying", "Программа оповестит вас о начале и завершении копирования."},
            {"checkBox3PermissionToStopCopy", "На в начальном окне программы появится кнопка, позволяющая прервать процесс копированя."},
            {"checkBox4StartCopyingAgain", "В случае прерывания процесса копирования будет предложено повторить его попытку."},
            {"ButtonApply", "Применить все выбранные настройки."},
            {"ButtonCancel", "Отменить все выбранные настройки и вернуться на начальное окно программы."},
            {"ButtonOk", "Применить все выбранные настройки и вернуться на начальное окно программы."},
            {"ButtonChooseDirectoryToCopy", "Выберите директорию с файлами для копирования."},
            {"ButtonChooseTargetDirectory", "Выберите директорию, в которую будет осуществляться копирование."},
            {"TextBoxTypeExtension", "Укажите, с каким расширением файлы нужно копировать. Раcширения указывайте, разделяя запятой."},
            {"TextBoxDaysToCopy", "Укажите, за сколько последних дней осуществлять копирование. Дни указывайте числом."},
            {"Panel", RussianLabelDefault},
            {"PanelSelectDate", "Выберите дату, когда нужно будет выполнить задачу копирования."}
        };
        public static Dictionary<string, string> EnglishToolTips = new Dictionary<string, string>()
        {
            {"ButtonAddSchedule", "Configure and add a scheduled copy task"},
            {"ButtonChangeSchedule", "Select the task you want to edit with a single mouse click and click the button."},
            {"ButtonRemoveSchedule", "Select the task you want to delete with a single mouse click and click the button."},
            {"ButtonCopyFiles", "Select with a single mouse click the task that you want to copy immediately, and click on the button."},
            {"GroupScheduleCopying", "Here you can execute and set up scheduled copy tasks."},
            {"GroupAutoCopying", "Here you can perform and set up regular copy tasks."},
            {"GroupCurrentSettings", "Here you can see the current program settings."},
            {"ButtonCancelCopying", "Cancel the current copy process."},
            {"ButtonAutoCopyingSettings", "Set up and add a copy task with a certain regularity."},
            {"ButtonAutoCopyingApply", "Accept the current settings for regular copying."},
            {"GroupCopyingProcess", "Here you can manage and observe the copying process."},
            {"RadioButtonEveryDay", "Repeat the copy task every day."},
            {"RadioButtonOnceAWeek", "Repeat the copy task once a week."},
            {"RadioButtonOnceInThreeDays", "Repeat copy task every 3 days."},
            {"RadioButtonNever", "Never repeat the copy task."},
            {"ListBoxScheduleCopying", "Previously scheduled copy tasks are displayed here."},
            {"ListBoxCurrentSettings", "Here you can see the current program settings."},
            {"LabelDirectoryToCopy", "Click on the button on the right to select a directory with files to copy."},
            {"LabelTargetDirectory", "Click the button on the right to select the directory where you want to copy the files selected above."},
            {"ListBoxDirectoriesResult", "The selected directories are displayed here."},
            {"LabelTypeExtension", "Specify the extension with which the files should be copied. Specify extensions separated by commas."},
            {"LabelDaysToCopy", "Specify how many last days to back up. Days had to be given as a number."},
            {"CheckBoxCopyAllTheFiles", "All files from the selected directory will be copied."},
            {"GroupAdditionalSettings", "Here you can add additional settings."},
            {"LabelTips", EnglishLabelDefault},
            {"menuStrip1", EnglishLabelDefault},
            {"checkBox1NotifyAboutCopying", "The program will notify you about the start and end of copying."},
            {"checkBox3PermissionToStopCopy", "A button will appear in the initial window of the program, that allow you to interrupt the copying process."},
            {"checkBox4StartCopyingAgain", "If the copying process is interrupted, you will be promted to try it again."},
            {"ButtonApply", "Apply all selected settings."},
            {"ButtonCancel", "Cancel all selected settings and return to the initial program window."},
            {"ButtonOk", "Apply all selected settings and return to the initial program window."},
            {"ButtonChooseDirectoryToCopy", "Select a directory with files to copy."},
            {"ButtonChooseTargetDirectory", "Select the directory to copy to."},
            {"TextBoxTypeExtension", "Specify the extension with which the files should be copied. Specify extensions separated by commas."},
            {"TextBoxDaysToCopy", "Specify how many last days to back up. Days had to be given as a number."},
            {"Panel", EnglishLabelDefault},
            {"PanelSelectDate", "Select the date when you want the copy task to be completed."}
        };
    }
}
