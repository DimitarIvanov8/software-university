using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._hard__Data_Overflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secondNum = ulong.Parse(Console.ReadLine());

            var smallerNum = (firstNum < secondNum) ? firstNum : secondNum;
            var biggerNum = (firstNum > secondNum) ? firstNum : secondNum;

            var biggerType = DataType(biggerNum);
            var smallerType = DataType(smallerNum);

            var overFlow = OverFlowCount(smallerType, biggerNum);         
            
            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{biggerNum} can overflow {smallerType} {overFlow} times");         
        }

        static double OverFlowCount(string smallerType, double biggerNum)
        {
            double overFlowCount = 0;

            if (smallerType == "byte")
            {
                overFlowCount = Math.Round(biggerNum / byte.MaxValue);
                return overFlowCount;
            }
            else if (smallerType == "ushort")
            {
                overFlowCount = Math.Round(biggerNum / ushort.MaxValue);
                return overFlowCount;
            }
            else if (smallerType == "uint")
            {
                overFlowCount = Math.Round(biggerNum / uint.MaxValue);
                return overFlowCount;
            }
            else if (smallerType == "ulong")
            {
                overFlowCount = Math.Round(biggerNum / ulong.MaxValue);
                return overFlowCount;
            }
            else
            {
                return 666;
            }
        }

        static string DataType(ulong biggerNum)
        {
            if (byte.MinValue <= biggerNum && biggerNum <= byte.MaxValue)
            {
                return "byte";
            }
            else if (ushort.MinValue <= biggerNum && biggerNum <= ushort.MaxValue)
            {
                return "ushort";
            }
            else if (uint.MinValue <= biggerNum && biggerNum <= uint.MaxValue)
            {
                return "uint";
            }
            else if (ulong.MinValue <= biggerNum && biggerNum <= ulong.MaxValue)
            {
                return "ulong";
            }
            else
            {
                return "Error";
            }
        }
    }
}
