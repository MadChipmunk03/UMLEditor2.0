using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable;
using UMLEditor2._0.classTable.Parts;
using UMLEditor2._0.relation.Parts;

namespace UMLEditor2._0.relation
{
    public class RelationMain : IDiagramPart
    {
        public RelType RelType;

        public static string[] RelationTypes = new string[] { "Association", "Inheritance", "Aggregation", "Composition" };
        public Socket[] Sockets = new Socket[] {new Socket(), new Socket()};
        private RelationLine Line = new RelationLine();
        private RelationArrow Arrow = new RelationArrow();

        public RelationMain()
        {
            Sockets[1].Id = 1;
        }

        public void Draw(Graphics g)
        {
            CalcRelData();
            foreach (Socket socket in Sockets)
                socket.Multiplicity.Draw(g, RelType);

            Line.Draw(g, Sockets, RelType);
            Arrow.Draw(g, Sockets[0], RelType);
        }

        public bool DoubleClickedByMouse(MouseEventArgs e)
        {
            foreach (Socket socket in Sockets)
                if(socket.Multiplicity.DoubleClicked(e, RelType)) return true;
            return false;
        }

        private void CalcRelData()
        {
            foreach (Socket socket in Sockets)
                socket.CalcSocket(new Point[] { Sockets[0].ClassCenter, Sockets[1].ClassCenter });
        }

    }
}
