using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_SamanthaHancock
{
    public partial class AddQuote : Form
    {
        
        public AddQuote()
        {
            InitializeComponent();
        }
        private void cancelQuoteButton(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MainMenu addReturnButton = new MainMenu();
            addReturnButton.Tag = this;
            addReturnButton.Show(this);
            Hide();
        }
        private void textBox1_Validating(object sender, 
            System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text = int.MinValue)
                minValue = 24;
            {
                MessageBox.Show("Width must be between 24 and 96 inches.");
            }
             
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* private bool nonNumberEntered = false;
                private void textBox2_KeyPress(object sender,
                     System.Windows.Forms.KeyEventArgs e)
                {
                    nonNumberEntered = false;
                    if (e.KeyCode < Keys.Down || e.KeyCode > Keys.D9)
                    {
                      if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                        {
                            if(e.KeyCode != Keys.Back)
                            {
                                nonNumberEntered = true;
                            }
                        }
                    }
                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        nonNumberEntered = true;
                    }
                }
        */
        }
    }
}
