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
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelMouseDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.Location = new System.Drawing.Point(21, 24);
            this.BtnAddClass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(178, 46);
            this.BtnAddClass.TabIndex = 0;
            this.BtnAddClass.Text = "Přidat třídu";
            this.BtnAddClass.UseVisualStyleBackColor = true;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.SystemColors.Control;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Canvas.Location = new System.Drawing.Point(209, 24);
            this.Canvas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1148, 861);
            this.Canvas.TabIndex = 1;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDoubleClick);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(21, 119);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(74, 30);
            this.LabelX.TabIndex = 2;
            this.LabelX.Text = "LabelX";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(21, 165);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(74, 30);
            this.LabelY.TabIndex = 3;
            this.LabelY.Text = "LabelY";
            // 
            // LabelMouseDown
            // 
            this.LabelMouseDown.AutoSize = true;
            this.LabelMouseDown.Location = new System.Drawing.Point(21, 209);
            this.LabelMouseDown.Name = "LabelMouseDown";
            this.LabelMouseDown.Size = new System.Drawing.Size(179, 30);
            this.LabelMouseDown.TabIndex = 4;
            this.LabelMouseDown.Text = "LabelMouseDown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.LabelMouseDown);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.BtnAddClass);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddClass;
        private PictureBox Canvas;
        private Label LabelX;
        private Label LabelY;
        private Label LabelMouseDown;
    }
}