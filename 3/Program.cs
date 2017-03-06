using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace _3
{
    class Program
    {
        public static void print() 
        {
            int x = 1;
            while (true)
            {
                Thread.Sleep(200);
                
                double y = Math.Sin(10*x * Math.PI / 18);
                int b = Convert.ToInt32(y);
                Console.SetCursorPosition( 2*x , 2*b+20);
                Console.Write("*");
                x = x + 1;
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(print));
            t.Start();
            
               
        }
    }
}
