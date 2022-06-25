using System.IO;
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Reflection;
namespace WinFormsApp1
{
    static class Methods
    {
        static int ForCopying = 0;
        private static string ChooseFolder(string path)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            return path;
        }
        public static void AddFolder(string text, ref string ChoosingDirectoryPath, in string AnotherDirectoryPath, ListBox ListBoxDirectoriesResult)
        {
            int index;
            string ChoosingDirectoryPath1 = ChoosingDirectoryPath;
            string ChoosingDirectoryPath2 = ChooseFolder(ChoosingDirectoryPath);
            if (ChoosingDirectoryPath2 != null)
            {
                if (ChoosingDirectoryPath2 == AnotherDirectoryPath) MessageBox.Show("���������� �� ������ ���������");
                else
                {
                    ChoosingDirectoryPath = ChoosingDirectoryPath2;
                    index = ListBoxDirectoriesResult.Items.IndexOf(text + ChoosingDirectoryPath1);
                    if (index! != -1) ListBoxDirectoriesResult.Items.Insert(index, text + ChoosingDirectoryPath);
                    else ListBoxDirectoriesResult.Items.Add(text + ChoosingDirectoryPath);
                    ListBoxDirectoriesResult.Items.Remove(text + ChoosingDirectoryPath1);
                    if (!ListBoxDirectoriesResult.Visible) ListBoxDirectoriesResult.Visible = true;
                }
            }
        }

        public static string EnoughSpaceOrThreeDots(string str, int max)
        {
            if (str.Length > max)
            {
                str = str.Remove(max - 1, str.Length - max + 1);
                str = str.Insert(str.Length, "...");
            }
            return str;
        }
        public static void CopyFolder(string SourcePath, string TargertPath)
        {
            if (ForCopying == 0)
            {
                TargertPath = Directory.CreateDirectory(TargertPath + SourcePath.Substring(SourcePath.LastIndexOf('\\'))).FullName;
                ForCopying++;
                CopyFolder(SourcePath, TargertPath);
            }
            else
            {
                foreach (string directory in Directory.GetDirectories(SourcePath))
                {
                    CopyFolder(directory, TargertPath + directory.Substring(directory.LastIndexOf('\\')));
                }
                if (Directory.GetFiles(SourcePath).Length == 0) Directory.CreateDirectory(TargertPath);
                foreach (string file in Directory.GetFiles(SourcePath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Directory.CreateDirectory(TargertPath);
                    string newTargetPath = TargertPath + fileInfo.FullName.Substring(fileInfo.FullName.LastIndexOf('\\'));
                    fileInfo.CopyTo(newTargetPath);
                }
            }
        }
        public static void CopyFolder(string SourcePath, string TargertPath, string[] Extentions, int Days)
        {
            if (ForCopying == 0)
            {
                TargertPath = Directory.CreateDirectory(TargertPath + SourcePath.Substring(SourcePath.LastIndexOf('\\'))).FullName;
                ForCopying++;
                CopyFolder(SourcePath, TargertPath, Extentions, Days);
            }
            else
            {
                foreach (string directory in Directory.GetDirectories(SourcePath))
                {
                    CopyFolder(directory, TargertPath + directory.Substring(directory.LastIndexOf('\\')), Extentions, Days);
                }
                if (Directory.GetFiles(SourcePath).Length == 0) Directory.CreateDirectory(TargertPath);
                foreach (string file in Directory.GetFiles(SourcePath))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    foreach (string extension in Extentions)
                    {
                        if (fileInfo.Extension == extension && DateTime.Now - fileInfo.LastWriteTime < new TimeSpan(Days, 0, 0, 0))
                        {
                            Directory.CreateDirectory(TargertPath);
                            string newTargetPath = TargertPath + fileInfo.FullName.Substring(fileInfo.FullName.LastIndexOf('\\'));
                            fileInfo.CopyTo(newTargetPath);
                        }
                    }

                }
            }
        }
        public static void ShowTips(string name, Label label)
        {
            foreach (string key in ToolTips.RussianToolTips.Keys)
            {
                if (key == name)
                {
                    label.Text = ToolTips.RussianToolTips[name];
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
