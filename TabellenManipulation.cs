using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffertenErsteller
{
    public class TabellenManipulation : TableLayoutPanel
    {
        
        private string[] ColumnNames;
        private string[] ColumnTypes;
        private TableLayoutPanel ManipulatedTabel;
        private int ColumnAmount;
        private int RowNumber = 0;
        bool firstTime = true;
        public TableLayoutPanel FillRow(TableLayoutPanel tabelLayoutPanel)
        {
            ManipulatedTabel = tabelLayoutPanel;
            RowNumber = ManipulatedTabel.RowCount-1;
            ManipulatedTabel.RowCount++;
            ColumnAmount = ManipulatedTabel.ColumnCount;
            ColumnNamesGetter();
            if (!firstTime)
            {
            ColumnTypeGetter();
            }
            CreateContainers();
            return ManipulatedTabel;
        }
        private void ColumnNamesGetter()
        {
            
            char[] CharsToTrim = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            ColumnNames = new string[ColumnAmount];
            for (int i = 0; i < ColumnAmount; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(ManipulatedTabel.GetControlFromPosition(i, 0).Name, "\\d"))
                {
                    ColumnNames[i] = ManipulatedTabel.GetControlFromPosition(i, 0).Name.Trim(CharsToTrim);
                }
                else
                {
                    ColumnNames[i] = ManipulatedTabel.GetControlFromPosition(i, 0).Name;
                }
            }
        }
        private void ColumnTypeGetter()
        {
            ColumnTypes = new string[ColumnAmount];
            for (int i = 0; i < ColumnAmount; i++)
            {
                ColumnTypes[i] = ManipulatedTabel.GetControlFromPosition(i, 1).GetType().ToString().Substring(21);
            }
        }
        private void CreateContainers()
        {
            if (firstTime)
            {
                int banana = 0;
                foreach (string item in ColumnNames)
                {
                    switch (item.ToLower())
                    {
                        case "pos":
                            Label l = new Label();
                            CreateLabelForTabel(l,"pos", banana++);
                            break;
                        case "name":
                            ComboBox comboBox = new ComboBox();
                            CreateComboBoxForTabel(comboBox, item, banana++);
                            break;
                        case "stueckpreis":
                            Label a = new Label();
                            CreateLabelForTabel(a, item, banana++);
                            break;
                        case "stueckanzahl":
                            TextBox textBox = new TextBox();
                            CreateTextBoxForTabel(textBox, item, banana++);
                            break;
                        case "stuecktyp":
                            Label b = new Label();
                            CreateLabelForTabel(b, item, banana++);
                            break;
                        case "kosten":
                            Label c = new Label();
                            CreateLabelForTabel(c, item, banana++);
                            break;
                        default:
                            break;
                    }
                }
                firstTime = false;
            }
            else {
                for (int i = 0; i < ColumnAmount; i++)
                {
                    switch (ManipulatedTabel.GetControlFromPosition(i, 1).GetType().ToString().Substring(21))
                    {
                        case "Label":
                            Label label = new Label();
                            CreateLabelForTabel(label, ColumnNames[i], i);
                            break;
                        case "ComboBox":
                            ComboBox comboBox = new ComboBox();
                            CreateComboBoxForTabel(comboBox, ColumnNames[i], i);
                            break;
                        case "TextBox":
                            TextBox textBox = new TextBox();
                            CreateTextBoxForTabel(textBox, ColumnNames[i], i);
                            break;
                        default:
                            System.Console.WriteLine("Error in Typ checking to create a Container");
                            break;
                    }
                } 
            }
        }
        private void CreateLabelForTabel(Label label,string name,int collumPos)
        {
            label = ContainerStyle.StyleLabel(label);
            label.Name = name + RowNumber;
            if (String.Compare(name, "pos", true) == 0)
            {
                label.Text = RowNumber.ToString();
            }
            ManipulatedTabel.Controls.Add(label, collumPos, RowNumber);
        }
        private void CreateComboBoxForTabel(ComboBox comboBox, string name, int collumPos)
        {
            comboBox = ContainerStyle.StyleComboBox(comboBox);
            comboBox.Name = name + RowNumber;
            ManipulatedTabel.Controls.Add(comboBox, collumPos, RowNumber);
            comboBox.SelectedIndexChanged += Program.form.DropDownItem_SelectetIndexChanged;
        }
        private void CreateTextBoxForTabel(TextBox textBox, string name, int collumPos)
        {
            textBox = ContainerStyle.StyleTextBox(textBox);
            textBox.Name = name + RowNumber;
            ManipulatedTabel.Controls.Add(textBox, collumPos, RowNumber);
            textBox.KeyPress += Program.form.Stueckzahl_KeyPress;
            textBox.Focus();
        }
        
    }
}
