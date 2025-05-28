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
    public partial class AddImage : Form
    {
        public AddImage()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void AddImage_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
            comboBoxProduct.DataSource = formUtama.listProduct;
            comboBoxProduct.DisplayMember = "Name";
        }
        Product SelectedProduct;
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct = (Product)comboBoxProduct.SelectedValue;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            string id = textBoxIDImage.Text;
            string name = textBoxFileName.Text;
            ProductImage newImage = new ProductImage(id, name);
            SelectedProduct.AddImage(newImage);

            listBoxOut.Items.AddRange(SelectedProduct.Display().Split('\n'));
            formUtama.SaveProduct(formUtama.defaultProductName);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
