using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_BrittaneyLupo
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("quote.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    quotesDisplay.Items.Add(line);
                    quotesDisplay2.Text += line + "\n";
                }

            }
        }          
        private void viewCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
                mainMenu.Show();
                Close();
        }
    }
}
