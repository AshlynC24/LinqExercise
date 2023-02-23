using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    internal class Employee
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int YearsOfExperience { get; set; }
        public string V1 { get; }
        public string V2 { get; }

        public Employee(string firstName, string lastName, int age, int yearsOfExperience)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            YearsOfExperience = yearsOfExperience;
        }
        
        public Employee()
        {
            
        }

        public Employee(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }
    }
}
