using System;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string str = "Hello";
        char[] arr = str.ToCharArray(0, str.Length);
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine("Повторяющийся символ " + arr[i]);
                    break;
                }
            }
        }
    }
}
