using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public class ClassPanel : IClassPart
    {
        public static int BorderWidth = 4;

        public void Draw(Point corner, Graphics g, int width, int height, int methYOffset)
        {
            Pen borderPen = new Pen(Color.Black, BorderWidth);
            g.FillRectangle(Brushes.LightCyan, corner.X, corner.Y, width, height);
            g.FillRectangle(Brushes.DarkCyan, corner.X, corner.Y, width, 35);
            g.DrawRectangle(borderPen, corner.X, corner.Y, width, height);
            //dividers
            g.DrawLine(borderPen, corner.X, corner.Y + 35, corner.X + width, corner.Y + 35);
            g.DrawLine(borderPen, corner.X, corner.Y + methYOffset, corner.X + width, corner.Y + methYOffset);
        }
    }
}
