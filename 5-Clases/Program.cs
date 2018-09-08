using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Auto(new DateTime(2017, 1, 1));

            if (a.HaceFaltaPresentarVTV())
            {
                Console.WriteLine("A ver la VTV?");
            }
            else
            {
                Console.WriteLine("Siga, siga");
            }

            a.Transferir();

            var b = new Bicicleta(new DateTime(2018, 10, 10));

            b.Transferir();

            Hacer(a);
            Hacer(b);
        }

        static void Hacer(Vehiculo v)
        {
            v.Transferir();
        }
    }

    interface Cosa
    {
        void Agarrar();

        void Patear();
    }
    
    abstract class Vehiculo
    {
        public Vehiculo(DateTime fecha)
        {
            this.fechaCompra = fecha;
            Console.WriteLine("Nuevo vehículo");
        }

        ~Vehiculo()
        {
            Console.WriteLine("me fui.");
        }

        static void Hacer()
        {

        }

        protected int velocidad = 0;

        DateTime fechaCompra;

        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }

        public DateTime FechaCompra
        {
            get { return this.fechaCompra; }
            set { this.fechaCompra = value; }
        }

        public int Modelo
        {
            get { return this.fechaCompra.Year; }
        }

        public void Acelerar(int accel)
        {
            this.velocidad += accel;
        }

        public abstract void Transferir();
    }

    class Auto : Vehiculo
    {
        int color = 0;

        public Auto(DateTime fechaCompra) : base(fechaCompra)
        {

        }

        public bool HaceFaltaPresentarVTV()
        {
            var hoy = DateTime.Now;

            return (hoy.Year - this.Modelo) > 2;
        }

        public override void Transferir()
        {
            Console.WriteLine("Traeme el 08");
        }
    }

    class Bicicleta : Vehiculo
    {
        public Bicicleta(DateTime fechaCompra) : base(fechaCompra)
        {

        }

        public override void Transferir()
        {
            Console.WriteLine("La paso a buscar mañana");
        }
    }
}
