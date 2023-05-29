namespace UMLEditor2._0
{
    partial class ExportCode_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InpProjectFolder = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.InpNamespace = new System.Windows.Forms.TextBox();
            this.BtnProjectFolder = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Složka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namespace:";
            // 
            // InpProjectFolder
            // 
            this.InpProjectFolder.Location = new System.Drawing.Point(145, 58);
            this.InpProjectFolder.Name = "InpProjectFolder";
            this.InpProjectFolder.Size = new System.Drawing.Size(473, 35);
            this.InpProjectFolder.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(350, 140);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(131, 40);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Zrušit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(487, 140);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(131, 40);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "Potvrdit";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // InpNamespace
            // 
            this.InpNamespace.Location = new System.Drawing.Point(145, 99);
            this.InpNamespace.Name = "InpNamespace";
            this.InpNamespace.Size = new System.Drawing.Size(473, 35);
            this.InpNamespace.TabIndex = 4;
            // 
            // BtnProjectFolder
            // 
            this.BtnProjectFolder.Location = new System.Drawing.Point(12, 12);
            this.BtnProjectFolder.Name = "BtnProjectFolder";
            this.BtnProjectFolder.Size = new System.Drawing.Size(606, 40);
            this.BtnProjectFolder.TabIndex = 0;
            this.BtnProjectFolder.Text = "Vyberte projekt solution";
            this.BtnProjectFolder.UseVisualStyleBackColor = true;
            this.BtnProjectFolder.Click += new System.EventHandler(this.BtnProjectFolder_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ExportCode_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 206);
            this.Controls.Add(this.BtnProjectFolder);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.InpNamespace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InpProjectFolder);
            this.Controls.Add(this.label1);
            this.Name = "ExportCode_Form";
            this.Text = "Save as code";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox InpProjectFolder;
        private Button BtnCancel;
        private Button BtnOk;
        private TextBox InpNamespace;
        private Button BtnProjectFolder;
        private OpenFileDialog OpenFileDialog;
        private ErrorProvider errorProvider;
    }
}