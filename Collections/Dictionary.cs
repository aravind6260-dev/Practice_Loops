using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Dictionary
    {
        public Dictionary() 
        {
            Dictionary<double, string> dict = new Dictionary<double, string>();
            dict.Add(25, "aru");
            dict.Add(29, "Jai");
            
            string value = dict[25];
            
            Console.WriteLine(value);
          
            Console.WriteLine();

            foreach (var item in dict)
            {
                Console.WriteLine($"key:{item.Key},value: {item.Value}");
            }

            Dictionary<double, string> dct = new Dictionary<double, string>()
            {
                {25.222,"dvdfdf" },
                {22.333,"dfwrwrww" }
            };
            for (int i = 0; i < dct.Count; i++)
            {
                var pair = dct.ElementAt(i);
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }            
          
        }    
        
    }
}
