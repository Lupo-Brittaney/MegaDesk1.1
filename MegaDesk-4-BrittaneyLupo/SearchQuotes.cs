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
    public partial class SearchQuotes : Form
    {
        DeskMaterial DeskMaterial;

        public SearchQuotes()
        {
            InitializeComponent();
            //create the list for the materaial combobox from the enum materials
            List<DeskMaterial> DeskMaterialList = Enum.GetValues(typeof(DeskMaterial)).Cast<DeskMaterial>().ToList();
            materialSelectBox.DataSource = DeskMaterialList;


        }



        private void MaterialSelected(object sender, EventArgs e)
        {
            InitializeComponent();
            //get material string from emun
            string Material = materialSelectBox.SelectedItem.ToString();
            Enum.TryParse(Material, out DeskMaterial);

            //string Material = "Veneer";
            



        }
        private void quoteCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void materialSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get material string from emun
            string Material = materialSelectBox.SelectedItem.ToString();
            Enum.TryParse(Material, out DeskMaterial);
            
            label2.Text = "";
            searchDisplay.Clear();
            string line;
            using (StreamReader file = new StreamReader("quote.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(Material))
                    {
                        searchDisplay.Items.Add(line);
                        label2.Text += line + "\n";
                    }


                }

            }

        }
    }
    
}

