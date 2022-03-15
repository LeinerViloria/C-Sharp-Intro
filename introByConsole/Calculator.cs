using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introByConsole
{
    internal class Calculator
    {
        //Esto es un metodo
        public int add(int n1, int n2)
        {
            return n1 + n2;
        }
        //Esto es otro metodo
        public String divide(float n1, float n2)
        {
            if (n2 == 0) return "No se puede dividir entre cero";
            return ""+(n1 / n2);
        }
    }
}
