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
    }
}
