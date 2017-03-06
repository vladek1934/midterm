using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_exam_VladMun
{
    class Program
    {
        static void Main(string[] args)
        {
           

           
          
           
               
                for (int i = 0; i < args.Length; i++)
                { int chislo = int.Parse(args[i]);
                    if ((chislo%3==0)&&(chislo%5!=0)){Console.WriteLine(chislo);}
                    }
                    return ;

        }
    }
}
