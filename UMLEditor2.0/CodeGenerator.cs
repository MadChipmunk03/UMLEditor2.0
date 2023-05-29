using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLEditor2._0.classTable;
using UMLEditor2._0.classTable.Parts;
using UMLEditor2._0.relation;

namespace UMLEditor2._0
{
    public class CodeGenerator
    {
        private string Folder { get; set; }
        public string Namespace { get; set; }

        public CodeGenerator(string folder, string @namespace)
        {
            Folder = folder;
            Namespace = @namespace;
        }

        public void Generate(List<ClassMain> classes, List<RelationMain> relations)
        {
            foreach(ClassMain classMain in classes)
            {
                string filePath = Folder + '\\' + classMain.Title.Text + ".cs";
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                {
                    DialogResult result = MessageBox.Show($"Soubor '{classMain.Title.Text}.cs' již existuje v zadaném adresáři. Přejete si ho přepsat?", "Upozornění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) fileInfo.Delete();
                    else continue;
                }

                StringBuilder sb = new StringBuilder();
                GenerateHeader(sb, classMain);
                GenerateAttributes(sb, classMain);
                sb.Append("\r\n");
                GenerateMethods(sb, classMain);
                GenerateFooter(sb);

                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
        }

        private string VisibilityToString(char vis)
        {
            if (vis == '+') return "public";
            else if (vis == '-') return "private";
            else if (vis == '*') return "protected";
            else return "internal";
        }

        private string DefaultTypeValue(string type) {
            switch (type)
            {
                case "bool": return "true";
                case "int": return "1";
                case "string": return "\"Hello World!\"";
                case "char": return "'A'";
                case "float": return "1.0";
                case "double": return "1.0";
                default:
                    return "UNKNOWN DATATYPE";
            }
        }

        private void GenerateHeader(StringBuilder sb, ClassMain classMain)
        {
            sb.AppendLine("using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Linq;\r\n" +
                "using System.Text;\r\n" +
                "using System.Threading.Tasks;\r\n" +
                "\r\n" +
                $"namespace {Namespace}\r\n" +
                "{\r\n" +
                $"\t{VisibilityToString(classMain.Visibility)} class {classMain.Title.Text}\r\n" +
                "\t{");
        }

        private void GenerateAttributes(StringBuilder sb, ClassMain classMain)
        {
            foreach(ClassAttribute attribute in classMain.Attributes)
            {
                string staticString = " ";
                if (attribute.Static) staticString = " static ";
                sb.AppendLine($"\t\t{VisibilityToString(attribute.Visibility)}{staticString}{attribute.DataType} {attribute.Name}" + " { get; set; }");
            }
        }

        private void GenerateMethods(StringBuilder sb, ClassMain classMain)
        {
            foreach(ClassMethod method in classMain.Methods)
            {
                string staticString = " ";
                if (method.Static) staticString = " static ";

                string paramsStr = "";
                foreach (ClassMethodParameter param in method.Parameters)
                    paramsStr += $"{param.DataType} {param.Name}, ";
                if(paramsStr.Length > 0) paramsStr = paramsStr.Substring(0, paramsStr.Length - 2);

                sb.AppendLine($"\t\t{VisibilityToString(method.Visibility)}{staticString}{method.DataType} {method.Name}({paramsStr})\r\n" +
                              "\t\t{\r\n" +
                              $"\t\t\treturn {DefaultTypeValue(method.DataType)}\r\n" +
                              "\t\t}\r\n");
            }
        }

        private void GenerateFooter(StringBuilder sb)
        {
            sb.AppendLine("\t}" +
                          "\r\n}");
        }
    }
}
