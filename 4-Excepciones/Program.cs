using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hacer(2, "");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
        
        static void Hacer(int param, string par)
        {
            try
            {
                HacerMas(param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void HacerMas(int i)
        {
            if (i % 2 == 0)
            {
                throw new Exception("No me gustan los numeros pares."); 
            }
        }
    }
    
}
