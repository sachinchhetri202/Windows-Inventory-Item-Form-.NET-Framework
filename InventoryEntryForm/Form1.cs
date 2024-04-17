using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryEntryForm
{
    public partial class frmInventoryItem : Form
    {
        public frmInventoryItem()
        {
            InitializeComponent();

            #region Data Binding for categories
            try
            {
                StoreManagement.CategoryDataTable dtCategoryTable = Utility.GetCategories();
                var dummyRow = dtCategoryTable.NewRow();
                dummyRow["ID"] = -1; // Use -1 or another placeholder that suits your ID schema but won't conflict with actual IDs
                dummyRow["Category"] = "--Select One--"; 
                dtCategoryTable.Rows.InsertAt(dummyRow, 0); // Insert at the first position
                cmbItem.DataSource = dtCategoryTable;
                cmbItem.DisplayMember = dtCategoryTable.CategoryColumn.ColumnName;
                cmbItem.ValueMember = dtCategoryTable.IDColumn.ColumnName;
                cmbItem.SelectedIndex = 0;
            }
            catch (SqlException SqlException)
            {
                MessageBox.Show("SQL specific error. Cannot Load Categories. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address: maiwau@super.com\n" + SqlException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled Exception. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address\n" + ex.Message);
            }
            #endregion

            #region Data Binding for categories in search
            try
            {
                StoreManagement.CategoryDataTable dtCategoryTable = Utility.GetCategories();
                var dummyRow = dtCategoryTable.NewRow();
                dummyRow["ID"] = -1; 
                dummyRow["Category"] = "--Select One--"; 
                dtCategoryTable.Rows.InsertAt(dummyRow, 0);
                cmbSearch.DataSource = dtCategoryTable;
                cmbSearch.DisplayMember = dtCategoryTable.CategoryColumn.ColumnName;
                cmbSearch.ValueMember = dtCategoryTable.IDColumn.ColumnName;
                cmbSearch.SelectedIndex = 0;
            }
            catch (SqlException SqlException)
            {
                MessageBox.Show("SQL specific error. Cannot Load Categories. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address: maiwau@super.com\n" + SqlException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled Exception. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address\n" + ex.Message);
            }
            #endregion

            #region Data Binding for company
            try
            {
                StoreManagement.CompanyDataTable dtCompanyTable = Utility.GetCompany();
                cmbCompanies.DataSource = dtCompanyTable;
                cmbCompanies.DisplayMember = dtCompanyTable.CompanyNameColumn.ColumnName;
                cmbCompanies.ValueMember = dtCompanyTable.IDColumn.ColumnName;
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

            #region Data Grid Load
            // loads the data into the datagrid
            try { 
                dgItems.DataSource = Utility.GetInventoryItems();
                //Hide ID column
                dgItems.Columns["ID"].Visible = false;
                dgItems.Columns["CompanyID"].Visible = false; 
                dgItems.Columns["Length"].Visible = false;
                dgItems.Columns["Width"].Visible = false;
                dgItems.Columns["Height"].Visible = false;
                dgItems.Columns["Weight"].Visible = false;
                dgItems.Columns["ISBN"].Visible = false;
                dgItems.Columns["Author"].Visible = false;
                dgItems.Columns["BookType"].Visible = false;
                dgItems.Columns["PackagingDate"].Visible = false;
                dgItems.Columns["ExpiryDate"].Visible = false;
                dgItems.Columns["GroceryCategory"].Visible = false;
            }
            catch (SqlException SqlException)
            {
                MessageBox.Show("SQL specific error. Cannot Load Inventory. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address: maiwau@super.com\n" + SqlException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled Exception. Contact your administrator.\n\nPhone Number: 801-767-9899, or Email Address\n" + ex.Message);
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgItems.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Use to Update";
            updateColumn.Text = "Update";
            updateColumn.Name = "updateButton";
            updateColumn.UseColumnTextForButtonValue = true;

            dgItems.Columns.Add(updateColumn);
            #endregion
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtItem.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all required fields (Item, Price, Description).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (cmbItem.SelectedIndex < 0)
            {
                cmbItem.BackColor = Color.Yellow;
                MessageBox.Show("Please Select the Item Type");
                return;
            }

            int quantity = 1;
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string itemTitle = txtItem.Text;
            int category = (int)cmbItem.SelectedValue;
            float price = float.Parse(txtPrice.Text);
            string Description = txtDescription.Text;
            int companyID = (int)cmbCompanies.SelectedValue;
            DateTime packagingDate = dateTimePickerPackagingDate.Value;
            DateTime expiryDate = dateTimePickerExpiryDate.Value;

            string itemInfo = string.Empty;
            itemInfo += cmbItem.Text + " Item" + "\r\n";
            itemInfo += "Item: " + txtItem.Text + "\r\n";
            itemInfo += "Price: " + txtPrice.Text + "\r\n";
            itemInfo += "Description: " + txtDescription.Text + "\r\n";

            for (int i = 0; i < quantity; i++)
            {
                switch (cmbItem.SelectedIndex)
                {
                    case 1: // Book
                        string ISBN = txtISBN.Text;
                        string Author = txtAuthor.Text;
                        int BookType = cmbBookType.SelectedIndex; 
                        itemInfo += "ISBN: " + txtISBN.Text + "\r\n";
                        itemInfo += "Author: " + txtAuthor.Text + "\r\n";
                        itemInfo += "Book Type: " + cmbBookType.SelectedItem.ToString() + "\r\n";
                        DataAccessLayer.Utility.SaveInventoryItem(itemTitle, category, price, Description, companyID, 0, 0, 0, 0, ISBN, Author, BookType, packagingDate, expiryDate, category);
                        break;
                    case 2: // Furniture
                        float length = float.Parse(txtLength.Text);
                        float width = float.Parse(txtWidth.Text);
                        float height = float.Parse(txtHeight.Text);
                        float weight = float.Parse(txtWeight.Text);
                        itemInfo += "Dimensions: " + txtLength.Text + " x " + txtWidth.Text + " x " + txtHeight.Text + "\r\n";
                        itemInfo += "Weight: " + txtWeight.Text + "\r\n";
                        DataAccessLayer.Utility.SaveInventoryItem(itemTitle, category, price, Description, companyID, length, width, height, weight, null, null, 0, packagingDate, expiryDate, category);
                        break;
                    case 3: // Produce
                        packagingDate = dateTimePickerPackagingDate.Value;
                        expiryDate = dateTimePickerExpiryDate.Value;
                        if (expiryDate <= packagingDate)
                        {
                            // Set the error on the expiry date picker control
                            errorProvider.SetError(dateTimePickerExpiryDate, "Expiry date must be after the packaging date.");
                            MessageBox.Show("The expiry date must be after the packaging date. Please correct it before proceeding.", "Date Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Exit the method to prevent saving the data until the error is corrected
                        }
                        itemInfo += "Packaging Date: " + packagingDate.ToString("yyyy-MM-dd") + "\r\n";
                        itemInfo += "Expiry Date: " + expiryDate.ToString("yyyy-MM-dd") + "\r\n";
                        DataAccessLayer.Utility.SaveInventoryItem(itemTitle, category, price, Description, companyID, 0, 0, 0, 0, null, null, 0, packagingDate, expiryDate, category);
                        break;
                }
            }
            RefreshInventoryDataGrid();
            MessageBox.Show($"Saved {quantity} Item!! Successfully");
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.BackColor = Color.White;
            groupBoxDimensions.Visible = false;
            groupBoxDate.Visible = false;
            groupBoxBooks.Visible = false;

            switch (cmbItem.SelectedIndex)
            {
                case 1:
                    groupBoxBooks.Visible = true;
                    break;
                case 2:
                    groupBoxDimensions.Visible = true;
                    break;
                case 3:
                    groupBoxDate.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbItem.Text = "--Select One--";
            txtItem.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            txtLength.Text = "";
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            dateTimePickerPackagingDate.Text = "";
            dateTimePickerExpiryDate.Text = "";
            txtISBN.Text = "";
            txtAuthor.Text = "";
            txtBookType.Text = "";
            cmbBookType.Text = "";
            cmbCompanies.Text = "";
            txtQuantity.Text = "";
            cmbSearch.Text = "--Select One--";
            txtSearch.Text = "";
            groupBoxDimensions.Visible = false;
            groupBoxDate.Visible = false;
            groupBoxBooks.Visible = false;
            errorProvider.Clear();
            RefreshInventoryDataGrid();
        }

        private void frmInventoryItem_Load(object sender, EventArgs e)
        {
            groupBoxDimensions.Visible = false;
            groupBoxDate.Visible = false;
            groupBoxBooks.Visible = false;
        }

        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentInventoryId = -1;

            DataGridView dg = (DataGridView)sender;
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];

            currentInventoryId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());

            if (e.ColumnIndex == -1)
            {
                RefreshInventoryDataGrid();
            }

            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        Utility.DeleteInventoryById(currentInventoryId);
                        MessageBox.Show("Item Deleted!");
                        RefreshInventoryDataGrid();
                    }
                    else if (selectedCell.Value.Equals("Update"))
                    {
                        string itemTitle = rowToBeOperatedUpon.Cells["ItemTitle"].Value.ToString();
                        int category = int.Parse(rowToBeOperatedUpon.Cells["Category"].Value.ToString());
                        float price = float.Parse(rowToBeOperatedUpon.Cells["Price"].Value.ToString());
                        string Description = rowToBeOperatedUpon.Cells["Description"].Value.ToString();
                        
                        Utility.UpdateInventory(currentInventoryId, itemTitle, category, price, Description);
                        MessageBox.Show("Sucessfully Updated!", "Close Window", MessageBoxButtons.OK);
                        RefreshInventoryDataGrid();
                    }
                }
                return;
            }
        }

        private void RefreshInventoryDataGrid()
        {
            StoreManagement.InventoryItemDataTable dtInventoryTable = Utility.GetInventoryItems();
            dgItems.DataSource = dtInventoryTable;
        }

        private void FilterInventoryItems()
        {
            DataView dv = ((DataTable)dgItems.DataSource).DefaultView;
            string itemTitleFilter = txtSearch.Text.Trim();
            string categoryFilter = cmbSearch.SelectedValue?.ToString();

            string filter = "";

            // Check if both filters should be applied
            if (!string.IsNullOrEmpty(itemTitleFilter) && cmbSearch.SelectedIndex > 0)
            {
                filter = $"ItemTitle LIKE '%{itemTitleFilter}%' AND Category = {categoryFilter}";
            }
            else if (!string.IsNullOrEmpty(itemTitleFilter))
            {
                filter = $"ItemTitle LIKE '%{itemTitleFilter}%'";
            }
            else if (cmbSearch.SelectedIndex > 0)
            {
                filter = $"Category = {categoryFilter}";
            }

            dv.RowFilter = filter;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                FilterInventoryItems();
            }
        }

        private void cmbSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {   
            if (cmbSearch.SelectedIndex == 0)
            {
                RefreshInventoryDataGrid();
            }
            else {
                FilterInventoryItems();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterInventoryItems();
        }
    }
}
