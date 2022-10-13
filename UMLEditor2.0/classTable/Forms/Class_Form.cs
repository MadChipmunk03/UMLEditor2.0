using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLEditor2._0.classTable.Parts;

namespace UMLEditor2._0.classTable
{
    public partial class Class_Form : Form
    {
        public ClassMain ClassMain = new ClassMain(new Point(0, 0));
        public Class_Form(ClassMain classMain)
        {
            InitializeComponent();
            ClassMain = classMain;

            this.DataGridAttr.AutoGenerateColumns = false;
            this.DataGridAttr.DataSource = this.ClassMain.Attributes;
            this.DataGridMeth.AutoGenerateColumns = false;
            this.DataGridMeth.DataSource = this.ClassMain.Methods;

            ComboVisibility.Items.AddRange(new string[] {"Public", "Private", "Protected", "Package"});

            this.InpName.Text = ClassMain.Title.Text;
            if (ClassMain.Visibility == '+') this.ComboVisibility.SelectedItem = "Public";
            else if (ClassMain.Visibility == '-') this.ComboVisibility.SelectedItem = "Private";
            else if (ClassMain.Visibility == '*') this.ComboVisibility.SelectedItem = "Protected";
            else this.ComboVisibility.SelectedItem = "Package"; // Default
            this.CheckStatic.Checked = ClassMain.Static;

            ClassMain.Attributes.Add(new ClassAttribute() { Name = "Attribute1", Static = false, Visibility = (char)Visibility.Private , DataType = "int"});
            ClassMain.Attributes.Add(new ClassAttribute() { Name = "Attr2", Static = true, Visibility = (char)Visibility.Public, DataType = "string" });
        }

        private void BtnDeleteAttribute_Click(object sender, EventArgs e)
        {
            if (this.DataGridAttr.CurrentRow == null) return;

            ClassAttribute selAttribute = this.DataGridAttr.CurrentRow.DataBoundItem as ClassAttribute;
            this.ClassMain.Attributes.Remove(selAttribute);
        }

        private void BtnEditAttribute_Click(object sender, EventArgs e)
        {
            if (this.DataGridAttr.CurrentRow == null) return;

            ClassAttribute selAttribute = this.DataGridAttr.CurrentRow.DataBoundItem as ClassAttribute;
            Attribute_Form attribute_Form = new Attribute_Form(selAttribute);
            DialogResult result = attribute_Form.ShowDialog();

            if (result == DialogResult.OK)
                selAttribute = attribute_Form.Attribute;
        }

        private void BtnAddAttr_Click(object sender, EventArgs e)
        {
            Attribute_Form attribute_Form = new Attribute_Form(new ClassAttribute());
            DialogResult result = attribute_Form.ShowDialog();

            if(result == DialogResult.OK)
                this.ClassMain.Attributes.Add(attribute_Form.Attribute);
        }

        private void BtnDeleteMeth_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditMeth_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddMeth_Click(object sender, EventArgs e)
        {

        }

        private void CheckStatic_Click(object sender, EventArgs e)
        {
            this.ClassMain.Static = !this.ClassMain.Static;
        }

        private void ComboVisibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVisibility = this.ComboVisibility.SelectedItem.ToString();
            if (selectedVisibility == "Public") this.ClassMain.Visibility = (char)Visibility.Public;
            else if (selectedVisibility == "Private") this.ClassMain.Visibility = (char)Visibility.Private;
            else if (selectedVisibility == "Protected") this.ClassMain.Visibility = (char)Visibility.Protected;
            else if (selectedVisibility == "Package") this.ClassMain.Visibility = (char)Visibility.Package;
        }

        private void InpName_TextChanged(object sender, EventArgs e)
        {
            this.ClassMain.Title.Text = InpName.Text;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
