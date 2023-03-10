namespace Common;


public static class Get
{
    public static int ReadNumber(string s)
    {
        while (true)
        {
            Console.Write(s);
            string text = Console.ReadLine();
            if (int.TryParse(text, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }


    public static int GetNumberFromUser()
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            return GetNumberFromUser();
        }
    }
    public static int GetNumberOfQuarter(int x, int y)
    {
        if (x > 0 && y > 0) return 1;
        if (x < 0 && y > 0) return 2;
        if (x < 0 && y < 0) return 3;
        if (x > 0 && y < 0) return 4;
        return -1;
    }
}
