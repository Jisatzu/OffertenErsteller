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
        private char[] CharsToTrim = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private string[] ColumnNames; //saves all column base names
        private string[] ColumnTypes; //saves all column types from interactalbe rows
        private TableLayoutPanel ManipulatedTabel; //creates a new tabel to be filled and returned
        private int ColumnAmount; //the maximum amount of columns in the table
        private int RowNumber = 0; // number to create the name of the controll box
        private bool emptyRows = true;
        
        
        /*
         * creates a row and add's it to the table
         * currently has to check if it's the first time to create a row or not since i currently get errors 
         * that i cant deal with currently if i try to initalise the first row automaticly and not with the
         * tools given by VS
         */
        public TableLayoutPanel FillRow(TableLayoutPanel tabelLayoutPanel)
        {
            ManipulatedTabel = tabelLayoutPanel;
            RowNumber = ManipulatedTabel.RowCount;
            ColumnAmount = ManipulatedTabel.ColumnCount;
            ColumnNamesGetter();
            if (ManipulatedTabel.RowCount > 1)
            {
                ColumnTypeGetter();
            }
            ManipulatedTabel.RowCount++;
            CreateContainers(emptyRows);
            return ManipulatedTabel;
        }

        /*
         * fills the ColumnNames with all column names available
         */
        private void ColumnNamesGetter()
        {
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

        /*
         * fills the ColumnTypes with all column types available
         */
        private void ColumnTypeGetter()
        {
            ColumnTypes = new string[ColumnAmount];
            for (int i = 0; i < ColumnAmount; i++)
            {
                //Console.WriteLine(i + " this is I");
                //Console.WriteLine(RowNumber + " this is the Rownumber");
                //Console.WriteLine(RowNumber-1 + " this is the Rownumber but -1");
                ColumnTypes[i] = ManipulatedTabel.GetControlFromPosition(i, RowNumber -1 ).GetType().ToString().Substring(21);
            }
        }

        /*
         * Creates the containers that will be filled into the new row
         */
        private void CreateContainers(bool emptyRows)
        {
            if (emptyRows)
            // creates the containers for the first time
            {
                int banana = 0;
                foreach (string item in ColumnNames)
                {
                    switch (item.ToLower())
                    {
                        case "pos":
                            Label posLabel = new Label();
                            CreateLabelForTabel(posLabel, "pos", banana++);
                            break;
                        case "name":
                            ComboBox comboBox = new ComboBox();
                            CreateComboBoxForTabel(comboBox, item, banana++);
                            break;
                        case "stueckpreis":
                            Label stueckPreisLabel = new Label();
                            CreateLabelForTabel(stueckPreisLabel, item, banana++);
                            break;
                        case "stueckanzahl":
                            TextBox textBox = new TextBox();
                            CreateTextBoxForTabel(textBox, item, banana++);
                            break;
                        case "stuecktyp":
                            Label stueckTypLabel = new Label();
                            CreateLabelForTabel(stueckTypLabel, item, banana++);
                            break;
                        case "kosten":
                            Label kostenLabel = new Label();
                            CreateLabelForTabel(kostenLabel, item, banana++);
                            break;
                        case "loeschen":
                            Button loeschButton = new Button();
                            CreateButtonForTable(loeschButton, item, banana++);
                            break;
                        default:
                            break;
                    }
                }
                emptyRows = false;
            }
            else {
                for (int i = 0; i < ColumnAmount; i++)
                    //Copys all Containers from the first row into the new row
                    //depending on container name
                {
                    switch (ManipulatedTabel.GetControlFromPosition(i, 0).GetType().ToString().Substring(21))
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
                        case "Button":
                            Button button = new Button();
                            CreateButtonForTable(button, ColumnNames[i], i);
                            break;
                        default:
                            System.Console.WriteLine("Error in Typ checking to create a Container");
                            break;
                    }
                } 
            }
        }

        /*
         * Creates the Label Containers for the Row
         */
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

        /*
         * Creates the ComboBox Containers for the Row
         */
        private void CreateComboBoxForTabel(ComboBox comboBox, string name, int collumPos)
        {
            comboBox = ContainerStyle.StyleComboBox(comboBox);
            comboBox.Name = name + RowNumber;
            ManipulatedTabel.Controls.Add(comboBox, collumPos, RowNumber);
            comboBox.SelectedIndexChanged += Program.form.DropDownItem_SelectetIndexChanged;
        }

        /*
         * Creates the TextBox Containers for the Row
         */
        private void CreateTextBoxForTabel(TextBox textBox, string name, int collumPos)
        {
            textBox = ContainerStyle.StyleTextBox(textBox);
            textBox.Name = name + RowNumber;
            ManipulatedTabel.Controls.Add(textBox, collumPos, RowNumber);
            textBox.KeyPress += Program.form.Stueckzahl_KeyPress;
            textBox.Focus();
        }
        
        /*
         *  Creates the Button for the Table to delet a row
         */
        private void CreateButtonForTable(Button button, string name, int collumPos)
        {
            button = ContainerStyle.StyleButton(button);
            button.Name = name + RowNumber;
            button.Text = "X";
            ManipulatedTabel.Controls.Add(button,collumPos,RowNumber);
            button.MouseClick += Program.form.ReiheEntfernen_MouseKlick;
        }

        /*
         * This Method removes a row where the button was pressed.
         */
        public TableLayoutPanel RemoveRowFromTabel(int selectedRowToDelet, TableLayoutPanel tabelLayoutPanel)
        {
            TableLayoutPanel tlp = tabelLayoutPanel;
            for (int r = 1; r < tlp.RowCount; r++)
            {
                for (int c = 0; c < tlp.ColumnCount - 1; c++)
                {
                    /*
                     * checks if the row that want to be deleted was reached
                     * 
                     */
                    if (r == selectedRowToDelet)
                    {
                        /*
                         * this part checks where the end of the table.
                         * it then removes all controls from the last row and then the row itself
                         */
                        if (tlp.GetControlFromPosition(c + 1, r + 1) == null)
                        {
                            for (int i = 0; i < tlp.ColumnCount; i++)
                            {
                                tlp.Controls.Remove(tlp.GetControlFromPosition(i, r));
                            }
                            tlp.RowCount -= 1;
                            break;
                        }
                        /*
                         * this part removes the control from the row 
                         * then copys the controll from the next row into the current row
                         * it then sets all names into the propper naming to avoid bugs later on
                         */
                        else
                        {
                            tlp.Controls.Remove(tlp.GetControlFromPosition(c, r));
                            tlp.Controls.Add(tlp.GetControlFromPosition(c, r + 1), c, r);
                            string name = tlp.GetControlFromPosition(c, r).Name.Trim(CharsToTrim);
                            tlp.GetControlFromPosition(c, r).Name = name + r;
                            if (String.Compare(name, "pos", true) == 0)
                            {
                                tlp.GetControlFromPosition(c, r).Text = r.ToString();
                            }
                        }
                        selectedRowToDelet++;
                    }
                }
            }
            tabelLayoutPanel = tlp;
            return tabelLayoutPanel;
        }

        /*
         * this method is used to copy the row below the delted row to the upper one, so that i can
         * remove the row with a simple rowcount reduction
         */
        private TableLayoutPanel CopyRowToOneAbove(TableLayoutPanel tableLayoutPanel)
        {
            for (int r = 1; r < tableLayoutPanel.RowCount; r++)
            {
                Console.WriteLine(r + " this is r and the RowCount " + tableLayoutPanel.RowCount);
                for (int c = 0;  c < tableLayoutPanel.ColumnCount -1 ; c++)
                {
                    Console.WriteLine(c + " this is c and the ColumnAmount " + tableLayoutPanel.ColumnCount);
                    if (tableLayoutPanel.GetControlFromPosition(c, r) == null)
                    {
                        tableLayoutPanel.Controls.Add(tableLayoutPanel.GetControlFromPosition(c + 1, r + 1),c,r);
                        string name = tableLayoutPanel.GetControlFromPosition(c, r).Name.Trim(CharsToTrim);
                        tableLayoutPanel.GetControlFromPosition(c, r).Name = name + r;
                        if (String.Compare(name, "pos", true) == 0)
                        {
                            tableLayoutPanel.GetControlFromPosition(c, r).Text = r.ToString();
                        }
                        /*
                         * currently this method doesn't copy the values of the next row into the current row
                         * this is work in progress and does currently nothing but it should copy the values from the row below to the current row
                         * 
                         * 
                        if (String.IsNullOrEmpty(tableLayoutPanel.GetControlFromPosition(c, r + 1).Text))
                        {
                            tableLayoutPanel.GetControlFromPosition(c, r).Text = tableLayoutPanel.GetControlFromPosition(c, r + 1).Text;
                        }
                        */
                    }
                }
            }
            return tableLayoutPanel;
        }
    }
}
