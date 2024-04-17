using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryEntryForm
{
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();

            #region Data Grid Load
            // loads the data into the datagrid
            try
            {
                dgCompanies.DataSource = Utility.GetCompany();
                //Hide ID column
                dgCompanies.Columns["ID"].Visible = false;
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.HeaderText = "Use to Delete";
                deleteColumn.Text = "Delete";
                deleteColumn.Name = "deleteButton";
                deleteColumn.UseColumnTextForButtonValue = true;
                dgCompanies.Columns.Add(deleteColumn);

                DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
                updateColumn.HeaderText = "Use to Update";
                updateColumn.Text = "Update";
                updateColumn.Name = "updateButton";
                updateColumn.UseColumnTextForButtonValue = true;

                dgCompanies.Columns.Add(updateColumn);
            }
            catch (SqlException SqlException)
            {
                MessageBox.Show("SQL specific error. Cannot Load Company. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address: maiwau@super.com\n" + SqlException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled Exception. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address\n" + ex.Message);
            }

            #endregion
        }

        private void CompaniesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshCompanyDataGrid()
        {
            StoreManagement.CompanyDataTable dtCompanyTable = Utility.GetCompany();
            dgCompanies.DataSource = dtCompanyTable;
        }

        private void dgCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int currentCompanyId = -1;

            DataGridView dg = (DataGridView)sender;
            if(e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];

            currentCompanyId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());

            if (e.ColumnIndex == -1)
            {
                RefreshCompanyDataGrid();
            }

            if(dg.SelectedCells.Count == 1) 
            {
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        Utility.DeleteCompaniesById(currentCompanyId);
                        MessageBox.Show("Item Deleted!");

                        RefreshCompanyDataGrid();
                    }
                    else if (selectedCell.Value.Equals("Update"))
                    {
                        string CompanyName = rowToBeOperatedUpon.Cells["CompanyName"].Value.ToString();
                        string ContactNumber = rowToBeOperatedUpon.Cells["ContactNumber"].Value.ToString();
                        string address = rowToBeOperatedUpon.Cells["Address"].Value.ToString();
                        Utility.UpdateCompanies(currentCompanyId, CompanyName, ContactNumber, address);
                        MessageBox.Show("Sucessfully Updated!", "Close Window", MessageBoxButtons.OK);
                        RefreshCompanyDataGrid();
                    }
                }
                return;
            }
        }
    }
}
