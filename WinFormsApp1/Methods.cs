using System.IO;
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Reflection;
using WinFormsApp1.AllProgramSettings;


namespace WinFormsApp1
{
    static class Methods
    {
        static bool forCopying;
        private static string ChooseFolder(string path)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            return path;
        }
        public static void AddFolder(string text, ref string choosingDirectoryPath, in string anotherDirectoryPath, ListBox listBoxDirectoriesResult)
        {
            int index;
            string choosingDirectoryPath1 = choosingDirectoryPath;
            string choosingDirectoryPath2 = ChooseFolder(choosingDirectoryPath);
            if (choosingDirectoryPath2 != null)
            {
                if (choosingDirectoryPath2 == anotherDirectoryPath) MessageBox.Show("Директории не должны совпадать");
                else
                {
                    choosingDirectoryPath = choosingDirectoryPath2;
                    index = listBoxDirectoriesResult.Items.IndexOf(text + choosingDirectoryPath1);
                    if (index! != -1) listBoxDirectoriesResult.Items.Insert(index, text + choosingDirectoryPath);
                    else listBoxDirectoriesResult.Items.Add(text + choosingDirectoryPath);
                    listBoxDirectoriesResult.Items.Remove(text + choosingDirectoryPath);
                    if (!listBoxDirectoriesResult.Visible) listBoxDirectoriesResult.Visible = true;
                }
            }
        }
        public static void AddFolder2(string text, ref string choosingDirectoryPath, in string anotherDirectoryPath, ListBox listBoxDirectoriesResult)
        {
            int index;
            string choosingDirectoryPath1 = choosingDirectoryPath;
            string choosingDirectoryPath2 = ChooseFolder(choosingDirectoryPath);
            if (!string.IsNullOrEmpty(choosingDirectoryPath2))
            {
                if (string.IsNullOrEmpty(choosingDirectoryPath))
                {
                    if (choosingDirectoryPath2 == anotherDirectoryPath) MessageBox.Show("Директории не должны совпадать");
                    else
                    {
                        choosingDirectoryPath = choosingDirectoryPath2;
                        listBoxDirectoriesResult.Items.Add(text + choosingDirectoryPath);
                    }
                }
                else
                {
                    if (choosingDirectoryPath2 == anotherDirectoryPath) MessageBox.Show("Директории не должны совпадать");
                    else
                    {
                        choosingDirectoryPath = choosingDirectoryPath2;
                        index = listBoxDirectoriesResult.Items.IndexOf(text + choosingDirectoryPath1);
                        if (index! != -1)
                        {
                            listBoxDirectoriesResult.Items.Insert(index, text + choosingDirectoryPath);
                        }
                        else
                        {
                            listBoxDirectoriesResult.Items.Add(text + choosingDirectoryPath);
                        }
                        listBoxDirectoriesResult.Items.Remove(text + choosingDirectoryPath);
                        if (!listBoxDirectoriesResult.Visible) listBoxDirectoriesResult.Visible = true;
                    }
                }
            }
        }
        #region Пхожие по сути методы
        /*-----------------------------Майби что-то пригодится-----------------------------*/
        public static void ChooseFolderAndCheckingForSameness(ref string mainFolder, ref string whatToCompareWith) //Выбор папки и проверка на одинаковость
        {
            string tempPathBackupFolder = "";
            tempPathBackupFolder = ChooseFolder(tempPathBackupFolder);
            if (!string.IsNullOrEmpty(tempPathBackupFolder))
            {
                if (tempPathBackupFolder != whatToCompareWith)
                {
                    mainFolder = tempPathBackupFolder;
                }
                else
                {
                    MessageBox.Show(Other.directoriesShouldNotMatchRu);
                }
            }
        }
        public static void ShowFolderOnListBox(string nameFolder, ListBox listBox, string landmark) //обновление listBox 
        {
            if (!string.IsNullOrEmpty(nameFolder))
            {
                string temp = "";
                int index = 0;
                foreach (var item in listBox.Items)
                {
                    if (item.ToString().Contains(landmark))
                    {
                        index = listBox.Items.IndexOf(item);
                        temp = item.ToString();
                        break;
                    }
                }
                if (index != -1)
                {
                    listBox.Items.Remove(temp);
                    listBox.Items.Insert(index, landmark + nameFolder);
                }
                else
                {
                    listBox.Items.Add(landmark + nameFolder);
                }
            }
        }
        #endregion 
        public static string EnoughSpaceOrThreeDots(string str, int max)
        {
            if (str.Length > max)
            {
                str = str.Remove(max - 1, str.Length - max + 1);
                str = str.Insert(str.Length, "...");
            }
            return str;
        }
        public static void CopyFolder(string sourcePath, string targetPath)
        {
            if (forCopying)
            {
                targetPath = Directory.CreateDirectory(targetPath + sourcePath.Substring(sourcePath.LastIndexOf('\\'))).FullName;
                forCopying = false;
                CopyFolder(sourcePath, targetPath);
            }
            else
            {
                foreach (string directory in Directory.GetDirectories(sourcePath))
                {
                    CopyFolder(directory, targetPath + directory.Substring(directory.LastIndexOf('\\')));
                }
                if (Directory.GetFiles(sourcePath).Length == 0) Directory.CreateDirectory(targetPath);
                foreach (string file in Directory.GetFiles(sourcePath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Directory.CreateDirectory(targetPath);
                    string newTargetPath = targetPath + fileInfo.FullName.Substring(fileInfo.FullName.LastIndexOf('\\'));
                    fileInfo.CopyTo(newTargetPath);
                }
            }
        }
        public static void CopyFolder(string sourcePath, string targetPath, string[] extentions, int days)
        {
            if (forCopying)
            {
                targetPath = Directory.CreateDirectory(targetPath + sourcePath.Substring(sourcePath.LastIndexOf('\\'))).FullName;
                forCopying = false;
                CopyFolder(sourcePath, targetPath, extentions, days);
            }
            else
            {
                foreach (string directory in Directory.GetDirectories(sourcePath))
                {
                    CopyFolder(directory, targetPath + directory.Substring(directory.LastIndexOf('\\')), extentions, days);
                }
                if (Directory.GetFiles(sourcePath).Length == 0) Directory.CreateDirectory(targetPath);
                foreach (string file in Directory.GetFiles(sourcePath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    foreach (string extension in extentions)
                    {
                        if (fileInfo.Extension == extension && DateTime.Now - fileInfo.LastWriteTime < new TimeSpan(days, 0, 0, 0))
                        {
                            Directory.CreateDirectory(targetPath);
                            string newTargetPath = targetPath + fileInfo.FullName.Substring(fileInfo.FullName.LastIndexOf('\\'));
                            fileInfo.CopyTo(newTargetPath);
                        }
                    }
                }
            }
        }
        public static void ShowTips(string name, Label label)
        {
            foreach (string key in ToolTips.russianToolTips.Keys)
            {
                if (key == name)
                {
                    label.Text = ToolTips.russianToolTips[name];
                    break;
                }
            }
        }
        public static void SetLaunchingAlongWithWindows()
        {
            //HKEY_LOCAL_MACHINE
            Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Key.SetValue("WinFormsApp1", Assembly.GetExecutingAssembly().Location);
            Key.Close();
        }
        public static void RemoveLaunchingAlongWithWindows()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.DeleteValue("WinFormsApp1", false);
            key.Close();
        }


    }
}
