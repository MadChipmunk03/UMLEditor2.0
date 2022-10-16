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

namespace UMLEditor2._0.classTable.Forms
{
    public partial class Method_Form : Form
    {
        public ClassMethod Method;

        public Method_Form(ClassMethod attribute)
        {
            this.Method = attribute;

            InitializeComponent();

            ComboVisibility.Items.AddRange(new string[] { "Public", "Private", "Protected", "Package" });

            this.InpName.Text = Method.Text;
            this.InpDataType.Text = Method.DataType;
            if (Method.Visibility == '+') this.ComboVisibility.SelectedItem = "Public";
            else if (Method.Visibility == '-') this.ComboVisibility.SelectedItem = "Private";
            else if (Method.Visibility == '*') this.ComboVisibility.SelectedItem = "Protected";
            else this.ComboVisibility.SelectedItem = "Package"; // Default
            this.CheckStatic.Checked = Method.Static;
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

            this.Method.Text = InpName.Text;
            this.Method.DataType = InpDataType.Text;
            this.Method.Static = CheckStatic.Checked;

            string selectedVisibility = this.ComboVisibility.SelectedItem.ToString();
            if (selectedVisibility == "Public") this.Method.Visibility = (char)Visibility.Public;
            else if (selectedVisibility == "Private") this.Method.Visibility = (char)Visibility.Private;
            else if (selectedVisibility == "Protected") this.Method.Visibility = (char)Visibility.Protected;
            else if (selectedVisibility == "Package") this.Method.Visibility = (char)Visibility.Package;

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
            string[] knownTypes = { "bool", "int", "string", "char", "float", "double" };
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
