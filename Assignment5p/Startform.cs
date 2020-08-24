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
        /// <summary>
        /// Hide start form and display select form
        /// when user click new order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startneworder_Click(object sender, EventArgs e)
        {
              this.Hide();
            Program.selectForm.Show();
        }
        /// <summary>
        /// Hide start form and display product info form
        /// when user click load saved order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void loadorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
        /// <summary>
        /// Hide start form and display product info form
        /// when user click load saved order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
