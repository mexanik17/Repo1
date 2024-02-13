namespace Repo2
{
    class Programm
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

        }

        static bool VisokosYear(int year)
        {
            // Год високосный, если он делится на 4 без остатка,
            // но при этом не делится на 100 без остатка, или делится на 400 без остатка.
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        }
    }
}
