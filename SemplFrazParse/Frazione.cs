using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SemplFrazParse
{
    internal class Frazione
    {
        public int num { get; set; }
        public int den { get; set; }

        public Frazione()
        {
        }        

       public Frazione(int num, int den)
        {
            Semplf(num, den, out int n, out int d);
            this.num = n;
            this.den = d;            

        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", num, den);
        }
        
        public static Frazione Parse(string s)
        {
            string[] a = s.Split('/');
            int num = int.Parse(a[0]);
            int den = int.Parse(a[1]);
            return new Frazione(num, den);
        }

        public void Semplf(int num, int den, out int n, out int d)
        {
            int mcd = MCD(num, den);
            n = num / mcd;
            d = den / mcd;
            return;
        }

        public int MCD(int n1, int n2)  //tra 4 e 6 = 2
        {
            while (n1 != n2)
            {
                if(n1 < n2)
                {
                    int n3 = n1;
                    n1 = n2;
                    n2 = n3;
                }

                n1 = n1 - n2;
            }            
            {
                return n1;
            }
        }
    }
}
