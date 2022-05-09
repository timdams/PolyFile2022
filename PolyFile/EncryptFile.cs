using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PolyFile
{
    public class EncryptFile: APFile
    {
        public EncryptFile(string pathIn):base(pathIn)
        {
        }

        public override void DoAction()
        {

            //OPLETTEN
            File.Encrypt(Path);

            File.Decrypt(Path); 
            
        }
    }
}
