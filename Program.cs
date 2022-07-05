namespace EmpWage_Csharp_Day8
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWage company1 = new EmpWage(20, 150, 40, "Apple");
            EmpWage company2 = new EmpWage(20, 140, 38, "Microsoft");
            EmpWage company3 = new EmpWage(18, 145, 42, "Google");


        }

    }
}
