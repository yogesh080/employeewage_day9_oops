namespace EmpWage_Csharp_Day8
{
    public class Program
    {
        /// <summary>
        /// Greeting message to welcome in this program.
        /// </summary>
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
            EmpWage company1 = new EmpWage(20, 150, 40, "Apple");
            EmpWage company2 = new EmpWage(20, 140, 38, "Microsoft");
            EmpWage company3 = new EmpWage(18, 145, 42, "Google");


        }

    }
}
