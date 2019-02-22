namespace MegaDesk_3_SamanthaHancock
{
    partial class SearchQuotes
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
            this.searchQuotesGrid = new System.Windows.Forms.DataGridView();
            this.cancelQuoteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comSurfaceMaterialSearch = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comSurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numNumberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comDeliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesGrid
            // 
            this.searchQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustomerName,
            this.QuoteAmount,
            this.QuoteDate,
            this.numWidth,
            this.numDepth,
            this.comSurfaceMaterial,
            this.numNumberOfDrawers,
            this.comDeliveryType});
            this.searchQuotesGrid.Location = new System.Drawing.Point(33, 88);
            this.searchQuotesGrid.Name = "searchQuotesGrid";
            this.searchQuotesGrid.Size = new System.Drawing.Size(738, 275);
            this.searchQuotesGrid.TabIndex = 1;
            // 
            // cancelQuoteBtn
            // 
            this.cancelQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteBtn.Location = new System.Drawing.Point(293, 399);
            this.cancelQuoteBtn.Name = "cancelQuoteBtn";
            this.cancelQuoteBtn.Size = new System.Drawing.Size(188, 39);
            this.cancelQuoteBtn.TabIndex = 2;
            this.cancelQuoteBtn.Text = "Cancel";
            this.cancelQuoteBtn.UseVisualStyleBackColor = true;
            this.cancelQuoteBtn.Click += new System.EventHandler(this.cancelQuoteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(486, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(144, 40);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search Quotes";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Surface Material: ";
            // 
            // comSurfaceMaterialSearch
            // 
            this.comSurfaceMaterialSearch.FormattingEnabled = true;
            this.comSurfaceMaterialSearch.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.comSurfaceMaterialSearch.Location = new System.Drawing.Point(204, 30);
            this.comSurfaceMaterialSearch.Name = "comSurfaceMaterialSearch";
            this.comSurfaceMaterialSearch.Size = new System.Drawing.Size(178, 21);
            this.comSurfaceMaterialSearch.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.HeaderText = "Customer Name";
            this.txtCustomerName.Name = "txtCustomerName";
            // 
            // QuoteAmount
            // 
            this.QuoteAmount.HeaderText = "Quote Amount";
            this.QuoteAmount.Name = "QuoteAmount";
            // 
            // QuoteDate
            // 
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.Name = "QuoteDate";
            // 
            // numWidth
            // 
            this.numWidth.HeaderText = "Width";
            this.numWidth.Name = "numWidth";
            // 
            // numDepth
            // 
            this.numDepth.HeaderText = "Depth";
            this.numDepth.Name = "numDepth";
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.HeaderText = "Surface Material";
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            // 
            // numNumberOfDrawers
            // 
            this.numNumberOfDrawers.HeaderText = "Number of Drawers";
            this.numNumberOfDrawers.Name = "numNumberOfDrawers";
            // 
            // comDeliveryType
            // 
            this.comDeliveryType.HeaderText = "Delivery Type";
            this.comDeliveryType.Name = "comDeliveryType";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comSurfaceMaterialSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cancelQuoteBtn);
            this.Controls.Add(this.searchQuotesGrid);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView searchQuotesGrid;
        private System.Windows.Forms.Button cancelQuoteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comSurfaceMaterialSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn numWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn comSurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn numNumberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn comDeliveryType;
    }
}