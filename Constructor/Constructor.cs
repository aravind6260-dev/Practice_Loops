using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Constructor
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student("Aravind", 28);
            objStudent.StudentInfo();
            int Add = objStudent.Addtion(10, 50);
            Console.WriteLine(Add);
            AClass objAclass = new AClass();
            objAclass.Aravind();
            objAclass.Yogi();
            AClass.Karthik();
            AClass.Kisohor();

        }
    }
    class Student
    {
        //Global Varibles...
        //Member variables both are same..
        public string studentName;
        public int studentAge;
        //Constructor..
        public Student()//Method//No Return for Constructor.. 
        {
            studentName = "Ramu";
            studentAge = 35;
            Console.WriteLine("Deafult constructor is called");
        }
        //Parameterized constructor..
        public Student(string name, int age)
        {
            studentName = name;
            studentAge = age;
            Console.WriteLine("Parametarized constructor is called");
        }
        public void StudentInfo()
        {
            
            Console.WriteLine(studentName);
            Console.WriteLine(studentAge);
        }
        public int Addtion(int val1, int val2)
        {
            int resutl = val1 + val2;
            return resutl;
        }
    }
    class AClass
    {
        public void Aravind()
        {
            Console.WriteLine("Aravind Called");
        }
        public void Yogi()
        {
            Console.WriteLine("Yogi Called");
        }
        public static void Karthik()
        {
            Console.WriteLine("Karthik Called");
        }
        public static void Kisohor()
        {
            Console.WriteLine("Kishore Called");
        }
    }


}
