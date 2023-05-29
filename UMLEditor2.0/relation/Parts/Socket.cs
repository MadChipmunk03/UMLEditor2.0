using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable;

namespace UMLEditor2._0.relation.Parts
{
    public class Socket
    {
        public ClassMain ClassMain = new ClassMain();
        public Point ClassCenter
        {
            get
            {
                return new Point(ClassMain.Corner.X + ClassMain.MinWidth / 2, ClassMain.Corner.Y + ClassMain.Height / 2);
            }
        }
        public RelationMultiplicity Multiplicity;
        public Point Point = new Point();
        //TOP - 1; RIGHT - 2; BOTTOM - 3; LEFT - 4 
        public Orientation Orientation = Orientation.UNDEFINED;
        public int Id = 0;

        public Socket()
        {
            Multiplicity = new RelationMultiplicity(this);
        }

        public void CalcSocket(Point[] centers)
        {
            double degreesMain = Math.Atan2(centers[Id].Y - centers[(Id + 1) % 2].Y, centers[Id].X - centers[(Id + 1) % 2].X) + 2 * Math.PI;
            double degrees12 = Math.Atan2(0 - ClassMain.Height / 2, 0 + ClassMain.MinWidth / 2) + 2 * Math.PI;
            double degrees23 = Math.Atan2(0 + ClassMain.Height / 2, 0 + ClassMain.MinWidth / 2) + 2 * Math.PI;
            double degrees34 = Math.Atan2(0 + ClassMain.Height / 2, 0 - ClassMain.MinWidth / 2) + 2 * Math.PI;
            double degrees41 = Math.Atan2(0 - ClassMain.Height / 2, 0 - ClassMain.MinWidth / 2) + 2 * Math.PI;

            if (degreesMain <= degrees41 || degreesMain >= degrees34)
            {
                Orientation = Orientation.RIGHT;
                Point = new Point(centers[Id].X + ClassMain.MinWidth / 2, centers[Id].Y);
            }

            else if (degreesMain <= degrees12)
            {
                Orientation = Orientation.BOTTOM;
                Point = new Point(centers[Id].X, centers[Id].Y + ClassMain.Height / 2);
            }
            else if (degreesMain <= degrees23)
            {
                Orientation = Orientation.LEFT;
                Point = new Point(centers[Id].X - ClassMain.MinWidth / 2, centers[Id].Y);
            }
            else if (degreesMain <= degrees34)
            {
                Orientation = Orientation.TOP;
                Point = new Point(centers[Id].X, centers[Id].Y - ClassMain.Height / 2);
            }
        }

    }
}
