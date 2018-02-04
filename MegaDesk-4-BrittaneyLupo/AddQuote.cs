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
    public partial class AddQuote : Form
    {
        //variables needed
        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        int RushDays = 0;
        int QuoteTotal = 0;
        DeskMaterial DeskMaterial;
        string DateNow = String.Empty;

        public AddQuote()
        {
            InitializeComponent();
            //create the list for the materaial combobox from the enum materials
            List<DeskMaterial> DeskMaterialList = Enum.GetValues(typeof(DeskMaterial)).Cast<DeskMaterial>().ToList();
            material.DataSource = DeskMaterialList;
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        //check for digits in width and depth
        private void Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        //Validate the depth Quote
        private void Validating_Depth(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidateDepth(depth.Text, out errorMsg))
            {
                //Cancel the event and selest the width box to be corrected
                e.Cancel = true;
                depth.Select(0, depth.Text.Length);

                //Set the ErrorProvider 
                this.errorProvider1.SetError(depth, errorMsg);

            }
        }
        private void Validated_Depth(object sender, EventArgs e)
        {
            //If all conditions have been met clear the error provider
            errorProvider1.SetError(depth, "");
        }
        public bool ValidateDepth(string depth, out string errorMessage)
        {
            //conrifrm the width was not left empty 
            if (depth.Length == 0)
            {
                errorMessage = "Depth is required.";
                return false;
            }

            //turn depth into an int
            int intDepth;
            Int32.TryParse(depth, out intDepth);

            //check if numerical falls within parameters
            if (intDepth >= 12 && intDepth <= 48)
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "Invalid number";
            return false;
            
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            //get inputs
            try
            {
                CustomerName = customerNameBox.Text;
                DeskDepth = int.Parse(depth.Text);
                DeskWidth = int.Parse(width.Text);
                Drawers = int.Parse(drawers.SelectedItem.ToString());
                DateNow = DateTime.Now.ToString("MM/dd/yyyy");

                //get material string from emun
                string Material = material.SelectedItem.ToString();
                Enum.TryParse(Material, out DeskMaterial);

                //get rush days
                string rushDays = rush.SelectedItem.ToString();

             
                switch(rushDays)
                {
                    case "None":
                        RushDays = 0;
                        break;
                    case "3 Days":
                        RushDays = 3;
                        break;
                    case "5 Days":
                        RushDays = 5;
                        break;
                    case "7 Days":
                        RushDays = 7;
                        break;
                    
                }
                //create the new desk quote and calculate the total
                DeskQuote NewOrder = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, RushDays, DeskMaterial);
                QuoteTotal = NewOrder.GetQuoteTotal();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occurred");
                throw;
            }
            try
            {
                //build string for writing
                var QuoteRecord = CustomerName + ", " + DateNow + ", " + DeskWidth + ", " + DeskDepth + ", " + Drawers + ", " + RushDays + ", " + DeskMaterial + ", " + QuoteTotal;
                string cfile = @"quote.txt";
                if (!File.Exists(cfile))
                {
                    using (StreamWriter sw = File.CreateText("quote.txt")) 
                    {

                    }
                }
                using (StreamWriter sw = File.AppendText("quote.txt"))
                {
                    sw.WriteLine(QuoteRecord);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in writing to file");
                throw;

            }


            //show the quote page
            var MainMenu = (MainMenu)Tag;
            DisplayQuote newOrderView = new DisplayQuote(CustomerName, DateNow, DeskWidth, DeskDepth, Drawers,  DeskMaterial, RushDays, QuoteTotal)
            {
                Tag = MainMenu
            };
            newOrderView.Show();
            this.Close();

            
        }
    }
}
