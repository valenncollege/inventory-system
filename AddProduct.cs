using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxID.Text;
                string name = textBoxName.Text;
                double price = double.Parse(textBoxPrice.Text);
                int stock = int.Parse(textBoxStock.Text);

                Product newProduct = new Product(id, name, price, stock);
                formUtama.listProduct.Add(newProduct);

                listBoxOut.Items.AddRange(newProduct.Display().Split('\n'));
                formUtama.SaveProduct(formUtama.defaultProductName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
