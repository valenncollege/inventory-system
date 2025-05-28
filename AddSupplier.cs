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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
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
                string address = textBoxAddress.Text;
                Supplier newSupplier = new Supplier(id, name, address);
                formUtama.listSupplier.Add(newSupplier);
                listBoxOut.Items.AddRange(newSupplier.Display().Split('\n'));
                formUtama.SaveSupplier(formUtama.defaultSupplierName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
