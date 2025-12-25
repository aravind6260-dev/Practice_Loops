using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tuple
{
    internal class StructExample
    {
        public struct StudentInformation
        {
            /*public string Name { get; set; }
            public int Id { get; set; }
            public int Age { get; set; }
            public char Section {  get; set; }
            public int Standard { get; set; }
            public int Floar {  get; set; }
            public int DateOfBirth {  get; set; }*/

            public string Name ;
            public int Id;
            public int Age;
            public char Section;
            public int Standard;
            public int Floar;
            public int DateOfBirth;

            public StudentInformation(string name, int id, int age, char section, int standard, int floar, int dateofbirth)
            {
                Name = name;
                Id = id;
                Age = age;
                Section = section;
                Standard = standard;
                Floar = floar;
                DateOfBirth = dateofbirth;

            }

        }

    }
}
