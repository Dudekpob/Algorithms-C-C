using System;

namespace _1_count
{
    class Program
    {
        public static int CountElements(int n)
        {
            int i;
            int sum = 0;
            int temp = n;
            for (i = 0; i < n; i++)
            {
                sum += temp * temp;
                temp--;
            }
            return sum;
        }

        public static int GetBlockNumber(int Row, int Column, int Level, int n)
        {

            int Ans = 0;
            int sum = 0;
            int temp = n;
            
            for (int i = 0; i <= n; i++)
            {
                sum += temp * temp;              
                if (i == Level-1)
                { 
                    if(Row == 1)
                    {
                        Ans = sum - ((temp * temp))  + (Column);
          
                    }
                    else if (Row > 1)
                    {
                        Ans = sum - ((temp * temp)) + ((Row-1)*temp) + (Column);
                    }

                }
                temp--;
            }
            return Ans;
        }





        static void Main(string[] args)
        {
            Console.Write(GetBlockNumber(3,2,1,4));
        }
    }
}
