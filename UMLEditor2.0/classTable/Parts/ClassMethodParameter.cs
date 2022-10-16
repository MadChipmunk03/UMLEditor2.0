using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEditor2._0.classTable.Parts
{
    public class ClassMethodParameter
    {
        [DisplayName("Název")]
        public string Name { get; set; }

        [DisplayName("Datový typ")]
        public string DataType { get; set; }
    }
}
