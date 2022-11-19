internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число: ");
        int num = int.Parse(Console.ReadLine());
        
        int rem = 0;
        int result = 0;
        int orig_num = num;

        while (num > 0)
        {
            rem = num % 10; 
            result = result * 10 + rem;
            num = num / 10;
        }

        if (orig_num == result)
        {
            Console.WriteLine($"Число {result} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {result} не является палиндромом");
        }
    }
}

