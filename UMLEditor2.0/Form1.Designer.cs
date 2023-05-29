namespace UMLEditor2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAddClass = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.BtnAddRelation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExportImage = new System.Windows.Forms.Button();
            this.BtnExportCode = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddClass.Location = new System.Drawing.Point(29, 76);
            this.BtnAddClass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(178, 46);
            this.BtnAddClass.TabIndex = 0;
            this.BtnAddClass.Text = "Třídu";
            this.BtnAddClass.UseVisualStyleBackColor = false;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.SystemColors.Control;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Canvas.Location = new System.Drawing.Point(235, 24);
            this.Canvas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1121, 860);
            this.Canvas.TabIndex = 1;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDoubleClick);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            // 
            // BtnAddRelation
            // 
            this.BtnAddRelation.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddRelation.Location = new System.Drawing.Point(29, 134);
            this.BtnAddRelation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddRelation.Name = "BtnAddRelation";
            this.BtnAddRelation.Size = new System.Drawing.Size(178, 46);
            this.BtnAddRelation.TabIndex = 2;
            this.BtnAddRelation.Text = "Relaci";
            this.BtnAddRelation.UseVisualStyleBackColor = false;
            this.BtnAddRelation.Click += new System.EventHandler(this.BtnAddRelation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Přidat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uložit jako:";
            // 
            // BtnExportImage
            // 
            this.BtnExportImage.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExportImage.Location = new System.Drawing.Point(29, 296);
            this.BtnExportImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnExportImage.Name = "BtnExportImage";
            this.BtnExportImage.Size = new System.Drawing.Size(178, 46);
            this.BtnExportImage.TabIndex = 5;
            this.BtnExportImage.Text = "Obrázek";
            this.BtnExportImage.UseVisualStyleBackColor = false;
            this.BtnExportImage.Click += new System.EventHandler(this.BtnExportImage_Click);
            // 
            // BtnExportCode
            // 
            this.BtnExportCode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExportCode.Location = new System.Drawing.Point(29, 354);
            this.BtnExportCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnExportCode.Name = "BtnExportCode";
            this.BtnExportCode.Size = new System.Drawing.Size(178, 46);
            this.BtnExportCode.TabIndex = 6;
            this.BtnExportCode.Text = "Kód";
            this.BtnExportCode.UseVisualStyleBackColor = false;
            this.BtnExportCode.Click += new System.EventHandler(this.BtnExportCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.BtnExportCode);
            this.Controls.Add(this.BtnExportImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddRelation);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.BtnAddClass);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "UML Editor Lite 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddClass;
        private PictureBox Canvas;
        private Button BtnAddRelation;
        private Label label1;
        private Label label2;
        private Button BtnExportImage;
        private Button BtnExportCode;
        private SaveFileDialog SaveFileDialog;
    }
}