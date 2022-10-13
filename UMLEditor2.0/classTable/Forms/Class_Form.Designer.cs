namespace UMLEditor2._0.classTable
{
    partial class Class_Form
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
            this.InpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboVisibility = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridAttr = new System.Windows.Forms.DataGridView();
            this.BtnDeleteAttribute = new System.Windows.Forms.Button();
            this.BtnEditAttribute = new System.Windows.Forms.Button();
            this.BtnAddAttr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddMeth = new System.Windows.Forms.Button();
            this.BtnEditMeth = new System.Windows.Forms.Button();
            this.BtnDeleteMeth = new System.Windows.Forms.Button();
            this.DataGridMeth = new System.Windows.Forms.DataGridView();
            this.CheckStatic = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAttr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMeth)).BeginInit();
            this.SuspendLayout();
            // 
            // InpName
            // 
            this.InpName.Location = new System.Drawing.Point(18, 74);
            this.InpName.Margin = new System.Windows.Forms.Padding(4);
            this.InpName.Name = "InpName";
            this.InpName.Size = new System.Drawing.Size(439, 35);
            this.InpName.TabIndex = 0;
            this.InpName.TextChanged += new System.EventHandler(this.InpName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Název třídy:";
            // 
            // ComboVisibility
            // 
            this.ComboVisibility.FormattingEnabled = true;
            this.ComboVisibility.Location = new System.Drawing.Point(720, 22);
            this.ComboVisibility.Margin = new System.Windows.Forms.Padding(4);
            this.ComboVisibility.Name = "ComboVisibility";
            this.ComboVisibility.Size = new System.Drawing.Size(224, 38);
            this.ComboVisibility.TabIndex = 2;
            this.ComboVisibility.SelectedIndexChanged += new System.EventHandler(this.ComboVisibility_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Přístup:";
            // 
            // DataGridAttr
            // 
            this.DataGridAttr.AllowUserToAddRows = false;
            this.DataGridAttr.AllowUserToDeleteRows = false;
            this.DataGridAttr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridAttr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAttr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Text});
            this.DataGridAttr.Location = new System.Drawing.Point(18, 206);
            this.DataGridAttr.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridAttr.Name = "DataGridAttr";
            this.DataGridAttr.ReadOnly = true;
            this.DataGridAttr.RowHeadersVisible = false;
            this.DataGridAttr.RowHeadersWidth = 51;
            this.DataGridAttr.RowTemplate.Height = 29;
            this.DataGridAttr.Size = new System.Drawing.Size(441, 399);
            this.DataGridAttr.TabIndex = 4;
            // 
            // BtnDeleteAttribute
            // 
            this.BtnDeleteAttribute.Location = new System.Drawing.Point(18, 614);
            this.BtnDeleteAttribute.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteAttribute.Name = "BtnDeleteAttribute";
            this.BtnDeleteAttribute.Size = new System.Drawing.Size(141, 44);
            this.BtnDeleteAttribute.TabIndex = 5;
            this.BtnDeleteAttribute.Text = "Smazat";
            this.BtnDeleteAttribute.UseVisualStyleBackColor = true;
            this.BtnDeleteAttribute.Click += new System.EventHandler(this.BtnDeleteAttribute_Click);
            // 
            // BtnEditAttribute
            // 
            this.BtnEditAttribute.Location = new System.Drawing.Point(168, 614);
            this.BtnEditAttribute.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditAttribute.Name = "BtnEditAttribute";
            this.BtnEditAttribute.Size = new System.Drawing.Size(141, 44);
            this.BtnEditAttribute.TabIndex = 6;
            this.BtnEditAttribute.Text = "Upravit";
            this.BtnEditAttribute.UseVisualStyleBackColor = true;
            this.BtnEditAttribute.Click += new System.EventHandler(this.BtnEditAttribute_Click);
            // 
            // BtnAddAttr
            // 
            this.BtnAddAttr.Location = new System.Drawing.Point(318, 614);
            this.BtnAddAttr.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddAttr.Name = "BtnAddAttr";
            this.BtnAddAttr.Size = new System.Drawing.Size(141, 44);
            this.BtnAddAttr.TabIndex = 7;
            this.BtnAddAttr.Text = "Přidat";
            this.BtnAddAttr.UseVisualStyleBackColor = true;
            this.BtnAddAttr.Click += new System.EventHandler(this.BtnAddAttr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(164, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vlastnosti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(656, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Metody";
            // 
            // BtnAddMeth
            // 
            this.BtnAddMeth.Location = new System.Drawing.Point(806, 614);
            this.BtnAddMeth.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddMeth.Name = "BtnAddMeth";
            this.BtnAddMeth.Size = new System.Drawing.Size(141, 44);
            this.BtnAddMeth.TabIndex = 12;
            this.BtnAddMeth.Text = "Přidat";
            this.BtnAddMeth.UseVisualStyleBackColor = true;
            this.BtnAddMeth.Click += new System.EventHandler(this.BtnAddMeth_Click);
            // 
            // BtnEditMeth
            // 
            this.BtnEditMeth.Location = new System.Drawing.Point(656, 614);
            this.BtnEditMeth.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditMeth.Name = "BtnEditMeth";
            this.BtnEditMeth.Size = new System.Drawing.Size(141, 44);
            this.BtnEditMeth.TabIndex = 11;
            this.BtnEditMeth.Text = "Upravit";
            this.BtnEditMeth.UseVisualStyleBackColor = true;
            this.BtnEditMeth.Click += new System.EventHandler(this.BtnEditMeth_Click);
            // 
            // BtnDeleteMeth
            // 
            this.BtnDeleteMeth.Location = new System.Drawing.Point(506, 614);
            this.BtnDeleteMeth.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteMeth.Name = "BtnDeleteMeth";
            this.BtnDeleteMeth.Size = new System.Drawing.Size(141, 44);
            this.BtnDeleteMeth.TabIndex = 10;
            this.BtnDeleteMeth.Text = "Smazat";
            this.BtnDeleteMeth.UseVisualStyleBackColor = true;
            this.BtnDeleteMeth.Click += new System.EventHandler(this.BtnDeleteMeth_Click);
            // 
            // DataGridMeth
            // 
            this.DataGridMeth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridMeth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMeth.Location = new System.Drawing.Point(506, 206);
            this.DataGridMeth.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridMeth.Name = "DataGridMeth";
            this.DataGridMeth.RowHeadersVisible = false;
            this.DataGridMeth.RowHeadersWidth = 51;
            this.DataGridMeth.RowTemplate.Height = 29;
            this.DataGridMeth.Size = new System.Drawing.Size(441, 399);
            this.DataGridMeth.TabIndex = 9;
            // 
            // CheckStatic
            // 
            this.CheckStatic.AutoSize = true;
            this.CheckStatic.Location = new System.Drawing.Point(920, 82);
            this.CheckStatic.Margin = new System.Windows.Forms.Padding(4);
            this.CheckStatic.Name = "CheckStatic";
            this.CheckStatic.Size = new System.Drawing.Size(22, 21);
            this.CheckStatic.TabIndex = 15;
            this.CheckStatic.UseVisualStyleBackColor = true;
            this.CheckStatic.Click += new System.EventHandler(this.CheckStatic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Statická";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(806, 703);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(141, 40);
            this.BtnOk.TabIndex = 17;
            this.BtnOk.Text = "Potvrdit";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(656, 703);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 40);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Zrušit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "Název";
            this.Text.MinimumWidth = 9;
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 755);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckStatic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddMeth);
            this.Controls.Add(this.BtnEditMeth);
            this.Controls.Add(this.BtnDeleteMeth);
            this.Controls.Add(this.DataGridMeth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddAttr);
            this.Controls.Add(this.BtnEditAttribute);
            this.Controls.Add(this.BtnDeleteAttribute);
            this.Controls.Add(this.DataGridAttr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboVisibility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InpName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Class_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAttr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMeth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InpName;
        private Label label1;
        private ComboBox ComboVisibility;
        private Label label2;
        private DataGridView DataGridAttr;
        private Button BtnDeleteAttribute;
        private Button BtnEditAttribute;
        private Button BtnAddAttr;
        private Label label3;
        private Label label4;
        private Button BtnAddMeth;
        private Button BtnEditMeth;
        private Button BtnDeleteMeth;
        private DataGridView DataGridMeth;
        private CheckBox CheckStatic;
        private Label label5;
        private Button BtnOk;
        private Button BtnCancel;
        private DataGridViewTextBoxColumn Text;
    }
}