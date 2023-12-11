namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i != 50; i++)
            {
                for(int j = 0; j != 50; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}
