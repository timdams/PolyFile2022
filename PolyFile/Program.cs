using System;
using System.Collections.Generic;
using System.IO;
namespace PolyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            if (args.Length == 0)
            {
                path = Environment.CurrentDirectory;
            }
            else
            {
                path = args[0];
            }

            //Scan files
            List<APFile> myFiles = FileScanner(path);

            //Do stuff with files
            foreach (var file in myFiles)
            {
                Console.WriteLine(file.ToString());
                
                //Bij een niet-text file => doAction
              

                if(file is TextFile)
                {
                    //Bij een text-file => ReadText => CW(resultaat);
                    TextFile temp = file as TextFile;
                    string result = temp.ReadText();
                    Console.WriteLine(result) ;
                }
                else if (file is EncryptFile)
                {
                    Console.WriteLine("Zeker dat dit geencrypt moet worden?(yes/no)");
                    if (Console.ReadLine() == "yes")
                        file.DoAction();
                }
                else
                {
                    file.DoAction();
                }


            }
        }

        private static List<APFile> FileScanner(string path)
        {
            var files = Directory.GetFiles(path);
            List<APFile> myFiles = new List<APFile>();
            foreach (var file in files)
            {
                string extension = Path.GetExtension(file);
                switch (extension)
                {
                    case ".json":
                    case ".txt":
                    case ".md":
                        myFiles.Add(new TextFile(file));
                        break;
                    case ".tim":
                        myFiles.Add(new EncryptFile(file));
                        break;
                    default:
                        myFiles.Add(new APFile(file));
                        break;
                }
            }

            return myFiles;
        }
    }
}
