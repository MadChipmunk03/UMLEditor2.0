using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public class ClassAttribute : IClassTextPart, IClassPart
    {
        public char Visibility { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }
        Font TextFont = new Font(FontFamily.GenericSansSerif, 8);
        public Size TextSize
        {
            get
            {
                return TextRenderer.MeasureText(Text, TextFont);
            }
        }
        public bool Static { get; set; }
        public string Text
        {
            get
            {
                if (Static) return $"{Visibility}static {DataType} {Name}";
                else return $"{Visibility}{DataType} {Name}";
            }
            set { }
        }

        public void Draw(Point corner, Graphics g, int width, int height)
        {
            g.DrawString(Text, TextFont, Brushes.Black, corner.X + 10, corner.Y + (35 - TextSize.Height) / 2);
        }
    }
}
