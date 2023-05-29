using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLEditor2._0
{
    public partial class ExportCode_Form : Form
    {
        public string Folder { get; set; }
        public string Namespace { get; set; }

        public ExportCode_Form()
        {
            InitializeComponent();
        }

        private void BtnProjectFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Visual Studio solution|*.sln";
            DialogResult result = OpenFileDialog.ShowDialog();
            Namespace = OpenFileDialog.FileName.Split('\\')[OpenFileDialog.FileName.Split('\\').Length - 2];
            Folder = String.Join("\\", OpenFileDialog.FileName.Split('\\').Where(f => !f.Contains("."))) + '\\' + Namespace.Split('.')[0];

            InpProjectFolder.Text = Folder;
            InpNamespace.Text = Namespace;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Folder);
            if (dirInfo.Exists)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show($"Zadaná cesta '{Folder}' neexistuje.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //private void InpProjectFolder_Validating(object sender, CancelEventArgs e)
        //{
        //    this.errorProvider.SetError(InpProjectFolder, null);
        //    if (string.IsNullOrWhiteSpace(InpProjectFolder.Text))
        //    {
        //        this.errorProvider.SetError(this.InpProjectFolder, "Pole je povinné");
        //        e.Cancel = true;
        //    }
        //    else if (new DirectoryInfo(InpProjectFolder.Text).Exists!)
        //    {
        //        this.errorProvider.SetError(this.InpProjectFolder, "Zadaná cesta neexistuje");
        //        e.Cancel = true;
        //    }
        //}

        //private void InpNamespace_Validating(object sender, CancelEventArgs e)
        //{
        //    this.errorProvider.SetError(this.InpNamespace, null);
        //    if (string.IsNullOrWhiteSpace(this.InpNamespace.Text))
        //    {
        //        this.errorProvider.SetError(this.InpNamespace, "Pole je povinné");
        //        e.Cancel = true;
        //    }
        //}
    }
}
