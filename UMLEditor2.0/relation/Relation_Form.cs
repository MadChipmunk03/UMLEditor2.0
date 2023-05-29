using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLEditor2._0.classTable;
using UMLEditor2._0.relation.Parts;

namespace UMLEditor2._0.relation
{
    public partial class Relation_Form : Form
    {
        public RelationMain RelationMain = new RelationMain();
        private List<ClassMain> Classes = new List<ClassMain>();

        public Relation_Form(RelationMain relationMain, List<ClassMain> classes, bool isNew = true)
        {
            InitializeComponent();
            RelationMain = relationMain;
            Classes = classes;
            if (!isNew) BtnCancel.Text = "Odstranit";

            string[] classNames = new string[classes.Count()];
            for (int i = 0; i < classes.Count; i++)
                classNames[i] = classes[i].Title.Text;
            ComboClass1.Items.AddRange(classNames);
            ComboClass2.Items.AddRange(classNames);
            ComboClass1.SelectedItem = classNames[classNames.Count() - 1];
            ComboClass2.SelectedItem = classNames[classNames.Count() - 2];

            string[] multiplicity = RelationMultiplicity.Multiplicities;
            ComboMulti1.Items.AddRange(multiplicity);
            ComboMulti1.SelectedItem = multiplicity[0];
            ComboMulti2.Items.AddRange(multiplicity);
            ComboMulti2.SelectedItem = multiplicity[0];

            string[] relations = RelationMain.RelationTypes;
            ComboRelation.Items.AddRange(relations);
            ComboRelation.SelectedItem = relations[0];
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            RelationMain.Sockets[0].ClassMain = Classes.First(c => c.Title.Text == ComboClass1.Text);
            RelationMain.Sockets[1].ClassMain = Classes.First(c => c.Title.Text == ComboClass2.Text);
            RelationMain.Sockets[0].Multiplicity.Text = ComboMulti1.Text;
            RelationMain.Sockets[1].Multiplicity.Text = ComboMulti2.Text;
            RelationMain.RelType = (RelType)Enum.Parse(typeof(RelType), ComboRelation.Text);

            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
