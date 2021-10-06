using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1.Domain
{
    [AsChoice]
    public static partial class ShoppingCart
    {
        public interface IShoppingCart { }

        public record UnvalidatedShoppingCart(IReadOnlyCollection<UnvalidatedProduct> ProductsList) : IShoppingCart;

        public record EmptyShoppingCart(IReadOnlyCollection<UnvalidatedProduct> ProductsList, string reason) : IShoppingCart;

        public record ValidatedShoppingCart(IReadOnlyCollection<ValidatedProduct> ProductsList) : IShoppingCart;

        public record PaidShoppingCart(IReadOnlyCollection<ValidatedProduct> ProductsList, DateTime PublishedDate) : IShoppingCart;
    }
}
