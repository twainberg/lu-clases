using System;
using System.Collections.Generic;

namespace PatronBuilder
{
    public class Vehiculo
    {
        public List<Rueda> Ruedas { get; set; }

        public Motor Motor { get; set; }

        public Carroceria Carroceria { get; set; }

        public void Show()
        {
            Console.WriteLine("Vehiculo - Ruedas: " + Ruedas.Count);
        }
    }
}