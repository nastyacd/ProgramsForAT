using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;


public class Program
{
    public static void Main(string[] args)
    {
        //Your code goes here
        int n;
        double average = 0;
        Random rand = new Random();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите число эл-тов массива");
        n = int.Parse(Console.ReadLine());

        double[] nums = new double[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.NextDouble();
            Console.WriteLine("Элемен с индексом " + i + " = " + nums[i]);
        }

        double max = nums[0];
        double min = nums[0];

        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
                max = nums[i];
            if (min > nums[i])
                min = nums[i];

            sum = sum + nums[i];
        }
        average = sum / nums.Length;
        Console.WriteLine("max= " + max);
        Console.WriteLine("min= " + min);
        Console.WriteLine("average= " + average);
    }
}
