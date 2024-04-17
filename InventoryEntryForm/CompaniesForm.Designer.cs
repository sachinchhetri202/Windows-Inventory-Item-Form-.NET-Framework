namespace InventoryEntryForm
{
    partial class CompaniesForm
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
            this.dgCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCompanies
            // 
            this.dgCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompanies.Location = new System.Drawing.Point(12, 12);
            this.dgCompanies.Name = "dgCompanies";
            this.dgCompanies.Size = new System.Drawing.Size(687, 324);
            this.dgCompanies.TabIndex = 0;
            this.dgCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompanies_CellClick);
            // 
            // CompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 348);
            this.Controls.Add(this.dgCompanies);
            this.Name = "CompaniesForm";
            this.Text = "Companies Form";
            this.Load += new System.EventHandler(this.CompaniesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCompanies;
    }
}