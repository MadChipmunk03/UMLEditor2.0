using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLEditor2._0.classTable.Parts;

namespace UMLEditor2._0.classTable
{
    public partial class Attribute_Form : Form
    {
        public ClassAttribute Attribute;

        public Attribute_Form(ClassAttribute attribute)
        {
            this.Attribute = attribute;

            InitializeComponent();

            ComboVisibility.Items.AddRange(new string[] { "Public", "Private", "Protected", "Internal" });

            this.InpName.Text = Attribute.Name;
            this.InpDataType.Text = Attribute.DataType;
            if (Attribute.Visibility == '+') this.ComboVisibility.SelectedItem = "Public";
            else if (Attribute.Visibility == '-') this.ComboVisibility.SelectedItem = "Private";
            else if (Attribute.Visibility == '*') this.ComboVisibility.SelectedItem = "Protected";
            else this.ComboVisibility.SelectedItem = "Internal"; // Default
            this.CheckStatic.Checked = Attribute.Static;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            if (!InpDataType_ValidateingTypes())
            {
                DialogResult result = MessageBox.Show($"Datový typ \"{InpDataType.Text}\" není obsažený v našem seznamu datových typů. " + 
                                                     "\nJste si jist, že je datový typ správně?", "Upozornění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
            }

            this.Attribute.Name = InpName.Text;
            this.Attribute.DataType = InpDataType.Text;
            this.Attribute.Static = CheckStatic.Checked;

            string selectedVisibility = this.ComboVisibility.SelectedItem.ToString();
            if (selectedVisibility == "Public") this.Attribute.Visibility = (char)Visibility.Public;
            else if (selectedVisibility == "Private") this.Attribute.Visibility = (char)Visibility.Private;
            else if (selectedVisibility == "Protected") this.Attribute.Visibility = (char)Visibility.Protected;
            else if (selectedVisibility == "Internal") this.Attribute.Visibility = (char)Visibility.Internal;

            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void InpName_ValidateingFirstUpper(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.InpDataType, null);
            if (!Regex.IsMatch(this.InpName.Text, @"^[A-Z].*"))
            {
                this.errorProvider.SetError(this.InpName, "Musí začínat velkým písmenem");
                e.Cancel = true;
            }
        }

        private void InpName_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.InpName, null);
            if (string.IsNullOrWhiteSpace(this.InpName.Text))
            {
                this.errorProvider.SetError(this.InpName, "Pole je povinné");
                e.Cancel = true;
            }
        }

        private bool InpDataType_ValidateingTypes()
        {
            string[] knownTypes = { "bool", "int", "string", "char", "float", "double"};
            return knownTypes.Any(InpDataType.Text.Contains);
        }

        private void InpDataType_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.InpDataType, null);
            if (string.IsNullOrWhiteSpace(this.InpDataType.Text))
            {
                this.errorProvider.SetError(this.InpDataType, "Pole je povinné");
                e.Cancel = true;
            }
        }
    }
}
