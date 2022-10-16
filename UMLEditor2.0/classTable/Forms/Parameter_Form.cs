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
    public partial class Parameter_Form : Form
    {
        public ClassMethodParameter Parameter;

        public Parameter_Form(ClassMethodParameter parameter)
        {
            Parameter = parameter;
            InitializeComponent();

            this.InpName.Text = Parameter.Name;
            this.InpDataType.Text = Parameter.DataType;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            this.Parameter.Name = InpName.Text;
            this.Parameter.DataType = InpDataType.Text;

            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
