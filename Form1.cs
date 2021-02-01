using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffertenErsteller
{
    public partial class Form1 : Form
    {
        private readonly char[] CharsToTrim = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public Form1()
        {
            InitializeComponent();
        }
        
        /*
         * Currently creates the Row in the Application.
         * Later it will be either add a new row or delete the row
         */
        private void Bearbeiten_Click(object sender, EventArgs e)
        {
            KostenTabelle = Program.Tm.FillRow(KostenTabelle);
        }

        /*
         * Changes text in Price and Typ according to selected Object.
         */
        public void DropDownItem_SelectetIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Control control = comboBox;
            int row = KostenTabelle.GetRow(control);
            int column = KostenTabelle.ColumnCount;
            foreach (ArbeitsObjekt item in ArbeitsObjektList.ArbeitsObjekte) //Loop for every Object
            {
                if (item != null) 
                {
                    if (String.Equals(comboBox.SelectedItem.ToString(), item.Name)) 
                        //Checks if the Item name is the same as the selected Object name
                    {
                        for (int i = 1; i < column; i++) // Changes the Text according to selected Object
                        {
                            if (KostenTabelle.GetControlFromPosition(i, row).Name.ToString().Contains("tueckPreis"))
                            {
                                KostenTabelle.GetControlFromPosition(i, row).Text = item.Preis.ToString();
                            }
                            if (KostenTabelle.GetControlFromPosition(i, row).Name.Trim(CharsToTrim).Contains("tueckTyp"))
                            {
                                KostenTabelle.GetControlFromPosition(i, row).Text = item.StueckTyp;
                            }
                        }
                    }
                }
            }
            KostenRechner(sender,e);
        }

        /*
         * Calculates the total from the selected Item price and the written amount
         */
        private void KostenRechner(object sender, EventArgs e)
        {
            int row = 0;
            int column = KostenTabelle.ColumnCount;
            Label preis = new Label();
            Label anzahl = new Label();
            Label kosten = new Label();
            switch (sender.GetType().ToString().Substring(21)) //sets the sender according to the changed Input
            {
                case "ComboBox":
                    ComboBox senderComboBox = (ComboBox)sender;
                    row = KostenTabelle.GetRow(senderComboBox);
                    break;
                case "TextBox":
                    TextBox senderTextBox = (TextBox)sender;
                    row = KostenTabelle.GetRow(senderTextBox);
                    break;
                default:
                    System.Console.WriteLine("Wrong Sender Typ in \"KostenRechner\".");
                    break;
            }
            foreach (ArbeitsObjekt item in ArbeitsObjektList.ArbeitsObjekte)
            {
                if (item != null)
                {
                    for (int i = 0; i < column; i++)
                    {
                        switch (KostenTabelle.GetControlFromPosition(i, row).Name.Trim(CharsToTrim))
                        // Removes the numbers from the Objectname
                        {
                            case "stueckPreis":
                                preis.Text = KostenTabelle.GetControlFromPosition(i, row).Text;
                                break;
                            case "stueckAnzahl":
                                anzahl.Text = KostenTabelle.GetControlFromPosition(i, row).Text;
                                break;
                            case "kosten":
                                /* 
                                 * System.Console.WriteLine(preis.Text + " preis");
                                 * System.Console.WriteLine(anzahl.Text + " anzahl");
                                 * System.Console.WriteLine(KostenTabelle.GetControlFromPosition(i, row).Text + " kosten");
                                 */
                                if (!String.IsNullOrEmpty(preis.Text) && !String.IsNullOrEmpty(anzahl.Text))
                                    //Checks if price and amount arent empty
                                {
                                    float total = float.Parse(preis.Text) * float.Parse(anzahl.Text);
                                    KostenTabelle.GetControlFromPosition(i, row).Text = total.ToString();
                                }
                                break;
                        }
                    }
                }
            }
        }


        /*
         * checks if the pressed Key is numeric, has maximal 1 dot and 
         * if it has 2 numbers after the dow at maximum.
         */
        public void Stueckzahl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ActiveControl != sender) 
            { 
                e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            KostenRechner(sender, e);
        }
    }
}


