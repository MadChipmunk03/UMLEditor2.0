using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using UMLEditor2._0.classTable;
using UMLEditor2._0.relation;

namespace UMLEditor2._0
{
    public partial class Form1 : Form
    {
        List<ClassMain> Classes = new List<ClassMain>();
        List<RelationMain> Relations = new List<RelationMain>();

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

        private void BtnAddRelation_Click(object sender, EventArgs e)
        {
            if(Classes.Count() < 2)
            {
                MessageBox.Show($"Není dostatek vytvoøených tøíd pro vytvoøení relace", "Upozornìní", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Relation_Form relation_form = new Relation_Form(new RelationMain(), Classes);

            DialogResult result = relation_form.ShowDialog();
            if(result == DialogResult.OK)
            {
                Relations.Add(relation_form.RelationMain);
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDiagramPart diagramPart in Relations)
                diagramPart.Draw(e.Graphics);
            foreach (IDiagramPart diagramPart in Classes)
                diagramPart.Draw(e.Graphics);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (ClassMain classMain in Classes)
                classMain.MouseMove(e);
            Canvas.Refresh();
        }

        private void Canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(ClassMain classMain in Classes)
                if (classMain.DoubleClickedByMouse(e))
                {
                    Class_Form class_form = new Class_Form(classMain, false);

                    DialogResult result = class_form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Classes.Remove(classMain);
                        Classes.Add(class_form.ClassMain);
                        Classes[Classes.Count() - 1].CalcDimensions();
                        Canvas.Refresh();
                    }
                    else if (result == DialogResult.Cancel) //DialogResult.Delete
                    {
                        foreach(RelationMain relation in Relations.Where(rel => rel.Sockets[0].ClassMain == classMain 
                                                                             || rel.Sockets[1].ClassMain == classMain).ToList())
                            Relations.Remove(relation);
                        Classes.Remove(classMain);
                    }
                    return;
                }
            foreach(RelationMain relation in Relations)
            {
                if (relation.DoubleClickedByMouse(e))
                {
                    Relation_Form relation_form = new Relation_Form(relation, Classes, false);

                    DialogResult result = relation_form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Relations.Remove(relation);
                        Relations.Add(relation_form.RelationMain);
                        Canvas.Refresh();
                    }
                    else if (result == DialogResult.Cancel) //DialogResult.Delete
                    {
                        Relations.Remove(relation);
                    }
                    return;
                }
            }
        }

        private void BtnExportImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            DialogResult result = SaveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = SaveFileDialog.FileName;
                Bitmap bmp = new Bitmap(Canvas.ClientSize.Width, Canvas.ClientSize.Height);
                Canvas.DrawToBitmap(bmp, Canvas.ClientRectangle);
                bmp.Save(fileName);

                MessageBox.Show($"Obrázek '{fileName.Split('\\')[fileName.Split('\\').Length - 1]}' byl úspìšnì uložen.");
            }
        }

        private void BtnExportCode_Click(object sender, EventArgs e)
        {
            ExportCode_Form exportCode_Form = new ExportCode_Form();
            DialogResult result = exportCode_Form.ShowDialog();
            if(result == DialogResult.OK)
            {
                CodeGenerator cg = new CodeGenerator(exportCode_Form.Folder, exportCode_Form.Namespace);
                cg.Generate(Classes, Relations);
                MessageBox.Show("Export do kódu byl proveden úspìšnì!");
            }
        }
    }
}