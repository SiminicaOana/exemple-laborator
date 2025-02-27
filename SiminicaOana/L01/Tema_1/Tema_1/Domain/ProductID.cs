﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record ProductID
    {
        private static readonly Regex ValidPattern = new("^PR[0-9]{3}$");

        public string Value { get; }

        private ProductID(string value)
        {
            if (ValidPattern.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                throw new InvalidProductID("ERROR");
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
