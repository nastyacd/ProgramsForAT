using System;

public class BaseConverter
{
    public double Convert(double value, string type)
    {
        if (type == "K")
        {
            value = value + 273.15;
        }
        if (type == "F")
        {
            value = (value * 9) / 5 + 32;
        }
        return value;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        double n;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите температуру в градусах Цельсия ");
        n = Double.Parse(Console.ReadLine());
        BaseConverter baseConverter = new BaseConverter();
        Console.WriteLine("Температура в Кельвинах  равна " + baseConverter.Convert(n, "K") + "\n");
        Console.WriteLine("Температура по Фаренгейту равна " + baseConverter.Convert(n, "F"));

    }
}

