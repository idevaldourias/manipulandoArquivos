using System;
using System.IO;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    Console.WriteLine(line);
                }

            } catch (IOException ex)
            {
                Console.WriteLine("An error acurred: ");
                Console.WriteLine(ex.Message);
            } finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}