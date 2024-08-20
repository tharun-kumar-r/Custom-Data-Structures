using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }

        public Employee(string name, string gender, string contactNo)
        {
            Name = name;
            Gender = gender;
            ContactNo = contactNo;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Gender: {Gender}, Contact No: {ContactNo}");
        }
    }
    
}