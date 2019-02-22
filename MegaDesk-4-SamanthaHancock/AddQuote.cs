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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                            .Cast<Desk.DesktopMaterial>()
                            .ToList();
            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;

            var delivery = new List<DeskQuote.Delivery>();

            delivery = Enum.GetValues(typeof(DeskQuote.Delivery))
                           .Cast<DeskQuote.Delivery>()
                           .ToList();
            comDeliveryType.DataSource = delivery;

            comDeliveryType.SelectedIndex = -1;

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            
            Close();

        }

        //add code to bin to drop down Delivery from enums

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            String quotesFile = @"quotes.txt";

            using (StreamWriter streamWriter = File.AppendText(quotesFile))
            {
                streamWriter.WriteLine(
                    //Date, time, name, depth, width, numDrawers, material, shipping, somethingElse ?
                    $"{deskQuote.QuoteDate}," +
                    $"{deskQuote.CustomerName}," +
                    $"{deskQuote.Desk.Width}," +
                    $"{deskQuote.Desk.Depth}," +
                    $"{deskQuote.Desk.NumberOfDrawers}," +
                    $"{deskQuote.Desk.Material}," +
                    $"{deskQuote.DeliveryType}," +
                    $"{deskQuote.QuoteAmount}"
                    );
            }

        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void butGetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                Depth = numDepth.Value,
                Width = numWidth.Value,
                NumberOfDrawers = (int)numNumberOfDrawers.Value,
                Material = (Desk.DesktopMaterial)comSurfaceMaterial.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = txtCustomerName.Text,
                QuoteDate = DateTime.Now,
                DeliveryType = (DeskQuote.Delivery)comDeliveryType.SelectedValue
            };

            try
            {
                var quote = deskQuote.GetQuote();
                deskQuote.QuoteAmount = (int)quote;
                AddQuoteToFile(deskQuote);
                frmDisplayQuote frmDisplayQuote = new frmDisplayQuote(deskQuote);
                frmDisplayQuote.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}, err.Message");
            }

        }

    }

}

       
   


