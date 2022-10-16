namespace UMLEditor2._0.classTable.Forms
{
    partial class Parameter_Form
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
            this.InpDataType = new System.Windows.Forms.TextBox();
            this.InpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InpDataType
            // 
            this.InpDataType.Location = new System.Drawing.Point(103, 38);
            this.InpDataType.Margin = new System.Windows.Forms.Padding(2);
            this.InpDataType.Name = "InpDataType";
            this.InpDataType.Size = new System.Drawing.Size(180, 27);
            this.InpDataType.TabIndex = 19;
            // 
            // InpName
            // 
            this.InpName.Location = new System.Drawing.Point(103, 11);
            this.InpName.Margin = new System.Windows.Forms.Padding(2);
            this.InpName.Name = "InpName";
            this.InpName.Size = new System.Drawing.Size(180, 27);
            this.InpName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datový typ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Název:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(105, 86);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(87, 27);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Zrušit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(196, 86);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(87, 27);
            this.BtnOk.TabIndex = 20;
            this.BtnOk.Text = "Potvrdit";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // Parameter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 133);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.InpDataType);
            this.Controls.Add(this.InpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Parameter_Form";
            this.Text = "Parametr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InpDataType;
        private TextBox InpName;
        private Label label2;
        private Label label1;
        private Button BtnCancel;
        private Button BtnOk;
    }
}