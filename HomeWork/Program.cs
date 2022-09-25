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
    Console.WriteLine("Введите пятизначное число и Мы узнаем является ли оно Полиндромом ");
    int number = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Не Полиндром ");
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
    Console.WriteLine("Узнаем расстояние между двумя точками в пространстве  ");
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

void Zadacha23()
{
    Console.WriteLine("Введите число и Мы увидем все числа до него в степени 3 ");
    int number = int.Parse(Console.ReadLine());
    int[] array = new int[number];
    for (int i = 1; i <= array.Length; i++)
    {
        int n = Convert.ToInt32(Math.Pow(i, 3));
        Console.WriteLine(n);
    }

}

Polindrom();
Zadacha21();
Zadacha23();
