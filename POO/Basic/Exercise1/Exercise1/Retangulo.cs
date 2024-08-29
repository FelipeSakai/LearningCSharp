using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Retangulo
    {
        public double larg;
        public double alt;


        public double Area()
        {
            return alt * larg;
        }

        public double Perimetro()
        {
            return 2 * (alt + larg);
        }

        public double Diagonal()
        {
            return Math.Sqrt(larg * larg + alt * alt);
        }
    }
}
