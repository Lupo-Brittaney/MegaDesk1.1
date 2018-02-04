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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string customerName, string viewDate, int width, int depth, int drawers, DeskMaterial material, int rushDays, int quoteTotal)
        {  
            InitializeComponent();
            CustomerNameDisplay.Text = customerName;
            //quoteDateDisplay.Text = quoteDate.ToString("MM/dd/yyyy");
            widthDisplay.Text = width.ToString();
            depthDisplay.Text = depth.ToString();
            drawersDisplay.Text = drawers.ToString();
            materialDisplay.Text = material.ToString();
            rushDisplay.Text = rushDays.ToString();
            quoteTotalDisplay.Text = quoteTotal.ToString();
            quoteDateDisplay.Text = viewDate;





        }

        private void displayCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void quoteTotalDisplay_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
