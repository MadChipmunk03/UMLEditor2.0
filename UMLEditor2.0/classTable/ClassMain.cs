using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable.Parts;

namespace UMLEditor2._0.classTable
{
    public class ClassMain
    {
        private ClassPanel Panel = new ClassPanel();
        public ClassTitle Title = new ClassTitle("Class1");
        public char Visibility { get; set; }
        public bool Static { get; set; }
        public BindingList<ClassAttribute> Attributes = new BindingList<ClassAttribute>();
        public BindingList<ClassMethod> Methods = new BindingList<ClassMethod>();

        Point Corner = new Point();
        public int MinWidth;

        public ClassMain(Point corner)
        {
            Corner = corner;
        }

        public void Draw(Graphics g)
        {
            int height = 35 + ClassPanel.BorderWidth + 35 * Attributes.Count() + 35 * Methods.Count();
            int attrYOffset = 35 + ClassPanel.BorderWidth;
            int methYOffset = attrYOffset + (Attributes.Count() * 35);

            Panel.Draw(Corner, g, MinWidth, height);
            Title.Draw(Corner, g, MinWidth, height);
            for(int i = 0; i < Attributes.Count(); i++)
                Attributes[i].Draw(new Point(Corner.X, Corner.Y + attrYOffset + (35 * i)), g, MinWidth, height);
            for (int i = 0; i < Methods.Count(); i++)
                Methods[i].Draw(new Point(Corner.X, Corner.Y + methYOffset + (35 * i)), g, MinWidth, height);
        }

        public void CalcMinWidth()
        {
            MinWidth = 25;
            IClassTextPart[] textParts = new IClassTextPart[] { Title};
            foreach (IClassTextPart textPart in textParts.Concat(Attributes).Concat(Methods))
            {
                if(textPart.TextSize.Width > MinWidth - 25)
                    MinWidth = textPart.TextSize.Width + 25;
            }
        }
    }
}
