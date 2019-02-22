namespace MegaDesk_3_SamanthaHancock
{
    partial class ViewAllQuotes
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
            this.butCancel = new System.Windows.Forms.Button();
            this.quotesGrid = new System.Windows.Forms.DataGridView();
            this.txtCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comSurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numNumberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comDeliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Location = new System.Drawing.Point(315, 378);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(133, 43);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // quotesGrid
            // 
            this.quotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustomerName,
            this.QuoteAmount,
            this.QuoteDate,
            this.numWidth,
            this.numDepth,
            this.comSurfaceMaterial,
            this.numNumberOfDrawers,
            this.comDeliveryType});
            this.quotesGrid.Location = new System.Drawing.Point(0, 2);
            this.quotesGrid.Name = "quotesGrid";
            this.quotesGrid.Size = new System.Drawing.Size(801, 337);
            this.quotesGrid.TabIndex = 2;
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
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quotesGrid);
            this.Controls.Add(this.butCancel);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.quotesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.DataGridView quotesGrid;
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