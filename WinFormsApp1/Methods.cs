using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Methods
    {
        public static void ChooseFolder(out string path)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            else path = "Не выбрано5";
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
    }
}
