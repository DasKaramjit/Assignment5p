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
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        private void splashtimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            splashtimer.Stop();
           // Program.startForm.Show();
        }
    }
}
