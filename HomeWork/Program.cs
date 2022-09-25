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

void Zadacha21()
{
    Console.WriteLine("Введите координаты первой точки ");
    Console.WriteLine("X =  ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Y =  ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Z =  ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки ");
    Console.WriteLine("X =  ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Y =  ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Z =  ");
    double z2 = Convert.ToDouble(Console.ReadLine());
    double Distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine(Distanse);
}

Zadacha21();
