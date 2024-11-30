using System.Numerics;

namespace Project10
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter contractor name.");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter contractor number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the start date.");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1 for day shift. Enter 2 for night shift.");
            int shift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the hourly wage.");
            double payrate = Convert.ToDouble(Console.ReadLine());
            Subcontractor sub1 = new Subcontractor(userName, number, start, shift, payrate);

            double PayrollCalc(double payrate, int shift, DateTime start)
            {
                double pay = payrate * (DateTime.Now - start).TotalHours;
                if (shift == 2)
                {
                    pay *= 1.03;
                }
                    return pay;
            }
            double payroll = PayrollCalc(payrate, shift, start);
            Console.WriteLine($"{userName} earned ${payroll:F2} in this pay period.");
            
        }


    }
}
