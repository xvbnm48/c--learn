namespace MyNamespace.while_loop;

public class whileLearn
{
    public static void belajarWhile(int start)
    {
        while (start > 0)
        {
            Console.WriteLine($"coutdown: {start}");
            start--;
        }
        Console.WriteLine("coutdown end");
    }
}