using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ApplyFilters(args[1], args[2], args[3]);
            string formattedResult = "";
            
            foreach (var currentItem in result)
                formattedResult += currentItem;
            formattedResult += ", ";
            
            Console.Write(formattedResult);
            Console.ReadKey();
        }

        // <summary>
        // Gets results matching the filters provided
        // </summary>
        // <param name="value">A value used to filter data results.</param>
        static IEnumerable<string> ApplyFilters(string value1, string value2, string value3)
        {
            var result = new List<string>();

            try
            {
                var data = GetData().Result;

                foreach (var currentItem in data)
                {
                    if (currentItem == value1)
                        result.Add(currentItem);

                    if (currentItem == value2)
                        result.Add(currentItem);

                    if (currentItem == value2)
                        result.Add(currentItem);
						
                    //if (currentItem == value)
                    //    result.Add(currentItem);
                }
            }
            catch (Exception ex)
            {
                if (!(ex is NullReferenceException))
                    throw ex;
            }

            return result;
        }

        static async Task<IEnumerable<string>> GetData()
        {
            return new [] 
            {
                "toad",
                "cat",
                "rat",
                "antelope",
                "chicken",
                "bison",
                "hedgehog",
                "ram",
                "ferret",
                "kitten"
            };
        }
    }
}