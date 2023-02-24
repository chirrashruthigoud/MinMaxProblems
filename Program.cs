using MinMaxProblems;

namespace MaxMin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxMin<int> max = new MaxMin<int>(10, 20, 30);
            int c = max.maxvalue();
            Console.WriteLine(c);

        }
    }
}
