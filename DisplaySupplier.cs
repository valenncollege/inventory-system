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
    public partial class DisplaySupplier : Form
    {
        public DisplaySupplier()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void DisplaySupplier_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
            foreach(Supplier i in formUtama.listSupplier)
            {
                listBoxOut.Items.AddRange(i.Display().Split('\n'));
            }
        }
    }
}
