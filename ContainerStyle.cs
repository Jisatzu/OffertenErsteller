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
        private static readonly Font standardFont = new Font("Microsoft Sans Serif", 12);
        private static readonly DockStyle standardFill = DockStyle.Fill;
        private static readonly Padding standardMargin = new Padding(3);
        private static readonly Padding standardPadding = new Padding(0);
        private static readonly ContentAlignment standardAlignment = ContentAlignment.MiddleCenter;
        public static Label StyleLabel(Label label)
        {
            label.Font = standardFont;
            label.Margin = standardMargin;
            label.Dock = standardFill;
            label.TextAlign = standardAlignment;
            label.Padding = standardPadding;
            return label;
        }
        public static Button StyleButton(Button button)
        {
            button.Font = standardFont;
            button.Margin = new Padding(0);
            button.Dock = standardFill;
            button.TextAlign = standardAlignment;
            button.Padding = standardPadding;
            return button;
        }
        public static ComboBox StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = standardFont;
            comboBox.Margin = standardMargin;
            comboBox.Dock = standardFill;
            comboBox.Padding = standardPadding;
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
            textBox.Font = standardFont;
            textBox.Margin = standardMargin;
            textBox.Dock = standardFill;
            textBox.Padding = standardPadding;
            textBox.MaxLength = 10;
            return textBox;
        }
    }
}
