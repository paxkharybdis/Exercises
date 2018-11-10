using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {


        static void Main(string[] args)
        {
            NumberSum();
        }



        public static void NumberSum()
        {
            PrintSum newSum = new PrintSum();
            newSum.RequestInput();
            PrintSum newAdd = new PrintSum();
            newAdd.AddSum();
        }
    }

}









