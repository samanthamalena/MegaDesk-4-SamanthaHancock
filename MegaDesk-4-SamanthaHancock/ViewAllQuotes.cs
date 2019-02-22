using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_SamanthaHancock
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            loadGrid();
                       
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
       
        private void loadGrid()
        {
            try
            {
                string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });

                    quotesGrid.Rows.Add(arrRow);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Quotes have been created.");
            }
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }


}

