namespace CSharpAssignment6
{
    internal class PayrollEmployee : Employee
    {
        public DateOnly JoiningDate { get; set; }
        public float ExpInYears { get; set; }
        public double BasicSalary { get; set; }
        private double DA { get; set; }
        private double HRA { get; set; }
        private double PF { get; set; }
        private double NetSalary { get; set; }

        public void CalculateNetSalary()
        {
            if (this.ExpInYears > 10)
            {
                this.DA = this.BasicSalary * (0.1);
                this.HRA = this.BasicSalary * (0.085);
                this.PF = 6200;
                this.NetSalary= this.DA + this.HRA - this.PF + this.BasicSalary;
            }else if (this.ExpInYears > 7)
            {
                this.DA = this.BasicSalary * (0.07);
                this.HRA = this.BasicSalary * (0.065);
                this.PF = 4100;
                this.NetSalary = this.DA + this.HRA - this.PF + this.BasicSalary;
            }else if(this.ExpInYears > 5)
            {
                this.DA = this.BasicSalary * (0.041);
                this.HRA = this.BasicSalary * (0.038);
                this.PF = 1800;
                this.NetSalary = this.DA + this.HRA - this.PF + this.BasicSalary;
            }
            else
            {
                this.DA = this.BasicSalary * (0.019);
                this.HRA = this.BasicSalary * (0.020);
                this.PF = 1200;
                this.NetSalary = this.DA + this.HRA - this.PF + this.BasicSalary;
            }
        }

        public PayrollEmployee(): base()
        {
            try
            {
                Console.WriteLine("Enter Joining Date in DD/MM/YYYY :");
                this.JoiningDate = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter Experience in Years :");
                this.ExpInYears = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Basic Salary :");
                this.BasicSalary = double.Parse(Console.ReadLine());
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            CalculateNetSalary();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Joining Date : {this.JoiningDate}");
            Console.WriteLine($"Experiance in Years : {this.ExpInYears}");
            Console.WriteLine($"Basic Salary : {this.BasicSalary}");
            Console.WriteLine($"DA : {this.DA}");
            Console.WriteLine($"HRA : {this.HRA}");
            Console.WriteLine($"PF : {this.PF}");
            Console.WriteLine($"Net  : {this.NetSalary}");
        }
    }
}   
