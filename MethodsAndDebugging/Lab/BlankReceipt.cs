using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintBlankReceiptHeader();
            PrintBlankReceiptBody();
            PrintBlankReceiptFooter();
        }

        private static void PrintBlankReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        private static void PrintBlankReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintBlankReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
    }
}
