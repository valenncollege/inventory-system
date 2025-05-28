using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Inventory_System
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public BindingList<Product> listProduct = new BindingList<Product>();
        public BindingList<Supplier> listSupplier = new BindingList<Supplier>();

        public string defaultProductName = "product.dat";
        public string defaultSupplierName = "supplier.dat";

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier formSupplier = new AddSupplier();
            formSupplier.Owner = this;
            formSupplier.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct formProduct = new AddProduct();
            formProduct.Owner = this;
            formProduct.ShowDialog();
        }

        private void productImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddImage formImage = new AddImage();
            formImage.Owner = this;
            formImage.ShowDialog();
        }

        private void productSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSupplier formProductSupplier = new ProductSupplier();
            formProductSupplier.Owner = this;
            formProductSupplier.ShowDialog();
        }

        private void displaySupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplaySupplier formDisplaySup = new DisplaySupplier();
            formDisplaySup.Owner = this;
            formDisplaySup.ShowDialog();
        }

        private void displayProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProduct formDisplayProduct = new DisplayProduct();
            formDisplayProduct.Owner = this;
            formDisplayProduct.ShowDialog();
        }
        public void SaveProduct(string fileName)
        {
            FileStream myfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, listProduct);
            myfile.Close();
        }
        public void OpenProduct(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listProduct = (BindingList<Product>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }
        public void SaveSupplier(string fileName)
        {
            FileStream myfile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(myfile, listSupplier);
            myfile.Close();
        }
        public void OpenSupplier(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                listSupplier = (BindingList<Supplier>)formatter.Deserialize(file);
                file.Close();
            }
            else
            {
                MessageBox.Show("File is not exist");
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            OpenProduct(defaultProductName);
            OpenSupplier(defaultSupplierName);
        }
    }
}
