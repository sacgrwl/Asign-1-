namespace Pro_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = (i % 3 == 0 && i % 5 == 0) ? "Hello Goodbye" :
                                (i % 3 == 0) ? "Hello" :
                                (i % 5 == 0) ? "Goodbye" :
                                i.ToString();

                Console.WriteLine(output);
            }
        }
    }
}