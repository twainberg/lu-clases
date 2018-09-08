using System;

namespace PatronBuilder
{
    class Director
    {
        public void Construct(VehiculoBuilder builder)
        {
            builder.BuildRuedas();
            builder.BuildMotor();
            builder.BuildCarroceria();
        }
    }
 }