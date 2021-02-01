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

        private void Bearbeiten_Click(object sender, EventArgs e)
        {
            KostenTabelle = Program.Tm.FillRow(KostenTabelle);
        }
        public void DropDownItem_SelectetIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Control control = comboBox;
            int row = KostenTabelle.GetRow(control);
            int column = KostenTabelle.ColumnCount;
            foreach (ArbeitsObjekt item in ArbeitsObjektList.ArbeitsObjekte)
            {
                if (item != null)
                {
                    if (String.Equals(comboBox.SelectedItem.ToString(), item.Name))
                    {
                        for (int i = 1; i < column; i++)
                        {
                            if(item != null){
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
            }
            KostenRechner(sender,e);
        }

        private void KostenRechner(object sender, EventArgs e)
        {
            int row = 0;
            int column = KostenTabelle.ColumnCount;
            Label preis = new Label();
            Label anzahl = new Label();
            Label kosten = new Label();
            switch (sender.GetType().ToString().Substring(21))
            {
                case "ComboBox":
                    ComboBox senderComboBox = (ComboBox)sender;
                    row = KostenTabelle.GetRow(senderComboBox);
                    break;
                case "TextBox":
                    TextBox senderTextBox = (TextBox)sender;
                    row = KostenTabelle.GetRow(senderTextBox);
                    break;
                case "Label":
                    Label senderLabel = (Label)sender;
                    row = KostenTabelle.GetRow(senderLabel);
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
                        //System.Console.WriteLine(KostenTabelle.GetControlFromPosition(i, row).Name.Trim(CharsToTrim));
                        switch (KostenTabelle.GetControlFromPosition(i, row).Name.Trim(CharsToTrim))
                        {
                            case "stueckPreis":
                                preis.Text = KostenTabelle.GetControlFromPosition(i, row).Text;
                                break;
                            case "stueckAnzahl":
                                anzahl.Text = KostenTabelle.GetControlFromPosition(i, row).Text;
                                break;
                            case "kosten":
                                System.Console.WriteLine(preis.Text + " preis");
                                System.Console.WriteLine(anzahl.Text + " anzahl");
                                System.Console.WriteLine(KostenTabelle.GetControlFromPosition(i, row).Text + " kosten");
                                kosten.Text = KostenTabelle.GetControlFromPosition(i, row).Text;
                                if (!String.IsNullOrEmpty(preis.Text) && !String.IsNullOrEmpty(anzahl.Text))
                                {
                                    float total = float.Parse(preis.Text) * float.Parse(anzahl.Text);
                                    kosten.Text = total.ToString();
                                }
                                KostenTabelle.GetControlFromPosition(i, row).Text = kosten.Text;
                                break;
                        }
                    }
                }
            }
        }

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


