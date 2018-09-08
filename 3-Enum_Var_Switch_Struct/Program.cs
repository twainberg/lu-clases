using System;

namespace Enum_Var_Switch_Struct
{
    class Program
    {
        struct Persona
        {
            public string Nombre;
            public string Apellido;
            public string Club;
        }

        enum Operadores { Suma, Resta, Multiplicacion, Division } 

        static void Main(string[] args)
        {
            Persona[] d = new Persona[10];
            var diego = new Persona();
            
            diego.Nombre = "Diego";
            diego.Apellido = "Gonzalez";
            diego.Club = "Velez";

            var result = HacerCuenta(3, 3, Operadores.Suma);

            Console.WriteLine(result);
        }

        static int HacerCuenta(int i, int j, Operadores operador)
        {
            switch (operador)
            {
                case Operadores.Suma:
                    return i + j;
                case Operadores.Resta:
                    return i - j;
                case Operadores.Multiplicacion:
                    return i * j;
                case Operadores.Division:
                    return i / j;
                default:
                    throw new Exception("☁️");
            }
        }
    }
}
