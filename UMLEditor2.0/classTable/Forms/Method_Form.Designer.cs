namespace UMLEditor2._0.classTable.Forms
{
    partial class Method_Form
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.ComboVisibility = new System.Windows.Forms.ComboBox();
            this.CheckStatic = new System.Windows.Forms.CheckBox();
            this.InpDataType = new System.Windows.Forms.TextBox();
            this.InpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridParams = new System.Windows.Forms.DataGridView();
            this.BtnDeleteParam = new System.Windows.Forms.Button();
            this.BtnEditParam = new System.Windows.Forms.Button();
            this.BtnAddParam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(162, 448);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 40);
            this.BtnCancel.TabIndex = 19;
            this.BtnCancel.Text = "Zrušit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(298, 448);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(130, 40);
            this.BtnOk.TabIndex = 18;
            this.BtnOk.Text = "Potvrdit";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // ComboVisibility
            // 
            this.ComboVisibility.FormattingEnabled = true;
            this.ComboVisibility.Location = new System.Drawing.Point(156, 99);
            this.ComboVisibility.Name = "ComboVisibility";
            this.ComboVisibility.Size = new System.Drawing.Size(268, 38);
            this.ComboVisibility.TabIndex = 17;
            // 
            // CheckStatic
            // 
            this.CheckStatic.AutoSize = true;
            this.CheckStatic.Location = new System.Drawing.Point(402, 152);
            this.CheckStatic.Name = "CheckStatic";
            this.CheckStatic.Size = new System.Drawing.Size(22, 21);
            this.CheckStatic.TabIndex = 16;
            this.CheckStatic.UseVisualStyleBackColor = true;
            // 
            // InpDataType
            // 
            this.InpDataType.Location = new System.Drawing.Point(156, 57);
            this.InpDataType.Name = "InpDataType";
            this.InpDataType.Size = new System.Drawing.Size(268, 35);
            this.InpDataType.TabIndex = 15;
            this.InpDataType.Validating += new System.ComponentModel.CancelEventHandler(this.InpDataType_Validating);
            // 
            // InpName
            // 
            this.InpName.Location = new System.Drawing.Point(156, 16);
            this.InpName.Name = "InpName";
            this.InpName.Size = new System.Drawing.Size(268, 35);
            this.InpName.TabIndex = 14;
            this.InpName.Validating += new System.ComponentModel.CancelEventHandler(this.InpName_ValidateingFirstUpper);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Statický:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Přístup:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datový typ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Název:";
            // 
            // DataGridParams
            // 
            this.DataGridParams.AllowUserToAddRows = false;
            this.DataGridParams.AllowUserToDeleteRows = false;
            this.DataGridParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridParams.Location = new System.Drawing.Point(16, 246);
            this.DataGridParams.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridParams.Name = "DataGridParams";
            this.DataGridParams.ReadOnly = true;
            this.DataGridParams.RowHeadersWidth = 51;
            this.DataGridParams.RowTemplate.Height = 29;
            this.DataGridParams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridParams.Size = new System.Drawing.Size(412, 123);
            this.DataGridParams.TabIndex = 20;
            // 
            // BtnDeleteParam
            // 
            this.BtnDeleteParam.Location = new System.Drawing.Point(39, 378);
            this.BtnDeleteParam.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteParam.Name = "BtnDeleteParam";
            this.BtnDeleteParam.Size = new System.Drawing.Size(115, 44);
            this.BtnDeleteParam.TabIndex = 21;
            this.BtnDeleteParam.Text = "Odstranit";
            this.BtnDeleteParam.UseVisualStyleBackColor = true;
            this.BtnDeleteParam.Click += new System.EventHandler(this.BtnDeleteParam_Click);
            // 
            // BtnEditParam
            // 
            this.BtnEditParam.Location = new System.Drawing.Point(162, 377);
            this.BtnEditParam.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditParam.Name = "BtnEditParam";
            this.BtnEditParam.Size = new System.Drawing.Size(115, 44);
            this.BtnEditParam.TabIndex = 22;
            this.BtnEditParam.Text = "Upravit";
            this.BtnEditParam.UseVisualStyleBackColor = true;
            this.BtnEditParam.Click += new System.EventHandler(this.BtnEditParam_Click);
            // 
            // BtnAddParam
            // 
            this.BtnAddParam.Location = new System.Drawing.Point(285, 378);
            this.BtnAddParam.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddParam.Name = "BtnAddParam";
            this.BtnAddParam.Size = new System.Drawing.Size(115, 44);
            this.BtnAddParam.TabIndex = 23;
            this.BtnAddParam.Text = "Přidat";
            this.BtnAddParam.UseVisualStyleBackColor = true;
            this.BtnAddParam.Click += new System.EventHandler(this.BtnAddParam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(156, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 38);
            this.label5.TabIndex = 24;
            this.label5.Text = "Parametry";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Method_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAddParam);
            this.Controls.Add(this.BtnEditParam);
            this.Controls.Add(this.BtnDeleteParam);
            this.Controls.Add(this.DataGridParams);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Method_Form";
            this.Text = "Metoda";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCancel;
        private Button BtnOk;
        private ComboBox ComboVisibility;
        private CheckBox CheckStatic;
        private TextBox InpDataType;
        private TextBox InpName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView DataGridParams;
        private Button BtnDeleteParam;
        private Button BtnEditParam;
        private Button BtnAddParam;
        private Label label5;
        private ErrorProvider errorProvider;
    }
}