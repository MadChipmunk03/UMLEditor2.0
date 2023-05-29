using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.relation.Parts
{
    public class RelationMultiplicity
    {
        public static string[] Multiplicities = { "1..1", "1..n", "1..*", "0..*", "m..m", "m..n" };
        Font TextFont = new Font(FontFamily.GenericSansSerif, 8);
        public string Text { get; set; }
        private Size TextSize
        {
            get
            {
                return TextRenderer.MeasureText(Text, TextFont);
            }
        }
        private Socket Parent;


        public RelationMultiplicity(Socket parent)
        {
            Parent = parent;
        }

        public void Draw(Graphics g, RelType type)
        {
            int margin = 15;
            int relTypeMargin = 0;
            if (Parent.Id == 0 && Array.IndexOf(new RelType[] { RelType.Inheritance, RelType.Composition, RelType.Aggregation }, type) >= 0)
                relTypeMargin = 10;

            switch (Parent.Orientation)
            {
                case Orientation.TOP:
                    g.DrawString(Text, TextFont, Brushes.Black, Parent.Point.X - margin - relTypeMargin - TextSize.Width, Parent.Point.Y - margin - TextSize.Height);
                    break;
                case Orientation.RIGHT:
                    g.DrawString(Text, TextFont, Brushes.Black, Parent.Point.X + margin, Parent.Point.Y - margin - relTypeMargin - TextSize.Height);
                    break;
                case Orientation.BOTTOM:
                    g.DrawString(Text, TextFont, Brushes.Black, Parent.Point.X + margin + relTypeMargin, Parent.Point.Y + margin);
                    break;
                case Orientation.LEFT:
                    g.DrawString(Text, TextFont, Brushes.Black, Parent.Point.X - margin - TextSize.Width, Parent.Point.Y + margin + relTypeMargin);
                    break;
            }
        }

        public bool DoubleClicked(MouseEventArgs e, RelType type)
        {
            int margin = 15;
            int relTypeMargin = 0;
            if (Parent.Id == 0 && Array.IndexOf(new RelType[] { RelType.Inheritance, RelType.Composition, RelType.Aggregation }, type) >= 0)
                relTypeMargin = 10;

            Point corner;

            switch (Parent.Orientation)
            {
                case Orientation.TOP:
                    corner = new Point(Parent.Point.X - margin - relTypeMargin - TextSize.Width, Parent.Point.Y - margin - TextSize.Height);
                    break;
                case Orientation.RIGHT:
                    corner = new Point(Parent.Point.X + margin, Parent.Point.Y - margin - relTypeMargin - TextSize.Height);
                    break;
                case Orientation.BOTTOM:
                    corner = new Point(Parent.Point.X + margin + relTypeMargin, Parent.Point.Y + margin);
                    break;
                default: //LEFT
                    corner = new Point(Parent.Point.X - margin - TextSize.Width, Parent.Point.Y + margin + relTypeMargin);
                    break;
            }

            return (e.X >= corner.X && e.X <= corner.X + TextSize.Width) &&
                   (e.Y >= corner.Y && e.Y <= corner.Y + TextSize.Height);
        }
    }
}
