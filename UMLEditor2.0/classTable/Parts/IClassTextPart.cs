using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public interface IClassTextPart
    {
        string Text { get; set; }
        Size TextSize { get; }
    }
}
