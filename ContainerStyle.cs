using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * This Class is for Styling all Containers in this Project
 */
namespace OffertenErsteller
{
    public static class ContainerStyle
    {
        public static Label StyleLabel(Label label)
        {
            label.Font = new Font("Microsoft Sans Serif", 12);
            label.Margin = new Padding(3);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Padding = new Padding(0);
            return label;
        }
        public static ComboBox StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font("Microsoft Sans Serif", 12);
            comboBox.Margin = new Padding(3);
            comboBox.Dock = DockStyle.Fill;
            comboBox.Padding = new Padding(0);
            foreach (ArbeitsObjekt item in ArbeitsObjektList.ArbeitsObjekte)
            {
                if (item != null)
                {
                    comboBox.Items.Add(item.Name);
                }
            }
            return comboBox;
        }
        public static TextBox StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Microsoft Sans Serif", 12);
            textBox.Margin = new Padding(3);
            textBox.Dock = DockStyle.Fill;
            textBox.Padding = new Padding(0);
            textBox.MaxLength = 10;
            return textBox;
        }
    }
}
