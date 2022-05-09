using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PolyFile
{
    public class TextFile: APFile
    {
        public TextFile(string pathIn): base(pathIn)
        {

        }

        public override void DoAction()
        {
            string inhoud = File.ReadAllText(Path);
            Console.WriteLine(inhoud);

           
        }

        public string ReadText()
        {
            return File.ReadAllText(Path);
        }
    }
}
