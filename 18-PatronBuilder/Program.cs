using System;

namespace PatronBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            VehiculoBuilder auto = new AutoBuilder();
            VehiculoBuilder moto = new MotoBuilder();
            VehiculoBuilder colectivo = new ColectivoBuilder();

            // Construct two products

            director.Construct(auto);
            Vehiculo p1 = auto.GetResult();
            p1.Show();

            director.Construct(moto);
            Vehiculo p2 = moto.GetResult();
            p2.Show();

            director.Construct(colectivo);
            Vehiculo p3 = colectivo.GetResult();
            p3.Show();

            // Wait for user

            Console.ReadKey();
        }
    }
}
