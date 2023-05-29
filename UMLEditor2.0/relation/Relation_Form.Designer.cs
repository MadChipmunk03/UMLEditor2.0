namespace UMLEditor2._0.relation
{
    partial class Relation_Form
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
            this.ComboClass1 = new System.Windows.Forms.ComboBox();
            this.ComboClass2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboRelation = new System.Windows.Forms.ComboBox();
            this.ComboMulti1 = new System.Windows.Forms.ComboBox();
            this.ComboMulti2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboClass1
            // 
            this.ComboClass1.FormattingEnabled = true;
            this.ComboClass1.Location = new System.Drawing.Point(12, 60);
            this.ComboClass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboClass1.Name = "ComboClass1";
            this.ComboClass1.Size = new System.Drawing.Size(261, 38);
            this.ComboClass1.TabIndex = 0;
            // 
            // ComboClass2
            // 
            this.ComboClass2.FormattingEnabled = true;
            this.ComboClass2.Location = new System.Drawing.Point(497, 60);
            this.ComboClass2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboClass2.Name = "ComboClass2";
            this.ComboClass2.Size = new System.Drawing.Size(261, 38);
            this.ComboClass2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. třída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. třída";
            // 
            // ComboRelation
            // 
            this.ComboRelation.FormattingEnabled = true;
            this.ComboRelation.Location = new System.Drawing.Point(279, 60);
            this.ComboRelation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboRelation.Name = "ComboRelation";
            this.ComboRelation.Size = new System.Drawing.Size(212, 38);
            this.ComboRelation.TabIndex = 6;
            // 
            // ComboMulti1
            // 
            this.ComboMulti1.FormattingEnabled = true;
            this.ComboMulti1.Location = new System.Drawing.Point(139, 114);
            this.ComboMulti1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboMulti1.Name = "ComboMulti1";
            this.ComboMulti1.Size = new System.Drawing.Size(134, 38);
            this.ComboMulti1.TabIndex = 7;
            // 
            // ComboMulti2
            // 
            this.ComboMulti2.FormattingEnabled = true;
            this.ComboMulti2.Location = new System.Drawing.Point(624, 114);
            this.ComboMulti2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboMulti2.Name = "ComboMulti2";
            this.ComboMulti2.Size = new System.Drawing.Size(134, 38);
            this.ComboMulti2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Multiplicita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Multiplicita:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(494, 188);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 44);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Zrušit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(631, 188);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(130, 44);
            this.BtnOk.TabIndex = 12;
            this.BtnOk.Text = "Potvrdit";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Relace";
            // 
            // Relation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 254);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboMulti2);
            this.Controls.Add(this.ComboMulti1);
            this.Controls.Add(this.ComboRelation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboClass2);
            this.Controls.Add(this.ComboClass1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Relation_Form";
            this.Text = "Relation_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ComboClass1;
        private ComboBox ComboClass2;
        private Label label1;
        private Label label2;
        private ComboBox ComboRelation;
        private ComboBox ComboMulti1;
        private ComboBox ComboMulti2;
        private Label label4;
        private Label label5;
        private Button BtnCancel;
        private Button BtnOk;
        private Label label3;
    }
}