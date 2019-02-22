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
    public partial class frmDisplayQuote : Form
    {
        public frmDisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            txtCustomerNameDisplay.Text = deskQuote.CustomerName.ToString();
            widthDisplay.Text = deskQuote.Desk.Width.ToString();
            depthDisplay.Text = deskQuote.Desk.Depth.ToString();
            desktopDisplay.Text = deskQuote.Desk.Material.ToString();
            deliveryDisplay.Text = deskQuote.DeliveryType.ToString();
            numOfDrawersDisplay.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            quoteAmount.Text = deskQuote.QuoteAmount.ToString();
            
        }

        private void cancelQuoteBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
