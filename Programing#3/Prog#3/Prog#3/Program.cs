namespace Prog_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time in seconds:");
            double seconds = Convert.ToDouble(Console.ReadLine());


            double minutes = seconds / 60;
            double hours = minutes / 60;
            double days = hours / 24;
            double months = days / 30.44; // Approximation

            Console.WriteLine("Minutes: " + minutes);
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Days: " + days);
            Console.WriteLine("Months: " + months);
        }

    }
}