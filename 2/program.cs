using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarWithRecursion
{

    class Program
    {





        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite adress");
            string dir = Console.ReadLine();
            string directory = @dir;
     
           System.IO.Directory.SetCurrentDirectory(directory);

           string currentDirName = System.IO.Directory.GetCurrentDirectory();
           Console.WriteLine(currentDirName);
            
           string[] files = System.IO.Directory.GetFiles(currentDirName, "*.txt");

           foreach (string s in files)
           {

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                
                string current2 = s;
                Console.WriteLine(current2);
                string[] lines = System.IO.File.ReadAllLines(@current2);

                foreach (string line in lines)
                {
                    if (line == "abcd") { Console.WriteLine(s); }
                }
                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
            }
        }
    }
}
