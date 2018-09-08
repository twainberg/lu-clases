using System;

namespace calculadoracomponent
{
    public class calculadora
    {
        public int Add(int? a, int? b)
        {
            if (a == null || b == null)
                throw new NullReferenceException();

            return a.Value + b.Value;
        }
    }
}
