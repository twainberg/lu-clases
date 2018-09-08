using System;

namespace Metodos_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sumar(2, 2);
            
            string name = "Tomas";
            string lastname = "Wainberg";
            string na = name + " " + lastname + result;

            DateTime fecha = new DateTime(2018, 5, 10);
            fecha = fecha.AddDays(40);

            Console.WriteLine(na);
        }

        static int Sumar(int i, int j, int k)
        {
            int resultado = Sumar(Sumar(i, j), k);

            return resultado;
        }

        static int Sumar(int i, int j)
        {
            return i + j;
        }
    }
}
