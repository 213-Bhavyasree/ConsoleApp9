using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bhavya", "Kavya", "Navya",
                       "Dharmaja", "Mounika", "Nandu",
                       "Sugu", "Sandy" };

            //Using LINQ Queries
            UsingLinq(names);
        }

        private static void UsingLinq(string[] names)
        {
            IEnumerable<string> query = from a in names
                                        where a.Length == 5
                                        orderby a
                                        select a.ToUpper();

            //select * from
            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}

