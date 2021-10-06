using System;
using System.Collections.Generic;
using Tema_1.Domain;
using static Tema_1.Domain.ShoppingCart;

namespace Tema_1
{
    class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            var listOfProducts = ReadListOfProducts().ToArray();

            UnvalidatedShoppingCart unvalidatedProducts = new(listOfProducts);
            IShoppingCart result = ValidateShoppingCart(unvalidatedProducts);
            result.Match(
                whenUnvalidatedShoppingCart: unvalidatedResult => unvalidatedProducts,
                whenPaidShoppingCart: publishedResult => publishedResult,
                whenEmptyShoppingCart: invalidResult => invalidResult,
                whenValidatedShoppingCart: validatedResult => PaidShoppingCart(validatedResult)
            );

            Console.WriteLine("Hello World!");
        }


        private static List<UnvalidatedProduct> ReadListOfProducts()
        {
            List<UnvalidatedProduct> listOfProducts = new();
            int maxNumberProducts = 0;
            do
            {
 
                var productID = ReadValue("Product ID: ");
                if (string.IsNullOrEmpty(productID))
                {
                    break;
                }

                var cantity = ReadValue("Cantity: ");
                if (string.IsNullOrEmpty(cantity))
                {
                    break;
                }

                listOfProducts.Add(new(productID, cantity));
                ++maxNumberProducts;
            } while (maxNumberProducts!=5);


            Console.WriteLine("\nList of products");

            foreach (var product in listOfProducts)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nClient");
            var address = ReadValue("Adresa: ");
            if (string.IsNullOrEmpty(address))
            {
                Console.WriteLine(address);
            }

            var paid = ReadValue("PaidCart: ");
            if (paid != null)
            {
                Console.WriteLine(paid);
            }

            return listOfProducts;

        }

       
        private static IShoppingCart ValidateShoppingCart(UnvalidatedShoppingCart unvalidatedProducts) =>
            random.Next(100) > 50 ?
            new EmptyShoppingCart(new List<UnvalidatedProduct>(), "Random errror")
            : new ValidatedShoppingCart(new List<ValidatedProduct>());

        private static IShoppingCart PaidShoppingCart(ValidatedShoppingCart validShoppingCart) =>
            new PaidShoppingCart(new List<ValidatedProduct>(), DateTime.Now);

        private static string? ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }


    }
}
