using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
namespace WinFormsApp1
{
    static class Methods
    {
        static int ForCopying = 0;
        public static string ChooseFolder(string path)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            return path;
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
    }
}
