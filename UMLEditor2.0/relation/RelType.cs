using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.relation
{
    public enum RelType
    {
        Association, // ------
        Inheritance, // ----->
        Aggregation, // ---<*>
        Composition  // ---< >
    }
}
