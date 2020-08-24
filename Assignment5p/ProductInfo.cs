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
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }
        private void LoadProductInformation()
        {
            if (Program.selectitem != null)
            {
                textBox1.Text = Program.selectitem.productID.ToString();
                textBox3.Text = Program.selectitem.condition;
                textBox2.Text = ((decimal)Program.selectitem.cost).ToString("C2");

              
            }
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
          


                if (Program.selectitem != null)
                {
                    LoadProductInformation();
                    button1.Enabled = true;
                }
             
            
        }

        private void selectanother_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.ShowDialog();
        }

      
    }
}
