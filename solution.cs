using System;
using System.Collections;

namespace CodTest
{
    class Program
    {
        static int solution(int N)
        {
            int tempN = Math.Abs(N);
            int result;
            string tempStr = "";

            if (N > 0)
            {
                ArrayList tempArr = new ArrayList();
                while (tempN % 10 != tempN)
                {
                    tempArr.Add(tempN % 10);
                    tempN = tempN / 10;
                }
                tempArr.Add(tempN);

                int arrSize = tempArr.Count;
                int compareInt = 5;

                for (int i = arrSize; i > 0 ; i--)
                {
                    if (Convert.ToInt32(tempArr[i - 1]) < compareInt)
                    {
                        tempStr = tempStr + "5";
                        compareInt = -100000;
                    }
                    tempStr = tempStr + Convert.ToString(tempArr[i-1]);
                }
                if (compareInt == 5) //to add 5 as last digit
                {
                    tempStr = tempStr + "5";
                }
                result = Convert.ToInt32(tempStr);
            }
            else
            {
                tempStr = "-" + "5" + tempStr;
                result = Convert.ToInt32(tempStr);
            }
            return result;
        }

        static void Main(string[] args)
        {
            int test = 67;
            int a = solution(test);
            Console.WriteLine($"Result : {a}");
            Console.ReadLine();
        }
    }
}

