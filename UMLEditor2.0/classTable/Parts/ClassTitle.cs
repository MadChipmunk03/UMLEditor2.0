using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public class ClassTitle : IClassTextPart, IClassPart
    {
        public string Text { get; set; }
        Font TextFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        public Size TextSize
        {
            get
            {
                return TextRenderer.MeasureText(Text, TextFont);
            }
        }

        public ClassTitle(string title)
        {
            Text = title;
        }

        public void Draw(Point corner, Graphics g, int width = 0)
        {
            g.DrawString(Text, TextFont, Brushes.White, corner.X + (width - TextSize.Width) / 2, corner.Y + (35 - TextSize.Height) / 2);
        }
    }
}
