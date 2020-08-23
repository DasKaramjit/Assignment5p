using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5p
{
    public partial class Startform : Form
    {
        public Startform()
        {
            InitializeComponent();
        }

        private void startneworder_Click(object sender, EventArgs e)
        {
              this.Hide();
            Program.selectForm.ShowDialog();
        }

        private void loadorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
