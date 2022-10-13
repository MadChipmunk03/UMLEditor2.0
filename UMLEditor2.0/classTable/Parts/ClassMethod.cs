using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public class ClassMethod : IClassTextPart, IClassPart
    {
        public string Text { get; set; }
        Font TextFont = new Font(FontFamily.GenericSansSerif, 8);
        public Size TextSize
        {
            get
            {
                return TextRenderer.MeasureText(Text, TextFont);
            }
        }


        public void Draw(Point corner, Graphics g, int width = 0, int height = 0)
        {

        }
    }
}
