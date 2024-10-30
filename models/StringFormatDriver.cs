using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_30_a_strings.models
{
    public static class StringFormatDriver
    {
        public static void Run()
        {
            // Console.WriteLine("StringFormatDriver");
            FixedWidthFormatting();
            FixedWidthWithHeader();
        }
        public static void FixedWidthFormatting()
        {
            string name = "Alice";
            string city = "Seattle";
            string product = "Laptop";
            double price = 999.99;
            string product2 = "Piano";
            double price2 = 777.77;

            Console.WriteLine($"{name}:{city}");
            Console.WriteLine($"{name.PadLeft(10)}");
            Console.WriteLine($"{city.PadLeft(10)}");
            // right aligning, and filling out the spaces with an * 
            Console.WriteLine($"{name.PadLeft(10, '*')}");
            Console.WriteLine($"{city.PadLeft(10, '*')}");

            // product, 15: aligns the product to the right with 15 chars
            // price, -10 aligns price to the left with width of 10 chars
            Console.WriteLine($"|{product,15}|{price,-10} | ---");
            Console.WriteLine($"|{product2,15}|{price2,-10} | ---");
        }

        public static void FixedWidthWithHeader()
        {

            string[] headers = { "ID", "Name", "Occupation" };
            string[,] data = {
                    {"1", "Alice", "Engineer"},
                    {"2", "Bob", "Doctor"},
                    {"3", "Cathy", "Designer" }

            };


            Console.WriteLine($"|{headers[0],-5}|{headers[1],-10}|{headers[2],-12}");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine($"|{data[i,0],-5}|{data[i, 1],-10}|{data[i, 1],-12}");

            }


        }
    }
}
