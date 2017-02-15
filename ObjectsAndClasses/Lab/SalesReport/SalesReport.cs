using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            int salesCount = int.Parse(Console.ReadLine());

            for (int sale = 0; sale < salesCount; sale++)
            {
                var curentSale = GetSaleProperties();

                if (!salesByTown.ContainsKey(curentSale.Town))
                    salesByTown[curentSale.Town] = 0m;

                salesByTown[curentSale.Town] += curentSale.Sales;
            }

            foreach (var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }

        private static Sale GetSaleProperties()
        {
            string[] saleArgs = Console.ReadLine().Split();
            var sale = new Sale
            {
                Town = saleArgs[0],
                Price = decimal.Parse(saleArgs[2]),
                Quantity = decimal.Parse(saleArgs[3])
            };

            return sale;
        }
    }
}
