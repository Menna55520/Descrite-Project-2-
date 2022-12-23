namespace perfect_num
{
    internal class Program
    {
        static bool IsPerfect(int number)
        {
            int sum = 0;
            for(int i=1;i<number;i++)
            {
                if (number % i == 0) 
                    sum = sum + i;
            }
            if (sum == number) return true;
            return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER THE FIRST NUMBER");
            int NUM1 = int.Parse(Console.ReadLine());
            Console.WriteLine("PLEASE ENTER THE SECOND NUMBER");
            int NUM2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i=NUM1;i<=NUM2;i++)
            {
                if (IsPerfect(i))
                    Console.WriteLine(i);
            }

        }
    }
}