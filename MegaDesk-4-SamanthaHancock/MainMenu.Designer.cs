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
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(49, 61);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(110, 37);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "Add New Quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Location = new System.Drawing.Point(49, 127);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(110, 40);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(49, 200);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(110, 39);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Location = new System.Drawing.Point(49, 280);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(110, 36);
            this.cancelQuoteButton.TabIndex = 3;
            this.cancelQuoteButton.Text = "Exit";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelQuoteButton);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button cancelQuoteButton;
    }
}

