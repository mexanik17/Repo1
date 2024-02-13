namespace Repo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (VisokosYear(year))
            {
                Console.WriteLine("{0} год - високосный.", year);
            }
            else
            {
                Console.WriteLine("{0} год - не високосный.", year);
            }

            Console.ReadLine();
        }

        static bool VisokosYear(int year)
        {
            
            return year % 4 == 0;
        }
    }
}
