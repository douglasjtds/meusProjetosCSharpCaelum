using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplicationTesteTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensagem que vai pesara o terminal.");

            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha != null) {
                linha = leitor.ReadLine();
            }


            //// Keep the console window open in debug mode.
            //Console.ReadKey();
        }
    }
}
