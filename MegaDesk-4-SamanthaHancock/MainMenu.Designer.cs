namespace MegaDesk_3_SamanthaHancock
{
    partial class MainMenu
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
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.Location = new System.Drawing.Point(88, 61);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(134, 53);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "Add New Quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.Location = new System.Drawing.Point(88, 146);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(134, 53);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.Location = new System.Drawing.Point(88, 229);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(134, 53);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(88, 320);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(134, 53);
            this.cancelQuoteButton.TabIndex = 3;
            this.cancelQuoteButton.Text = "Exit";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::MegaDesk_3_SamanthaHancock.Properties.Resources.desl;
            this.pictureBox1.InitialImage = global::MegaDesk_3_SamanthaHancock.Properties.Resources.desl;
            this.pictureBox1.Location = new System.Drawing.Point(304, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 255);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelQuoteButton);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

