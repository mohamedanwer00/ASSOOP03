using System.Transactions;

namespace ASSOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter Name :");
            //string name = Console.ReadLine();
            //Console.Write("Enter ID :");
            //int id = int.Parse(Console.ReadLine());
            //Console.Write("Enter Salary :");
            //decimal salary = decimal.Parse(Console.ReadLine());
            //Console.Write("Enter Hire Date (dd/MM/yyyy) :");
            //DateTime hireDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            //Console.Write("Enter Security Level :");
            //string securityLevel = Console.ReadLine();
            //Console.Write("Enter Gender :");
            //string gender = Console.ReadLine();



            ////if (!Enum.TryParse<Gender>(gender, true, out Gender genderValue))
            ////{
            ////    Console.WriteLine("Invalid gender value. Must be Male or Female.");
            ////    return;
            ////}





            //Employee employee = new Employee
            //{
            //    Id = id,
            //    Name = name,
            //    Salary = salary,
            //    HireDate = hireDate,
            //    SecurityLevel = Enum.TryParse(securityLevel, true, out SecurityLevel level) ? level : SecurityLevel.guest,
            //    Gender = Enum.TryParse(gender, true, out Gender g)? g : Gender.Undefined,
            //};
            //employee.ToString();
            //Console.WriteLine(employee.ToString());
            #endregion

            #region Q2
            //Console.Write("Enter Day :");
            //int d = int.Parse(Console.ReadLine());
            //Console.Write("Enter Month :");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Enter Year :");
            //int y = int.Parse(Console.ReadLine());

            //HiringDate hiringDate = new HiringDate(d, m, y);
            //Console.WriteLine($"Hiring Date: {hiringDate}");

            #endregion

            #region Q3
            //Employee emp1 = new Employee();
            //Console.WriteLine("Default Employee:");
            //Console.WriteLine(emp1.ToString());
            Employee[] emp= new Employee[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");
                Console.Write("Enter Name :");
                string name = Console.ReadLine();
                Console.Write("Enter ID :");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Salary :");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.Write("Enter Gender :");
                char gender = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Enter Hire Date (dd/MM/yyyy) :");
                DateTime hireDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                Console.Write("Enter Security Level :");
                string securityLevel = Console.ReadLine();
                emp[i] = new Employee
                {
                    ID = id,
                    Name = name,
                    Salary = salary,
                    HireDate = hireDate,
                    Gender = gender,
                    SecLevel = Enum.TryParse(securityLevel, true, out SecurityLevel level) ? level : SecurityLevel.Guest,
                };
                //Console.WriteLine($"employee : {i+1}");
                //Console.WriteLine(emp[i].ToString());

            }
            Console.WriteLine("All Employees:");
            foreach (var employee in emp)
            {
                Console.WriteLine(employee.ToString());
            }




            #endregion

        }
    }
}
