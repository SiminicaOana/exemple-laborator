using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record Cantity
    {
        public decimal Value { get; }

        public Cantity(decimal value)
        {
            if (value > 0 && value <= 20)
            {
                Value = value;
            }
            else
            {
                throw new InvalidCantity($"{value:0.##} is an invalid cantity value.");
            }
        }
    }
}
