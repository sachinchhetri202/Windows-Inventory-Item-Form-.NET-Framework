using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryEntryForm
{
    public partial class MainWindow : Form
    {

        private frmInventoryItem invWin;
        private CompaniesForm compWin;
        
        public MainWindow()
        {
            InitializeComponent();
            invWin = new frmInventoryItem();
            invWin.MdiParent = this;
            //invWin.Show();

            compWin = new CompaniesForm();
            compWin.MdiParent = this;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invWin.IsDisposed)
            {
                invWin = new frmInventoryItem();
                invWin.MdiParent = this;
            }
            invWin.Show();
            compWin.Hide();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (compWin.IsDisposed)
            {
                compWin = new CompaniesForm();
                compWin.MdiParent = this;
            }
            compWin.Show();
            invWin.Hide();
        }

    }
}