using System.Net.Http.Headers;
using System.Xml.Linq;

namespace CSharpAssignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee employee1 = null;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter choice 1: Add Employee 2: Display All Employees 3.Display Total no of employees  4.Exit ");
                byte c = byte.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("Which employee do you want to add ? 1: payroll employee 2 : Contract Employee");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            employee1 = new PayrollEmployee();
                            employees.Add((PayrollEmployee)employee1);

                        }
                        else if (choice == 2)
                        {
                            employee1 = new ContractEmployee();
                            employees.Add((ContractEmployee)employee1);
                        }
                        break;
                    case 2:
                        Console.WriteLine("All Employees:");
                        foreach (var employee in employees)
                        {
                            employee.DisplayDetails();
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Total no of employees : ");
                        Console.WriteLine(employees.Count());
                        Console.WriteLine();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
        
    }
}
