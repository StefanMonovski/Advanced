using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopsData = new Dictionary<string, Dictionary<string, double>>();
            string input = "";
            while ((input = Console.ReadLine()) != "Revision")
            {
                List<string> inputData = input.Split(", ").ToList();
                string shop = inputData[0];
                string product = inputData[1];
                double price = double.Parse(inputData[2]);
                if (shopsData.ContainsKey(shop))
                {
                    shopsData[shop].Add(product, price);
                }
                else
                {
                    shopsData.Add(shop, new Dictionary<string, double>());
                    shopsData[shop].Add(product, price);
                }
            }
            var shopsDataOrdered = shopsData.OrderBy(x => x.Key);
            foreach (var item in shopsDataOrdered)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
