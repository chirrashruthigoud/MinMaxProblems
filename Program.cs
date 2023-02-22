using MinMaxProblems;

namespace MaxMin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "sunny";
            string str1 = "siri";
            string str2 = "Shruthi";

            string Max = MinMax.MaximumIntNum(str, str1, str2);
            Console.WriteLine(Max);
        }
    }
}
