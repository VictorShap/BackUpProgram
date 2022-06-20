using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormScheduler : Form
    {
        static string SourceDirectoryPath;
        static string TargetDirectoryPath;
        public FormScheduler()
        {
            InitializeComponent();
        }

        private void FormScheduler_Load(object sender, EventArgs e)
        {

        }
        private void ShowToolTips_MouseHover(object sender, EventArgs e)//Отображение подсказок
        {
            Control control = sender as Control;
            Methods.ShowTips(control.Name, LabelTips);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonChooseDirectoryToCopy_Click(object sender, EventArgs e)
        {
            int index;
            string SourceDirectoryPath1 = SourceDirectoryPath;
            string SourceDirectoryPath2 = Methods.ChooseFolder(SourceDirectoryPath);
            if (SourceDirectoryPath2 != null)
            {
                if (SourceDirectoryPath2 == TargetDirectoryPath) MessageBox.Show("Директории не должны совпадать");
                else
                {
                    SourceDirectoryPath = SourceDirectoryPath2;
                    index = ListBoxDirectoriesResult.Items.IndexOf("Основная директория: " + SourceDirectoryPath1);
                    if (index! != -1) ListBoxDirectoriesResult.Items.Insert(index, "Основная директория: " + SourceDirectoryPath);
                    else ListBoxDirectoriesResult.Items.Add("Основная директория: " + SourceDirectoryPath);
                    ListBoxDirectoriesResult.Items.Remove("Основная директория: " + SourceDirectoryPath1);
                    if (!ListBoxDirectoriesResult.Visible) ListBoxDirectoriesResult.Visible = true;
                }
            }
        }
        private void ButtonChooseTargetDirectory_Click(object sender, EventArgs e)
        {
            int index;
            string TargetDirectoryPath1 = TargetDirectoryPath;
            string TargetDirectoryPath2 = Methods.ChooseFolder(SourceDirectoryPath);
            if (TargetDirectoryPath2 != null)
            {
                if (TargetDirectoryPath2 == SourceDirectoryPath) MessageBox.Show("Директории не должны совпадать");
                else
                {
                    TargetDirectoryPath = TargetDirectoryPath2;
                    index = ListBoxDirectoriesResult.Items.IndexOf("Директория назначения: " + TargetDirectoryPath1);
                    if (index! != -1) ListBoxDirectoriesResult.Items.Insert(index, "Директория назначения: " + TargetDirectoryPath);
                    else ListBoxDirectoriesResult.Items.Add("Директория назначения: " + TargetDirectoryPath);
                    ListBoxDirectoriesResult.Items.Remove("Директория назначения: " + TargetDirectoryPath1);
                    if (!ListBoxDirectoriesResult.Visible) ListBoxDirectoriesResult.Visible = true;
                }
            }
        }
    }
}
