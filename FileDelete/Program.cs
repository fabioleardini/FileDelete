using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dirPath = @"\\Sr2k3-smlciab2011\d$\Converge\WindowsService\Log\SML - CVG Import\20130809\03";
                string[] files = Directory.GetFiles(dirPath);
                int count = Directory.GetFiles(dirPath).Length;

                Console.WriteLine("Quantidade de arquivos a serem deletados: " + count);
                Console.ReadLine();

                foreach (string f in files)
                {
                    File.Delete(f);
                    count--;
                    Console.Write("Quantidade de arquivos a serem deletados: " + count);
                    Console.Out.WriteLine();
                }

                Console.WriteLine("Fim!");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
