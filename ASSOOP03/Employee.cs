using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSOOP03
{
    internal class Employee
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public Gender Gender { get; set; }

        //public SecurityLevel SecurityLevel { get; set; }

        //public decimal Salary { get; set; }
        //public DateTime HireDate { get; set; }

        //public override string ToString()
        //{
        //    return $"Id: {Id},\n" +
        //           $"Name: {Name},\n" +
        //           $"Salary: {Salary:C},\n" +
        //           $"Security Level: {SecurityLevel},\n" +
        //           $"Gender: {Gender},\n" +
        //           $"Hire Date: {HireDate:dd/MM/yyyy}";
        //}

        public int ID { get; set; }

        private string name;
        public string Name
        {
            get => name;
            set => name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        }

        private char gender;
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    gender = '_';
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get => salary;
            set => salary = value < 0 ? 0 : value;
        }

        public DateTime HireDate { get; set; }

        public SecurityLevel SecLevel { get; set; }

        public Employee()
        {
            ID = 1;
            Name = "Unknown";
            Gender = 'M';
            Salary = 0;
            HireDate = DateTime.Now;
            SecLevel = SecurityLevel.Guest;
        }

        public Employee(int id, string name, char gender, decimal salary, DateTime hireDate, SecurityLevel secLevel)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecLevel = secLevel;
        }

        public override string ToString()
        {
            return $"Id: {ID},\n" +
                   $"Name: {Name},\n" +
                   $"Salary: {Salary:C},\n" +
                   $"Security Level: {SecLevel},\n" +
                   $"Gender: {Gender},\n" +
                   $"Hire Date: {HireDate:d/M/yyyy}";
        }
    }
}

