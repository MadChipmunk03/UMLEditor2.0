using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable.Parts;

namespace UMLEditor2._0.classTable
{
    public class ClassMain : IDiagramPart
    {
        private ClassPanel Panel = new ClassPanel();
        public ClassTitle Title = new ClassTitle();
        public char Visibility { get; set; }
        public bool Static { get; set; }
        public BindingList<ClassAttribute> Attributes = new BindingList<ClassAttribute>();
        public BindingList<ClassMethod> Methods = new BindingList<ClassMethod>();

        public Point Corner = new Point();
        private int[] LastMousePos = new int[] {0, 0};
        public int MinWidth;
        public int Height { get; set; }
        public int Id { get; set; }

        public ClassMain(Point corner = new Point(), int id = 0)
        {
            Corner = corner;
            Id = id;
            Title.Text = $"Class{Id}";
        }

        public void Draw(Graphics g)
        {
            int attrYOffset = 35 + ClassPanel.BorderWidth;
            int methYOffset = attrYOffset + (Attributes.Count() * 35) + ClassPanel.BorderWidth;

            Panel.Draw(Corner, g, MinWidth, Height, methYOffset);
            Title.Draw(Corner, g, MinWidth);
            for(int i = 0; i < Attributes.Count(); i++)
                Attributes[i].Draw(new Point(Corner.X, Corner.Y + attrYOffset + (35 * i)), g);
            for (int i = 0; i < Methods.Count(); i++)
                Methods[i].Draw(new Point(Corner.X, Corner.Y + methYOffset + (35 * i)), g);
        }

        public void MouseMove(MouseEventArgs e)
        {
            if ((e.X >= Corner.X && e.X <= Corner.X + MinWidth) && 
                (e.Y >= Corner.Y && e.Y <= Corner.Y + Height))
            {
                if(e.Button.ToString() == "Left")
                {
                    //MessageBox.Show($"{LastMousePos[0]}, {e.X}, {LastMousePos[1]}, {e.Y}");
                    Corner = new Point(Corner.X -= LastMousePos[0] - e.X, Corner.Y -= LastMousePos[1] - e.Y);
                    LastMousePos[0] = e.X;
                    LastMousePos[1] = e.Y;
                }
                else if (e.Button.ToString() == "None")
                {
                    LastMousePos[0] = e.X;
                    LastMousePos[1] = e.Y;
                }
            }
        }

        public bool DoubleClickedByMouse(MouseEventArgs e)
        {
            return (e.X >= Corner.X && e.X <= Corner.X + MinWidth) &&
                   (e.Y >= Corner.Y && e.Y <= Corner.Y + Height);
        }

        public void CalcDimensions()
        {
            MinWidth = 25;
            IClassTextPart[] textParts = new IClassTextPart[] { Title};
            foreach (IClassTextPart textPart in textParts.Concat(Attributes).Concat(Methods))
            {
                if(textPart.TextSize.Width > MinWidth - 25)
                    MinWidth = textPart.TextSize.Width + 25;
            }
            Height = 35 + (2 * ClassPanel.BorderWidth) + 35 * Attributes.Count() + 35 * Methods.Count();
        }
    }
}
