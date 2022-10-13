namespace UMLEditor2._0.classTable
{
    partial class Attribute_Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InpName = new System.Windows.Forms.TextBox();
            this.InpDataType = new System.Windows.Forms.TextBox();
            this.CheckStatic = new System.Windows.Forms.CheckBox();
            this.ComboVisibility = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datový typ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Přístup:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Statický:";
            // 
            // InpName
            // 
            this.InpName.Location = new System.Drawing.Point(154, 12);
            this.InpName.Name = "InpName";
            this.InpName.Size = new System.Drawing.Size(268, 35);
            this.InpName.TabIndex = 4;
            this.InpName.Validating += new System.ComponentModel.CancelEventHandler(this.InpName_ValidateingFirstUpper);
            // 
            // InpDataType
            // 
            this.InpDataType.Location = new System.Drawing.Point(154, 53);
            this.InpDataType.Name = "InpDataType";
            this.InpDataType.Size = new System.Drawing.Size(268, 35);
            this.InpDataType.TabIndex = 5;
            this.InpDataType.Validating += new System.ComponentModel.CancelEventHandler(this.InpDataType_Validating);
            // 
            // CheckStatic
            // 
            this.CheckStatic.AutoSize = true;
            this.CheckStatic.Location = new System.Drawing.Point(400, 147);
            this.CheckStatic.Name = "CheckStatic";
            this.CheckStatic.Size = new System.Drawing.Size(22, 21);
            this.CheckStatic.TabIndex = 6;
            this.CheckStatic.UseVisualStyleBackColor = true;
            // 
            // ComboVisibility
            // 
            this.ComboVisibility.FormattingEnabled = true;
            this.ComboVisibility.Location = new System.Drawing.Point(154, 94);
            this.ComboVisibility.Name = "ComboVisibility";
            this.ComboVisibility.Size = new System.Drawing.Size(268, 38);
            this.ComboVisibility.TabIndex = 7;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(291, 213);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(131, 40);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "Potvrdit";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(154, 213);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(131, 40);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Zrušit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Attribute_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 272);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.ComboVisibility);
            this.Controls.Add(this.CheckStatic);
            this.Controls.Add(this.InpDataType);
            this.Controls.Add(this.InpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Attribute_Form";
            this.Text = "Vlastnost";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox InpName;
        private TextBox InpDataType;
        private CheckBox CheckStatic;
        private ComboBox ComboVisibility;
        private Button BtnOk;
        private Button BtnCancel;
        private ErrorProvider errorProvider;
    }
}