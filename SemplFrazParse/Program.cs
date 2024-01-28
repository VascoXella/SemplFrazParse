using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemplFrazParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione(5, 25);
            Console.WriteLine(f.ToString());

            Frazione f1 = Frazione.Parse("5 / 25");
            Console.WriteLine("{0}", f1);

            Console.ReadLine();

        }
    }
}
