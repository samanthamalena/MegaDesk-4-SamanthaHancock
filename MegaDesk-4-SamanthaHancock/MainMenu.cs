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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewAllQuotes = new ViewAllQuotes();
            addViewAllQuotes.Tag = this;
            addViewAllQuotes.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuotes = new SearchQuotes();
            addSearchQuotes.Tag = this;
            addSearchQuotes.Show(this);
            Hide();
        }
    }
}
