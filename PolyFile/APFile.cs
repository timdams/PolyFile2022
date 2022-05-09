using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyFile
{
    public class APFile
    {
        public APFile(string pathIn)
        {
            Path = pathIn;
        }
        public string Path { get; private set; }

        public virtual void DoAction()
        {
            Console.WriteLine($"{Path}: Weet niet wat ik hier mee moet doen.");
        }

        public override string ToString()
        {
            return Path;
        }
    }
}
