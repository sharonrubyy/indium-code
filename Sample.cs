using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Sample
    {//yes

        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
          return  a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b; 
        }


        static void Main(string[] args)
        {
            Sample s = new Sample();
            Console.WriteLine(s.Add(10,5));
            Console.WriteLine(s.Sub(10,6));
            Console.ReadKey();
        }

    }
}
