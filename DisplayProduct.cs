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
    public partial class DisplayProduct : Form
    {
        public DisplayProduct()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void DisplayProduct_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
            foreach(Product i in formUtama.listProduct)
            {
                listBoxOut.Items.AddRange(i.Display().Split('\n'));
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
