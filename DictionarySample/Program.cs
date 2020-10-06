using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare decitionary
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Adding data elements in dictionary
            dict.Add(1, 12);
            dict.Add(2, 44);
            dict.Add(3, 55);
            dict.Add(4, 55);
            Console.WriteLine(dict[4]);

            foreach(var dic in dict)
            {
                Console.WriteLine(dic);               
            }

            Dictionary<string, Country> dictCountry = new Dictionary<string, Country>();
            Country c1 = new Country("RO", "Romania");
            Country c2 = new Country("SK", "Slovakia");
            Country c3 = new Country("DK", "Denamark");
            Country c4 = new Country("BD", "Bangladesh");


            dictCountry.Add(c1.Code, c1);
            dictCountry.Add(c2.Code, c2);
            dictCountry.Add(c3.Code, c3);
            dictCountry.Add(c4.Code, c4);

            foreach (var dic in dictCountry.Values)
            {

                //Console.WriteLine(dic);
                Console.WriteLine(dic.Name);
                Console.WriteLine(dic.Code);
            }




            Console.ReadKey();

        }
    }
}
