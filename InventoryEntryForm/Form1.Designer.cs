namespace InventoryEntryForm
{
    partial class frmInventoryItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBoxDimensions = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.dateTimePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dateTimePickerPackagingDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblPackagingDate = new System.Windows.Forms.Label();
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCompanies = new System.Windows.Forms.Label();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lblTEXT = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.groupBoxDimensions.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(123, 70);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(360, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(124, 111);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(128, 205);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(54, 13);
            this.lblItemType.TabIndex = 3;
            this.lblItemType.Text = "Item Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(162, 401);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(149, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(431, 401);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(212, 70);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(449, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // groupBoxDimensions
            // 
            this.groupBoxDimensions.Controls.Add(this.txtWeight);
            this.groupBoxDimensions.Controls.Add(this.txtHeight);
            this.groupBoxDimensions.Controls.Add(this.lblWeight);
            this.groupBoxDimensions.Controls.Add(this.lblHeight);
            this.groupBoxDimensions.Controls.Add(this.txtWidth);
            this.groupBoxDimensions.Controls.Add(this.txtLength);
            this.groupBoxDimensions.Controls.Add(this.lblWidth);
            this.groupBoxDimensions.Controls.Add(this.lblLength);
            this.groupBoxDimensions.Location = new System.Drawing.Point(78, 243);
            this.groupBoxDimensions.Name = "groupBoxDimensions";
            this.groupBoxDimensions.Size = new System.Drawing.Size(561, 114);
            this.groupBoxDimensions.TabIndex = 8;
            this.groupBoxDimensions.TabStop = false;
            this.groupBoxDimensions.Text = "Dimensions";
            this.groupBoxDimensions.Visible = false;
            this.groupBoxDimensions.Enter += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(353, 75);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 7;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(353, 34);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 6;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(286, 75);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(283, 34);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(86, 75);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(86, 34);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(21, 75);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(21, 34);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(217, 205);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 9;
            this.cmbItem.Text = "--Select one--";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(213, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(336, 77);
            this.txtDescription.TabIndex = 11;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.dateTimePickerExpiryDate);
            this.groupBoxDate.Controls.Add(this.txtCategory);
            this.groupBoxDate.Controls.Add(this.lblCategory);
            this.groupBoxDate.Controls.Add(this.dateTimePickerPackagingDate);
            this.groupBoxDate.Controls.Add(this.lblExpiryDate);
            this.groupBoxDate.Controls.Add(this.lblPackagingDate);
            this.groupBoxDate.Location = new System.Drawing.Point(78, 243);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(561, 114);
            this.groupBoxDate.TabIndex = 12;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Dates";
            this.groupBoxDate.Visible = false;
            this.groupBoxDate.Enter += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // dateTimePickerExpiryDate
            // 
            this.dateTimePickerExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpiryDate.Location = new System.Drawing.Point(116, 75);
            this.dateTimePickerExpiryDate.MinDate = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            this.dateTimePickerExpiryDate.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerExpiryDate.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(368, 29);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(115, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(312, 33);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // dateTimePickerPackagingDate
            // 
            this.dateTimePickerPackagingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPackagingDate.Location = new System.Drawing.Point(116, 31);
            this.dateTimePickerPackagingDate.MinDate = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.dateTimePickerPackagingDate.Name = "dateTimePickerPackagingDate";
            this.dateTimePickerPackagingDate.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerPackagingDate.TabIndex = 6;
            this.dateTimePickerPackagingDate.Value = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(29, 75);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(61, 13);
            this.lblExpiryDate.TabIndex = 1;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblPackagingDate
            // 
            this.lblPackagingDate.AutoSize = true;
            this.lblPackagingDate.Location = new System.Drawing.Point(26, 34);
            this.lblPackagingDate.Name = "lblPackagingDate";
            this.lblPackagingDate.Size = new System.Drawing.Size(84, 13);
            this.lblPackagingDate.TabIndex = 0;
            this.lblPackagingDate.Text = "Packaging Date";
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.cmbBookType);
            this.groupBoxBooks.Controls.Add(this.txtAuthor);
            this.groupBoxBooks.Controls.Add(this.txtBookType);
            this.groupBoxBooks.Controls.Add(this.txtISBN);
            this.groupBoxBooks.Controls.Add(this.lblAuthor);
            this.groupBoxBooks.Controls.Add(this.lblBookType);
            this.groupBoxBooks.Controls.Add(this.lblISBN);
            this.groupBoxBooks.Location = new System.Drawing.Point(78, 243);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Size = new System.Drawing.Size(561, 114);
            this.groupBoxBooks.TabIndex = 12;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Books";
            this.groupBoxBooks.Visible = false;
            this.groupBoxBooks.Enter += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // cmbBookType
            // 
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Fantasy",
            "Historical Fiction",
            "Horrer",
            "Mystery",
            "Romance",
            "Science Fiction"});
            this.cmbBookType.Location = new System.Drawing.Point(86, 67);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(121, 21);
            this.cmbBookType.TabIndex = 6;
            this.cmbBookType.Text = "--Select One--";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(353, 27);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(186, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtBookType
            // 
            this.txtBookType.Location = new System.Drawing.Point(459, 68);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.Size = new System.Drawing.Size(24, 20);
            this.txtBookType.TabIndex = 4;
            this.txtBookType.Visible = false;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(86, 27);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(191, 20);
            this.txtISBN.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(309, 30);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(21, 72);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(59, 13);
            this.lblBookType.TabIndex = 1;
            this.lblBookType.Text = "Book Type";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(24, 31);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(274, 366);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(326, 363);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 14;
            // 
            // lblCompanies
            // 
            this.lblCompanies.AutoSize = true;
            this.lblCompanies.Location = new System.Drawing.Point(363, 208);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(59, 13);
            this.lblCompanies.TabIndex = 15;
            this.lblCompanies.Text = "Companies";
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(428, 205);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(121, 21);
            this.cmbCompanies.TabIndex = 16;
            this.cmbCompanies.Text = "--Select One--";
            this.cmbCompanies.SelectedIndexChanged += new System.EventHandler(this.cmbCompanies_SelectedIndexChanged);
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(12, 527);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(689, 261);
            this.dgItems.TabIndex = 17;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellContentClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(77, 473);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(519, 471);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(375, 473);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.TabIndex = 21;
            this.cmbSearch.Text = "--Select one--";
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged_1);
            // 
            // lblTEXT
            // 
            this.lblTEXT.AutoSize = true;
            this.lblTEXT.Location = new System.Drawing.Point(77, 457);
            this.lblTEXT.Name = "lblTEXT";
            this.lblTEXT.Size = new System.Drawing.Size(167, 13);
            this.lblTEXT.TabIndex = 22;
            this.lblTEXT.Text = "Search by Item Title and Category";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(282, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(143, 20);
            this.lblHeading.TabIndex = 23;
            this.lblHeading.Text = "Add Inventory Item";
            // 
            // frmInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 803);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblTEXT);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.cmbCompanies);
            this.Controls.Add(this.lblCompanies);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxBooks);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.groupBoxDimensions);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Name = "frmInventoryItem";
            this.Text = "Inventory Item: Add";
            this.Load += new System.EventHandler(this.frmInventoryItem_Load);
            this.groupBoxDimensions.ResumeLayout(false);
            this.groupBoxDimensions.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBoxDimensions;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblPackagingDate;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCompanies;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPackagingDate;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label lblTEXT;
        private System.Windows.Forms.Label lblHeading;
    }
}

