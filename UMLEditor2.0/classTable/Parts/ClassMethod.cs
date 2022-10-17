using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public class ClassMethod : IClassTextPart, IClassPart
    {
        public BindingList<ClassMethodParameter> Parameters = new BindingList<ClassMethodParameter>();
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
                string paramsStr = "";
                foreach(ClassMethodParameter param in Parameters)
                    paramsStr += $"{param.DataType} {param.Name}, ";
                if(paramsStr != "") paramsStr = paramsStr.Substring(0, paramsStr.Length - 2);

                if (Static) return $"{Visibility}static {DataType} {Name}({paramsStr})";
                else return $"{Visibility}{DataType} {Name}({paramsStr})";
            }
            set { }
        }

        public void Draw(Point corner, Graphics g)
        {
            g.DrawString(Text, TextFont, Brushes.Black, corner.X + 10, corner.Y + (35 - TextSize.Height) / 2);
        }
    }
}
