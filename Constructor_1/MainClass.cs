using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_1
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Construct construct = new Construct();
            Construct construc = new Construct("aru", 29);
            Details details = new Details();
            details.Addition();
            //int output = details.Addition();  
            //Console.WriteLine($"Addition value : {output}");
            double result = Details.Multiplication(5, 3);            
            Console.WriteLine(result);             
        }
    }
    class Construct
    {
        private string _name;
        private int _value;
        public Construct()
        {
            _name = "Aru";
            _value = 12;
            Console.WriteLine("enter the details: ");
            Console.WriteLine(_name);
            Console.WriteLine(_value);
        }
        public Construct(string name, int value)
        {
            _name = name;
            _value = value;
            Console.WriteLine("enter the details: ");
            Console.WriteLine(_name);
            Console.WriteLine(_value);
        }   
    }
    class Details
    {
        public int Addition()
        {
            Console.WriteLine("Enter x1 value : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value : ");            
            int x2 = Convert.ToInt32(Console.ReadLine());
            int result = x1 + x2;               
            Console.WriteLine($"Enter the Result : {result}");
            return result;
        }
        public static double Multiplication(double x1, double x2)
        {
            return x1 * x2;
        }
        Construct construct = new Construct("aru", 29);
    }
}
