using System;
using System.IO;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";
            
            try
            {
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS: ");

                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES: ");

                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path+@"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}