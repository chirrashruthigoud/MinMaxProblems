using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxProblems
{
    public class MinMax
    {
        public static int MaximumIntNum(int fNumber, int sNumber, int thirdNumber)
        {
            if ((fNumber.CompareTo(sNumber) > 0 && fNumber.CompareTo(thirdNumber) > 0) ||
                (fNumber.CompareTo(sNumber) >= 0 && fNumber.CompareTo(thirdNumber) > 0) ||
                (fNumber.CompareTo(sNumber) > 0 && fNumber.CompareTo(thirdNumber) >= 0))
            {
                return fNumber;
            }

            if ((sNumber.CompareTo(fNumber) > 0 && sNumber.CompareTo(thirdNumber) > 0) ||
               (sNumber.CompareTo(fNumber) >= 0 && sNumber.CompareTo(thirdNumber) > 0) ||
               (sNumber.CompareTo(fNumber) > 0 && sNumber.CompareTo(thirdNumber) >= 0))
            {
                return sNumber;
            }


            if ((thirdNumber.CompareTo(fNumber) > 0 && thirdNumber.CompareTo(sNumber) > 0) ||
               (thirdNumber.CompareTo(fNumber) >= 0 && thirdNumber.CompareTo(sNumber) > 0) ||
               (thirdNumber.CompareTo(fNumber) > 0 && thirdNumber.CompareTo(sNumber) >= 0))
            {
                return thirdNumber;
            }
            return fNumber;
        }

        public static string MaximumIntNum(string first, string second, string third)
        {
            if (first.Length > second.Length && first.Length > third.Length)
            {
                return "First is Greatest";
            }
            else if (second.Length > second.Length && second.Length > third.Length)
            {
                return "Second is Greatest";
            }
            else if (third.Length > first.Length && third.Length > second.Length)
            {
                return "Third is Greatest";
            }
            else
            {
                return "Every string is same";
            }
        }

    }
}
