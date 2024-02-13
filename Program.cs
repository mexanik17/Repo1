namespace Repo1
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

            Console.ReadLine();
        }

        static bool VisokosYear(int year)
        {
            // Проверяем, делится ли год на 4 без остатка.
            // Если да, то он високосный, иначе - нет.
            return year % 4 == 0;
        }
    }
}
