using System;
using System.Linq;
using System.Collections.Generic;

namespace Generics_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq (ToList mala practica)
            var l = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var otral = l.Where( (i) => (i % 2 == 0) ).ToList();

            // Generics
            var lista = new Lista<Vehiculo>();
            var a = new Auto();
            var m = new Moto();
            lista.Add(a);
            lista.Add(m); 
            var v = lista.Get(); 
            
            // Lambda
            Func<int, int, int> metodo = (i, j) => i + j;
            Func<int> metodo2 = () => 10;
            Func<int> metodo3 = Metodo;
            Func<int> metodo4 = metodo2;
            Func<int, int> metodo5 = (int i) => { return i + 3; };

            var r = Operacion( (e, f) => e*f, 3, 3);
            r = Operacion( (e, f) => e+f, 3, 3);
        }

        static int Operacion(Func<int, int, int> oper, int i, int j)
        {
            return oper(i, j);
        }

        static int Metodo()
        {
            return 4;
        }
    }

    class Lista<TIPO>
    {
        TIPO veh;

        public void Add(TIPO v)
        {
            this.veh = v;
        }

        public TIPO Get()
        {
            return this.veh;
        }
    }

    class Vehiculo
    {}

    class Auto : Vehiculo
    {}

    class Moto : Vehiculo
    {
        public void ArrancarMoto(){}
    }
}
