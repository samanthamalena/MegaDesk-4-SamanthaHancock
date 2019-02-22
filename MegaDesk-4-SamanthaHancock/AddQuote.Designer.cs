namespace MegaDesk_3_SamanthaHancock
{
    partial class AddQuote
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comDeliveryType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butGetQuote = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(143, 97);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(177, 23);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // comDeliveryType
            // 
            this.comDeliveryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDeliveryType.FormattingEnabled = true;
            this.comDeliveryType.Location = new System.Drawing.Point(156, 225);
            this.comDeliveryType.Name = "comDeliveryType";
            this.comDeliveryType.Size = new System.Drawing.Size(121, 24);
            this.comDeliveryType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery Type:";
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWidth.Location = new System.Drawing.Point(156, 145);
            this.numWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 26);
            this.numWidth.TabIndex = 4;
            this.numWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depth:";
            // 
            // numDepth
            // 
            this.numDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepth.Location = new System.Drawing.Point(156, 183);
            this.numDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(121, 26);
            this.numDepth.TabIndex = 7;
            this.numDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numNumberOfDrawers
            // 
            this.numNumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumberOfDrawers.Location = new System.Drawing.Point(157, 298);
            this.numNumberOfDrawers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberOfDrawers.Name = "numNumberOfDrawers";
            this.numNumberOfDrawers.Size = new System.Drawing.Size(46, 26);
            this.numNumberOfDrawers.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of Drawers:";
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(156, 260);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(121, 24);
            this.comSurfaceMaterial.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Surface Material:";
            // 
            // butGetQuote
            // 
            this.butGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGetQuote.Location = new System.Drawing.Point(373, 147);
            this.butGetQuote.Name = "butGetQuote";
            this.butGetQuote.Size = new System.Drawing.Size(110, 56);
            this.butGetQuote.TabIndex = 12;
            this.butGetQuote.Text = "Get Quote";
            this.butGetQuote.UseVisualStyleBackColor = true;
            this.butGetQuote.Click += new System.EventHandler(this.butGetQuote_Click);
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Location = new System.Drawing.Point(373, 242);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(110, 56);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "New Desk Quote:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butGetQuote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comSurfaceMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numNumberOfDrawers);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comDeliveryType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comDeliveryType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numNumberOfDrawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comSurfaceMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butGetQuote;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label7;
    }
}