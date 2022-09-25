void Polindrom()
{
    int NumberOne(int num, int Numbers)
    {
        while (num / Math.Pow(10, Numbers) > 1)
        {
            num /= 10;
        }
        return num;
    }
    Console.WriteLine("Введите пятизначное число");
    int number = int.Parse(Console.ReadLine());// 1234265735
    if (number < 0) number *= -1;
    if (number > 9999)
    {
        int x = number % 100;
        int y = NumberOne(number, 2);
        if (x / 10 == y % 10 && x % 10 == y / 10)
        {
            Console.WriteLine("Полиндром");
        }
        else
        {
            Console.WriteLine("Не Полиндром");
        }
    }
    else
    {
        Console.WriteLine("Введите число больше ");
        Polindrom();
    }
}

Polindrom();
