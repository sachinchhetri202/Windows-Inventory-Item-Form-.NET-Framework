using System;
using DataAccessLayer.StoreManagementTableAdapters;
using static DataAccessLayer.StoreManagement;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Utility
    {
        public static StoreManagement.CategoryDataTable GetCategories()
        {
            CategoryTableAdapter categoryAdapter = new CategoryTableAdapter();
            CategoryDataTable dtCategoryTable = new CategoryDataTable();
            try
            {
                categoryAdapter.Fill(dtCategoryTable);
            }
            catch (SqlException SqlException)
            {
                throw SqlException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCategoryTable;
        }

        public static StoreManagement.CompanyDataTable GetCompany()
        {
            CompanyTableAdapter companyAdapter = new CompanyTableAdapter();
            CompanyDataTable dtCompanyTable = new CompanyDataTable();
            try
            {
                companyAdapter.Fill(dtCompanyTable);
            }
            catch (SqlException SqlException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCompanyTable;
        }

        public static StoreManagement.InventoryItemDataTable GetInventoryItems()
        {
            InventoryItemTableAdapter inventoryAdapter = new InventoryItemTableAdapter();
            InventoryItemDataTable dtInventoryTable = new InventoryItemDataTable();
            try
            {
                inventoryAdapter.Fill(dtInventoryTable);
            }
            catch (SqlException SqlException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtInventoryTable;
        }

        public static void UpdateCompanies(int ID, string companyName, string ContactNumber, string address)
        {
            CompanyTableAdapter companyAdapter = new CompanyTableAdapter();
            CompanyDataTable dtCompanyTable = new CompanyDataTable();
            try
            {
                companyAdapter.Fill(dtCompanyTable);

                foreach (StoreManagement.CompanyRow row in dtCompanyTable.Rows)
                {
                    if (row.ID == ID)
                    {
                        row.CompanyName = companyName;
                        row.ContactNumber = ContactNumber;
                        row.Address = address;
                    }
                }
                companyAdapter.Update(dtCompanyTable);
            }
            catch (SqlException SqlException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteCompaniesById(int ID)
        {
            CompanyTableAdapter companyAdapter = new CompanyTableAdapter();
            CompanyDataTable dtCompanyTable = new CompanyDataTable();
            try
            {
                companyAdapter.Fill(dtCompanyTable);
                StoreManagement.CompanyRow rowToDelete = dtCompanyTable.FindByID(ID);

                if (rowToDelete != null)
                {
                    rowToDelete.Delete();
                    companyAdapter.Update(dtCompanyTable);
                }
            }
            catch (SqlException SqlException)
            {
                throw SqlException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateInventory(int ID, string itemTitle, int category, float price, string Description)
        {
            InventoryItemTableAdapter inventoryAdapter = new InventoryItemTableAdapter();
            InventoryItemDataTable dtInventoryTable = new InventoryItemDataTable();
            try
            {
                inventoryAdapter.Fill(dtInventoryTable);

                foreach (StoreManagement.InventoryItemRow row in dtInventoryTable.Rows)
                {
                    if (row.ID == ID)
                    {
                        row.ItemTitle = itemTitle;
                        row.Category = category;
                        row.Price = Math.Round(price, 2);
                        row.Description = Description;
                    }
                }
                inventoryAdapter.Update(dtInventoryTable);
            }
            catch (SqlException SqlException)
            {
                throw SqlException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteInventoryById(int ID)
        {
            InventoryItemTableAdapter inventoryAdapter = new InventoryItemTableAdapter();
            InventoryItemDataTable dtInventoryTable = new InventoryItemDataTable();
            try
            {
                inventoryAdapter.Fill(dtInventoryTable);

                StoreManagement.InventoryItemRow rowToDelete = dtInventoryTable.FindByID(ID);

                if (rowToDelete != null)
                {
                    rowToDelete.Delete();
                    inventoryAdapter.Update(dtInventoryTable);
                }
            }
            catch (SqlException SqlException)
            {
                throw SqlException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveInventoryItem(string itemTitle, int category, float price, string Description, int companyID, float length, float width, float height, float weight, string ISBN, string Author, int BookType, DateTime packagingDate, DateTime expiryDate, int groceryCategory)
        {
            InventoryItemDataTable dtInventoryItem = new InventoryItemDataTable();
            InventoryItemTableAdapter inventoryItemTableAdapter = new InventoryItemTableAdapter();
            try
            {
                inventoryItemTableAdapter.Fill(dtInventoryItem);

                StoreManagement.InventoryItemRow newInventoryItemRow = dtInventoryItem.NewInventoryItemRow();
                newInventoryItemRow.ItemTitle = itemTitle;
                newInventoryItemRow.Category = category;
                newInventoryItemRow.Price = Math.Round(price, 2);
                newInventoryItemRow.Description = Description;
                newInventoryItemRow.CompanyID = companyID;
                newInventoryItemRow.Length = length;
                newInventoryItemRow.Width = width;
                newInventoryItemRow.Height = height;
                newInventoryItemRow.Weight = weight;
                newInventoryItemRow.ISBN = ISBN;
                newInventoryItemRow.Author = Author;
                newInventoryItemRow.BookType = BookType;
                newInventoryItemRow.PackagingDate = packagingDate;
                newInventoryItemRow.ExpiryDate = expiryDate;
                newInventoryItemRow.GroceryCategory = groceryCategory;

                dtInventoryItem.AddInventoryItemRow(newInventoryItemRow);

                inventoryItemTableAdapter.Update(dtInventoryItem);
            }
            catch (SqlException SqlException)
            {
                throw SqlException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
