using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[10];
            int i = 0;
            decimal promedio = 0;

            lista[0] = 10;
            lista[1] = 10;
            lista[2] = 20;
            lista[3] = 30;

            while (i < 10)
            {
                promedio += lista[i];
                i++; 

                if (lista[i] == 0)
                {
                    continue;
                }
            }
            promedio = promedio / i;

            decimal prom = 0;
            int nota;

            for (nota = 0; nota < 10; nota++)
            {
                prom += lista[nota];

                if (lista[nota] == 0)
                {
                    break;
                }
            }
            prom /= nota;
        }
    }

}
