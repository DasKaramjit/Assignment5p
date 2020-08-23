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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.ShowDialog();
        }

        private void selection_Click(object sender, EventArgs e)
        {

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                //GetDataFromSelectedRow();
                Next.Enabled = true;  //make next button enabled
            }
            else
            {
                Next.Enabled = false;
            }
        }
      /*  private void GetDataFromSelectedRow()
        {
            Program.selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;

            if (Program.selectedProduct != null)
            {
                string manufacturer = Program.selectedProduct.manufacturer;
                string model = Program.selectedProduct.model;
                decimal cost = (decimal)Program.selectedProduct.cost;

                textBox1.Text = manufacturer + " " + model + " Priced at: " + cost.ToString("C2");
            }*/
        }
    }

