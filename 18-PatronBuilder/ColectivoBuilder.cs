using System;
using System.Collections.Generic;

namespace PatronBuilder
{
    public class ColectivoBuilder: VehiculoBuilder
    {
        private Vehiculo _vehiculo = new Vehiculo();

        public override void BuildRuedas()
        {
            _vehiculo.Ruedas = new List<Rueda>() { new Rueda(), new Rueda(), new Rueda(), new Rueda() };
        }
        public override void BuildMotor()
        {
            _vehiculo.Motor = new Motor();
        }
        public override void BuildCarroceria()
        {
            _vehiculo.Carroceria = new Carroceria();
        }

        public override Vehiculo GetResult()
        {
            return _vehiculo;
        }
    }
}