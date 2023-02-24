using MinMaxProblems;

namespace MaxMin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 112, 344, 432, 555, 678 };
            Maximum<int> generic = new Maximum<int>(arr);
            generic.PrintMaxValue();

        }
    }
}
