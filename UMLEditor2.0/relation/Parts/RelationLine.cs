using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable.Parts;

namespace UMLEditor2._0.relation.Parts
{
    public class RelationLine
    {
        public void Draw(Graphics g, Socket[] sockets, RelType type)
        {
            Pen linePen = new Pen(Color.Black, ClassPanel.BorderWidth / 2);
            int xDistance = Math.Abs(sockets[0].Point.X - sockets[1].Point.X);
            int yDistance = Math.Abs(sockets[0].Point.Y - sockets[1].Point.Y);

            if (((byte)sockets[0].Orientation + (byte)sockets[1].Orientation) % 2 == 1) //Right-angle connection
            {
                foreach(Socket socket in sockets)
                {
                    switch (socket.Orientation)
                    {
                        case Orientation.TOP:
                            g.DrawLine(linePen, socket.Point.X, socket.Point.Y, socket.Point.X, socket.Point.Y - yDistance);
                            break;
                        case Orientation.RIGHT:
                            g.DrawLine(linePen, socket.Point.X, socket.Point.Y, socket.Point.X + xDistance, socket.Point.Y);
                            break;
                        case Orientation.BOTTOM:
                            g.DrawLine(linePen, socket.Point.X, socket.Point.Y, socket.Point.X, socket.Point.Y + yDistance);
                            break;
                        case Orientation.LEFT:
                            g.DrawLine(linePen, socket.Point.X, socket.Point.Y, socket.Point.X - xDistance, socket.Point.Y);
                            break;
                    }
                }
            }
            else //Zig-zag connection
            {
                for (int i = 0; i < sockets.Count(); i++)
                {
                    switch (sockets[i].Orientation)
                    {
                        case Orientation.TOP: //Vertical zig-zag
                            g.DrawLine(linePen, sockets[i].Point.X, sockets[i].Point.Y, sockets[i].Point.X, sockets[i].Point.Y - yDistance / 2);
                            g.DrawLine(linePen, sockets[i].Point.X, sockets[i].Point.Y - yDistance / 2, sockets[(i + 1) % 2].Point.X, sockets[i].Point.Y - yDistance / 2);
                            break;
                        case Orientation.RIGHT: //Horizontal zig-zag
                            g.DrawLine(linePen, sockets[i].Point.X, sockets[i].Point.Y, sockets[i].Point.X + xDistance / 2, sockets[i].Point.Y);
                            g.DrawLine(linePen, sockets[i].Point.X + xDistance / 2, sockets[i].Point.Y, sockets[i].Point.X + xDistance / 2, sockets[(i + 1) % 2].Point.Y);
                            break;
                        case Orientation.BOTTOM: //Vertical zig-zag
                            g.DrawLine(linePen, sockets[i].Point.X, sockets[i].Point.Y, sockets[i].Point.X, sockets[i].Point.Y + yDistance / 2);
                            break;
                        case Orientation.LEFT: //Horizontal zig-zag
                            g.DrawLine(linePen, sockets[i].Point.X, sockets[i].Point.Y, sockets[i].Point.X - xDistance / 2, sockets[i].Point.Y);
                            break;
                    }
                }
            }
        }
    }
}
