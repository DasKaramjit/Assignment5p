﻿using System;
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
    public partial class OrderForm : Form
    {
        // Declare constant to hold 13% sales tax
        const decimal TAX = 0.13M;
        public OrderForm()
        {
            InitializeComponent();
        }

        

     

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string msg = "Thank you for business with us!\nYour order will be processed in 7-10 business days.";

            MessageBox.Show(msg, "Information!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

    }
}
