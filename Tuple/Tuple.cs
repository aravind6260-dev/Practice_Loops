using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tuple;


namespace TupleConcept
{
    internal class Program
    {
        public struct StudentInfo
        {
            public string Name;
            public int Id;
            public int Age;
            public char Section;
            public int Standard;
            public int Floar;
            public int DateOfBirth;
        }
        static void Main(string[] args)
            {

                Tuple<int, double, int, char, string, double, int> tuple = new Tuple<int, double, int, char, string, double, int>(11, 25.3, 56, 'c', "Aru", 32.1, 24);
                Tuple<int, double, int, char, string, double, int> tuple1 = new Tuple<int, double, int, char, string, double, int>(12, 42.3, 42, 'a', "reddy", 23.1, 42);
                Tuple<int, double, int, char, string, double, int> tuple2 = new Tuple<int, double, int, char, string, double, int>(13, 42.3, 42, 'a', "reddy", 23.1, 42);
                Tuple<int, double, int, char, string, double, int> tuple3 = new Tuple<int, double, int, char, string, double, int>(14, 42.3, 42, 'a', "reddy", 23.1, 42);
                List<Tuple<int, double, int, char, string, double, int>> info = new List<Tuple<int, double, int, char, string, double, int>>();
                info.Add(tuple);
                info.Add(tuple1);
                info.Add(tuple2);
                info.Add(tuple3);
                for (int i = 0; i < info.Count; i++)
                {
                    Console.WriteLine(info[i].Item1);
                    Console.WriteLine(info[i].Item2);
                    Console.WriteLine(info[i].Item3);
                    Console.WriteLine(info[i].Item4);
                    Console.WriteLine(info[i].Item5);
                    Console.WriteLine(info[i].Item6);
                    Console.WriteLine(info[i].Item7);
                    Console.WriteLine();

            }
                
                Console.WriteLine("Struct: ");
                Console.WriteLine();
                StudentInfo studentInfo1 = new StudentInfo();
                StudentInfo studentInfo2 = new StudentInfo();
                StudentInfo studentInfo3 = new StudentInfo();
                studentInfo1.Name = "Aru";
                studentInfo1.Id = 135;
                studentInfo1.Age = 15;
                studentInfo1.Section = 'A';
                studentInfo1.Standard = 10;
                studentInfo1.Floar = 2;
                studentInfo1.DateOfBirth = 1999;

                studentInfo2.Name = "Ramkumar";
                studentInfo2.Id = 125;
                studentInfo2.Age = 14;
                studentInfo2.Section = 'C';
                studentInfo2.Standard = 9;
                studentInfo2.Floar = 5;
                studentInfo2.DateOfBirth = 1999;

                studentInfo3.Name = "Kishore";
                studentInfo3.Id = 120;
                studentInfo3.Age = 15;
                studentInfo3.Section = 'B';
                studentInfo3.Standard = 10;
                studentInfo3.Floar = 3;
                studentInfo3.DateOfBirth = 1999;

                List<StudentInfo> listOfStudentInfo = new List<StudentInfo>();
                listOfStudentInfo.Add(studentInfo1);
                listOfStudentInfo.Add(studentInfo2);
                listOfStudentInfo.Add(studentInfo3);


                for (int i = 0; i < listOfStudentInfo.Count; i++)
                {
                    Console.WriteLine(listOfStudentInfo[i].Name);
                    Console.WriteLine(listOfStudentInfo[i].Id);
                    Console.WriteLine(listOfStudentInfo[i].Age);
                    Console.WriteLine(listOfStudentInfo[i].Section);
                    Console.WriteLine(listOfStudentInfo[i].Standard);
                    Console.WriteLine(listOfStudentInfo[i].Floar);
                    Console.WriteLine(listOfStudentInfo[i].DateOfBirth);
                    Console.WriteLine();
                
                }
            Console.WriteLine();
            StructExample.StudentInformation student1 = new StructExample.StudentInformation("Aravind",987654,26,'B',8,2,1998);
            StructExample.StudentInformation student2 = new StructExample.StudentInformation("Aravind", 987654, 26, 'B', 8, 2, 1997);
            StructExample.StudentInformation student3 = new StructExample.StudentInformation("Aravind", 987654, 26, 'B', 8, 2, 1996);
            StructExample.StudentInformation student4 = new StructExample.StudentInformation("Aravind", 987654, 26, 'B', 8, 2, 1995);
            List<StructExample.StudentInformation> studentInformation = new List<StructExample.StudentInformation>();
            studentInformation.Add(student1);
            studentInformation.Add(student2);
            studentInformation.Add(student3);
            studentInformation.Add(student4);
            for (int i = 0;i < studentInformation.Count ;i++)
            {
                Console.WriteLine(studentInformation[i].Name);
                Console.WriteLine(studentInformation[i].Id);
                Console.WriteLine(studentInformation[i].Age);
                Console.WriteLine(studentInformation[i].Section);
                Console.WriteLine(studentInformation[i].Standard);
                Console.WriteLine(studentInformation[i].Floar);
                Console.WriteLine(studentInformation[i].DateOfBirth);
                Console.WriteLine();
            }
            foreach(var student in studentInformation)
            { 
                Console.WriteLine(student.Name); 
                Console.WriteLine(student.Id);
                Console.WriteLine(student.Age);
                Console.WriteLine(student.Section);
                Console.WriteLine(student.Standard);
                Console.WriteLine(student.Floar);
                Console.WriteLine(student.DateOfBirth);
                Console.WriteLine();
            }
            /* For single student information
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Id);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1.Section);
            Console.WriteLine(student1.Standard);
            Console.WriteLine(student1.Floar);
            Console.WriteLine(student1.DateOfBirth);
            Console.WriteLine();
            */






        }
    }
}

