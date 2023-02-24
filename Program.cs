using MinMaxProblems;

namespace MaxMin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = MaxMin<int>.Maximum(10, 20, 30);
            double b = MaxMin<double>.Maximum(10.20, 20.03, 30.2);
            char c = MaxMin<char>.Maximum('A', 'C', 'B');
            Console.WriteLine("Greatest Int : " + a);
            Console.WriteLine("Greatest Double : " + b);
            Console.WriteLine("Greatest Char : " + c);

        }
    }
}
