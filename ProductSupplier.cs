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
    public partial class ProductSupplier : Form
    {
        public ProductSupplier()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        Product SelectedProduct;
        Supplier SelectedSupplier;
        private void ProductSupplier_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
            comboBoxProduct.DataSource = formUtama.listProduct;
            comboBoxProduct.DisplayMember = "Name";

            comboBoxSupplier.DataSource = formUtama.listSupplier;
            comboBoxSupplier.DisplayMember = "Nama";
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            SelectedProduct.ListSupplier.Add(SelectedSupplier);

            listBoxOut.Items.AddRange(SelectedProduct.Display().Split('\n'));

            formUtama.SaveProduct(formUtama.defaultProductName);
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct = (Product)comboBoxProduct.SelectedValue;
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSupplier = (Supplier)comboBoxSupplier.SelectedValue;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
