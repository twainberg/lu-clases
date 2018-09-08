using System;

namespace PatronBuilder
{
    public abstract class VehiculoBuilder
    {
        public abstract void BuildRuedas();

        public abstract void BuildMotor();

        public abstract void BuildCarroceria();

        public abstract Vehiculo GetResult();
    }
}