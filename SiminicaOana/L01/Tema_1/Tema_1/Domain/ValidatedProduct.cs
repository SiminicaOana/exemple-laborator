﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    public record ValidatedProduct (ProductID ProductID, Cantity Cantity, Address Address, PaidCart PaidCart);
}
