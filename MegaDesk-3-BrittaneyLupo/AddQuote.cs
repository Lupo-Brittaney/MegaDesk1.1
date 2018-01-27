using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BrittaneyLupo
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
        //Vallidate the width input
        private void Width_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidateWidth(width.Text, out errorMsg))
            {
                //Cancel the event and selest the width box to be corrected
                e.Cancel = true;
                width.Select(0, width.Text.Length);

                //Set the ErrorProvider 
                this.errorProvider1.SetError(width, errorMsg);

            }
        }
        private void Width_Validated( object sender, System.EventArgs e)
        {
            //If all conditions have been met clear the error provider
            errorProvider1.SetError(width, "");
        }

        public bool ValidateWidth(string txtWidth, out string errorMessage)
        {
            //conrifrm the width was not left empty
            if(txtWidth.Length == 0)
            {
                errorMessage = "Width is required.";
                return false;
            }

            //check if the width entered is a numerical
            int intWidth;
            if(!Int32.TryParse(txtWidth, out intWidth))
            {
                errorMessage = "Must enter a valid number.";
                return false;
            }

            //check if numerical falls within parameters
            if (intWidth >= 24 && intWidth <=96)
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "Invalid number";
            return false;

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                errorProvider2.SetError(depth, "Enter a number.");
            }
            else 
            {
                errorProvider2.SetError(depth, "");
            }
        }
    }
}
