namespace CSharpAssignment6
{
    internal class Employee
    {
        public int Id { get; set; }
        public string fullname { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }

        public Employee() {
            Console.WriteLine("Enter details for employee");
            Console.WriteLine("Enter Id :");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter manager's name");
            Manager = Console.ReadLine();
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"id : {this.Id}");
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Manager : {this.Manager}");
            
        }
    }
}
