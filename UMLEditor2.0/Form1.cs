using UMLEditor2._0.classTable;

namespace UMLEditor2._0
{
    public partial class Form1 : Form
    {
        List<ClassMain> Classes = new List<ClassMain>();
        private int ClassesTopId { get; set; } = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            Point classCorner = new Point(this.Canvas.Width / 2, this.Canvas.Height / 2);
            Class_Form class_form = new Class_Form(new ClassMain(classCorner, ClassesTopId));

            DialogResult result = class_form.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Classes.Add(class_form.ClassMain);
                Classes[Classes.Count() - 1].CalcDimensions();
                Canvas.Refresh();
                ClassesTopId++;
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach(ClassMain classMain in Classes)
                classMain.Draw(e.Graphics);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //this.LabelX.Text = e.X.ToString();
            //this.LabelY.Text = e.Y.ToString();
            //this.LabelMouseDown.Text = e.Button.ToString();

            foreach (ClassMain classMain in Classes)
                classMain.MouseMove(e);
            Canvas.Refresh();
        }

        private void Canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(ClassMain classMain in Classes)
                if (classMain.DoubleClickedByMouse(e))
                {
                    Class_Form class_form = new Class_Form(classMain);

                    DialogResult result = class_form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Classes.Remove(classMain);
                        Classes.Add(class_form.ClassMain);
                        Classes[Classes.Count() - 1].CalcDimensions();
                        Canvas.Refresh();
                    }
                    return;
                }
        }
    }
}