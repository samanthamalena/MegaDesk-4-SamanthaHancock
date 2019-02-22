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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        
            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();

            comSurfaceMaterialSearch.DataSource = materials;
            comSurfaceMaterialSearch.SelectedIndex = -1;
        }

       
        private void cancelQuoteBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();

        }

        

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            
        }

       private void loadGrid()
        {
            try
            {
                searchQuotesGrid.Rows.Clear();

                string desktopMaterial = comSurfaceMaterialSearch.SelectedValue.ToString();

                string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    if (arrRow[5] == desktopMaterial)
                    {
                        searchQuotesGrid.Rows.Add(arrRow);
                    }
                }
            }


            catch (FileNotFoundException)
            {
                MessageBox.Show("There are no quotes to show.");
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        
    }
        

  
}
