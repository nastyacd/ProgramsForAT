
using System;

public class Clock
{
    public double angle(int hour, int minutes)
    {
        double value;
        value = Math.Abs((hour * 30 + minutes * 0.5) - (minutes * 6));
        return Math.Abs(Math.Min(360 - value, value));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int hour;
        int minutes;
        double angle;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        do
        {
            Console.WriteLine("Для того, чтобы определить какой угол образует минутная и часовая стрелка введите значение hour");
            hour = int.Parse(Console.ReadLine());
            if (hour > 12)
            {
                Console.WriteLine("Введите значение часовой стрелки от 0 до 12" + "\n");
            }
        }
        while (hour > 12);

        do
        {
            Console.WriteLine("Далее введите minutes");
            minutes = int.Parse(Console.ReadLine());
            if (minutes > 59)
            {
                Console.WriteLine("Введите значение минутной стрелки от 0 до 59" + "\n");
            }

        }
        while (minutes > 59);
        Clock clock = new Clock();
        angle = clock.angle(hour, minutes);
        Console.WriteLine("Угол между минутной и часовой стрелкой = " + angle);


    }
}
