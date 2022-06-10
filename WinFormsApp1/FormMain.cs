using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        static string DirectoryToCopyPath;
        static string TargetDirectoryPath;
        public FormMain()
        {
            InitializeComponent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void ButtonArbitraryCopying_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormScheduler f = new FormScheduler();
            f.Show();
        }

        private void toolStripMenuCopy_Click(object sender, EventArgs e)
        {
            FormCopyingSettings f = new FormCopyingSettings();
            f.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ButtonChooseTargetFolderClick(object sender, EventArgs e)
        {
            Methods.ChooseFolder(out TargetDirectoryPath);
            ChosenTargetFolderStatus.Text = Methods.EnoughSpaceOrThreeDots(TargetDirectoryPath, 23);
        }

        private void ButtonChooseFolderToCopyClick(object sender, EventArgs e)
        {
            Methods.ChooseFolder(out DirectoryToCopyPath);
            ChosenFolderToCopyStatus.Text = Methods.EnoughSpaceOrThreeDots(DirectoryToCopyPath, 23); ;
        }

    }
}
