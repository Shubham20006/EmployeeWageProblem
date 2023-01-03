namespace EmployeeWageProblem
{
    public class Wage
    {
        public static void Main(string[] args)
        {
            Employee TCS=new Employee("TCS",40,25,150);           
            TCS.EmpComputation();
            Console.WriteLine(TCS.Return());

            Employee Reliance = new Employee("Reliance", 45, 23, 150);
            Reliance.EmpComputation();
            Console.WriteLine(Reliance.Return());
        }
    }
}
