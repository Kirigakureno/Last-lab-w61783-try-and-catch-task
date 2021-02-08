using System;
public class Tasktrycatch
{
    public static void Main()
    {
        float result;
        float num;

        Console.Write("Enter Number ");
        try
        {
            num = Convert.ToSingle(Console.ReadLine());

            result = (float)Math.Sqrt(num);
            Console.WriteLine("The result is: {0}", result);
        }
        catch (Exception)
        {
            Console.WriteLine("Error, I cant calculate this stuff");
        }
    }
}
