using UMLEditor2._0.classTable;

namespace UMLEditor2._0
{
    public partial class Form1 : Form
    {
        List<ClassMain> Classes = new List<ClassMain>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            Point classCorner = new Point(this.Canvas.Width / 2, this.Canvas.Height / 2);
            Class_Form class_form = new Class_Form(new ClassMain(classCorner));

            DialogResult result = class_form.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Classes.Add(class_form.ClassMain);
                Classes[Classes.Count() - 1].CalcMinWidth();
                Canvas.Refresh();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach(ClassMain classMain in Classes)
                classMain.Draw(e.Graphics);
        }
    }
}