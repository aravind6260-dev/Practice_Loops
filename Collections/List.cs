using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class List
    {
        static void Main(string[] args)
        {

            //List
            List<string> list = new List<string>();
            list.Add("aRU");
            list.Add("Reddy");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }
            Console.WriteLine();
            //Console.WriteLine(string.Join(" ", list));

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            List<(int, string)> listing = new List<(int, string)> 
            {
                (23, "Aravind"),
                (22,"Reddy")
            };
           
            for (int i = 0; i < listing.Count; i++)
            {
                Console.WriteLine(listing[i]);

            }
            Console.WriteLine();
            List<(double, string)> listIn = new List<(double, string)>();
            listIn.Add((12.55, "Pavan"));
            listIn.Add((12, "Kumar"));
            for(int i = 0;i < listIn.Count; i++)
            {
                Console.WriteLine(listIn[i]);
            }
            Dictionary dictionary = new Dictionary();
            Arrays arrays = new Arrays();
        }
        
}
}
