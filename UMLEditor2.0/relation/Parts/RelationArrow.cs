using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable.Parts;

namespace UMLEditor2._0.relation.Parts
{
    public class RelationArrow
    {
        Pen LinePen = new Pen(Color.Black, ClassPanel.BorderWidth / 2);
        private Point[] DrawPs { get; set; } = new Point[17];
        int HalfSize = 20;
        public void Draw(Graphics g, Socket socket, RelType type)
        {
            switch (type){
                case RelType.Association:
                    return;
                    break;
                case RelType.Inheritance:
                    ClearOut(g, socket);
                    DrawInheritance(g, socket);
                    break;
                case RelType.Aggregation:
                    ClearOut(g, socket);
                    CalcRhombusPoints(socket);
                    DrawAggregation(g, socket);
                    break;
                case RelType.Composition:
                    ClearOut(g, socket);
                    CalcRhombusPoints(socket);
                    DrawComposition(g, socket);
                    break;
            }
        }

        private void ClearOut(Graphics g, Socket socket)
        {
            Brush clearBrush = SystemBrushes.Control;
            
            switch (socket.Orientation)
            {
                case Orientation.TOP:
                    g.FillRectangle(clearBrush, socket.Point.X - HalfSize, socket.Point.Y - (2 * HalfSize), 2* HalfSize, 2*HalfSize);
                    break;
                case Orientation.RIGHT:
                    g.FillRectangle(clearBrush, socket.Point.X, socket.Point.Y - HalfSize, 2 * HalfSize, 2 * HalfSize);
                    break;
                case Orientation.BOTTOM:
                    g.FillRectangle(clearBrush, socket.Point.X - HalfSize, socket.Point.Y, 2 * HalfSize, 2 * HalfSize);
                    break;
                case Orientation.LEFT:
                    g.FillRectangle(clearBrush, socket.Point.X - (2*HalfSize), socket.Point.Y - HalfSize, 2 * HalfSize, 2 * HalfSize);
                    break;
            }
        }
        
        private void CalcRhombusPoints(Socket socket)
        {
            DrawPs[0] = new Point(socket.Point.X, socket.Point.Y); // center

            DrawPs[1] = new Point(socket.Point.X, socket.Point.Y - (2 * HalfSize));
            DrawPs[2] = new Point(socket.Point.X - HalfSize, socket.Point.Y - HalfSize);
            DrawPs[3] = new Point(socket.Point.X + HalfSize, socket.Point.Y - HalfSize);
            DrawPs[4] = new Point(socket.Point.X - (2*HalfSize), socket.Point.Y);
            DrawPs[5] = new Point(socket.Point.X + (2 * HalfSize), socket.Point.Y);
            DrawPs[6] = new Point(socket.Point.X - HalfSize, socket.Point.Y + HalfSize);
            DrawPs[7] = new Point(socket.Point.X + HalfSize, socket.Point.Y + HalfSize);
            DrawPs[8] = new Point(socket.Point.X, socket.Point.Y + (2 * HalfSize));
        }

        private void DrawInheritance(Graphics g, Socket socket) // ----->
        {
            DrawPs[0] = new Point(socket.Point.X, socket.Point.Y); // center

            switch (socket.Orientation)
            {
                case Orientation.TOP:
                    DrawPs[1] = new Point(socket.Point.X - HalfSize, socket.Point.Y - (2 * HalfSize));
                    DrawPs[2] = new Point(socket.Point.X + HalfSize, socket.Point.Y - (2 * HalfSize));
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[1], DrawPs[0], DrawPs[2] });
                    break;
                case Orientation.RIGHT:
                    DrawPs[4] = new Point(socket.Point.X + (2 * HalfSize), socket.Point.Y - HalfSize);
                    DrawPs[6] = new Point(socket.Point.X + (2 * HalfSize), socket.Point.Y + HalfSize);
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[4], DrawPs[0], DrawPs[6] });
                    break;
                case Orientation.BOTTOM:
                    DrawPs[7] = new Point(socket.Point.X - HalfSize, socket.Point.Y + (2 * HalfSize));
                    DrawPs[8] = new Point(socket.Point.X + HalfSize, socket.Point.Y + (2 * HalfSize));
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[7], DrawPs[0], DrawPs[8] });
                    break;
                case Orientation.LEFT:
                    DrawPs[3] = new Point(socket.Point.X - (2 * HalfSize), socket.Point.Y - HalfSize);
                    DrawPs[5] = new Point(socket.Point.X - (2 * HalfSize), socket.Point.Y + HalfSize);
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[3], DrawPs[0], DrawPs[5] });
                    break;
            }
        }

        private void DrawAggregation(Graphics g, Socket socket) // ---<*>
        {
            switch (socket.Orientation)
            {
                case Orientation.TOP:
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[1], DrawPs[2], DrawPs[0], DrawPs[3] });
                    break;
                case Orientation.RIGHT:
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[5], DrawPs[3], DrawPs[0], DrawPs[7] });
                    break;
                case Orientation.BOTTOM:
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[8], DrawPs[7], DrawPs[0], DrawPs[6] });
                    break;
                case Orientation.LEFT:
                    g.DrawPolygon(LinePen, new Point[] { DrawPs[4], DrawPs[6], DrawPs[0], DrawPs[2] });
                    break;
            }
        }

        private void DrawComposition(Graphics g, Socket socket) // ---< >
        {
            Brush fillBrush = Brushes.Black;

            switch (socket.Orientation)
            {
                case Orientation.TOP:
                    g.FillPolygon(fillBrush, new Point[] { DrawPs[1], DrawPs[2], DrawPs[0], DrawPs[3] });
                    break;
                case Orientation.RIGHT:
                    g.FillPolygon(fillBrush, new Point[] { DrawPs[5], DrawPs[3], DrawPs[0], DrawPs[7] });
                    break;
                case Orientation.BOTTOM:
                    g.FillPolygon(fillBrush, new Point[] { DrawPs[8], DrawPs[7], DrawPs[0], DrawPs[6] });
                    break;
                case Orientation.LEFT:
                    g.FillPolygon(fillBrush, new Point[] { DrawPs[4], DrawPs[6], DrawPs[0], DrawPs[2] });
                    break;
            }
        }
    }
}
