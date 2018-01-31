using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_BrittaneyLupo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addNewViewAllQuotesForm = new ViewAllQuotes();
            addNewViewAllQuotesForm.Tag = this;
            addNewViewAllQuotesForm.Show(this);
            Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes addNewSearchForm = new SearchQuotes();
            addNewSearchForm.Tag = this;
            addNewSearchForm.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
