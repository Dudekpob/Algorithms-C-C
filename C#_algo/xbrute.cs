using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace app
{   
    public class _2
    {
        private Stopwatch stopwatch = new Stopwatch();
        public void Calculate()
        {
            Random number = new Random();

            int MiddleNumber = number.Next(100,999);

            string MiddleNumberUniqueCheck = MiddleNumber.ToString();
            int firstnumber;        
            int secondthirdnumber; 
            int fourthfivenumber;  
            int sixnumber;          
            stopwatch.Start();
            bool flag = false;
            bool checkflag = false;
            bool first = false;
            bool second = false;
            bool third = false;
            bool fourth = false;
            bool five = false;
            while(!flag)
            {
                firstnumber = number.Next(1,9);
                secondthirdnumber =  number.Next(10,99);
                fourthfivenumber =  number.Next(10,99);
                sixnumber = number.Next(1,9);
                checkflag = false;
                MiddleNumber = number.Next(100,999);
               MiddleNumberUniqueCheck = MiddleNumber.ToString();
                while(!checkflag)
                {
                    if(firstnumber != (int)(secondthirdnumber.ToString()[0]) - 48 && firstnumber != (int)(secondthirdnumber.ToString()[1]) - 48 
                    && firstnumber != (int)fourthfivenumber.ToString()[0]-48 && firstnumber != (int)fourthfivenumber.ToString()[1]-48
                    && firstnumber != sixnumber && firstnumber != (int)MiddleNumberUniqueCheck.ToString()[0]-48 
                    && firstnumber != (int)MiddleNumberUniqueCheck.ToString()[1] && firstnumber != (int)MiddleNumberUniqueCheck.ToString()[2]-48)
                    {
                        first = true;
                    }
                     if((int)(secondthirdnumber.ToString()[0]) - 48!= (int)(secondthirdnumber.ToString()[1]) - 48 && firstnumber != (int)(secondthirdnumber.ToString()[1]) - 48
                    && (int)(secondthirdnumber.ToString()[0]) - 48 != firstnumber && (int)(secondthirdnumber.ToString()[0]) - 48 != MiddleNumber.ToString()[0] 
                    && (int)(secondthirdnumber.ToString()[0]) - 48 != (int)MiddleNumberUniqueCheck.ToString()[1]-48 &&  (int)(secondthirdnumber.ToString()[1]) - 48!= (int)MiddleNumberUniqueCheck.ToString()[2]-48
                    && (int)(secondthirdnumber.ToString()[1]) - 48!=  (int)MiddleNumberUniqueCheck.ToString()[0]-48 
                    && (int)(secondthirdnumber.ToString()[1]) - 48 != (int)MiddleNumberUniqueCheck.ToString()[1]-48 &&  (int)(secondthirdnumber.ToString()[1]) - 48 != (int)MiddleNumberUniqueCheck.ToString()[2]-48
                    && (int)(secondthirdnumber.ToString()[0]) - 48 != (int)fourthfivenumber.ToString()[0]-48  && (int)(secondthirdnumber.ToString()[0]) - 48 != (int)fourthfivenumber.ToString()[1]-48 
                    && (int)(secondthirdnumber.ToString()[1]) - 48 != (int)fourthfivenumber.ToString()[0]-48  && (int)(secondthirdnumber.ToString()[1]) - 48 != (int)fourthfivenumber.ToString()[1]-48 
                    && (int)(secondthirdnumber.ToString()[0]) - 48 != sixnumber && (int)(secondthirdnumber.ToString()[1]) - 48 != sixnumber) 
                    {
                        second = true;
                    }
                    if((int)fourthfivenumber.ToString()[0]-48  != (int)fourthfivenumber.ToString()[1]-48  && firstnumber != (int)fourthfivenumber.ToString()[1]-48 
                    && (int)fourthfivenumber.ToString()[0]-48  != firstnumber && (int)fourthfivenumber.ToString()[0]-48 != (int)MiddleNumberUniqueCheck[0]-48 
                    && (int)fourthfivenumber.ToString()[0]-48  != (int)MiddleNumberUniqueCheck[1] - 48 &&  (int)fourthfivenumber.ToString()[0]-48 != (int)MiddleNumberUniqueCheck[2] - 48
                    && (int)fourthfivenumber.ToString()[1]-48  != (int)MiddleNumberUniqueCheck[0] - 48
                    && (int)fourthfivenumber.ToString()[1]-48  != (int)MiddleNumberUniqueCheck[1] - 48 && (int)fourthfivenumber.ToString()[1]-48 != (int)MiddleNumberUniqueCheck[2]-48 
                    && (int)fourthfivenumber.ToString()[0]-48  != (int)(secondthirdnumber.ToString()[0]) - 48 && (int)fourthfivenumber.ToString()[0]-48  != (int)(secondthirdnumber.ToString()[1]) - 48
                    && (int)fourthfivenumber.ToString()[1]-48  != (int)(secondthirdnumber.ToString()[0]) - 48 && (int)fourthfivenumber.ToString()[1]-48  != (int)(secondthirdnumber.ToString()[1]) - 48
                    && (int)fourthfivenumber.ToString()[0]-48  != sixnumber && (int)fourthfivenumber.ToString()[1]-48  != sixnumber) 
                    {
                        third = true;
                    }
                     if(sixnumber != (int)(secondthirdnumber.ToString()[0]) - 48 && sixnumber != (int)(secondthirdnumber.ToString()[1])-48
                    && sixnumber != (int)fourthfivenumber.ToString()[0]-48 && sixnumber != (int)fourthfivenumber.ToString()[1]-48
                    && firstnumber != sixnumber && sixnumber != (int)MiddleNumberUniqueCheck.ToString()[0]-48
                    && sixnumber != (int)MiddleNumberUniqueCheck.ToString()[1]-48 && sixnumber != (int)MiddleNumberUniqueCheck.ToString()[2]-48)
                    {
                        fourth = true;
                    }
                    if((int)MiddleNumberUniqueCheck.ToString()[0]-48 != firstnumber && (int)MiddleNumberUniqueCheck.ToString()[1]-48 != firstnumber && (int)MiddleNumberUniqueCheck.ToString()[2]-48 != firstnumber &&
                       (int)MiddleNumberUniqueCheck.ToString()[0]-48 != sixnumber && (int)MiddleNumberUniqueCheck.ToString()[1]-48 != sixnumber && (int)MiddleNumberUniqueCheck.ToString()[2]-48 != sixnumber  &&
                       (int)MiddleNumberUniqueCheck.ToString()[0]-48 != (int)(secondthirdnumber.ToString()[0]) - 48 && (int)MiddleNumberUniqueCheck.ToString()[0]-48 != (int)(secondthirdnumber.ToString()[1]) - 48 &&
                       (int)MiddleNumberUniqueCheck.ToString()[1]-48 != (int)(secondthirdnumber.ToString()[0]) - 48 && (int)MiddleNumberUniqueCheck.ToString()[1]-48 != (int)(secondthirdnumber.ToString()[1]) - 48 && 
                       (int)MiddleNumberUniqueCheck.ToString()[2]-48 != (int)(secondthirdnumber.ToString()[0]) - 48 && (int)MiddleNumberUniqueCheck.ToString()[2]-48 != (int)(secondthirdnumber.ToString()[1]) - 48 && 
                       (int)MiddleNumberUniqueCheck.ToString()[0]-48 != (int)(fourthfivenumber.ToString()[0]) - 48  && (int)MiddleNumberUniqueCheck.ToString()[0]-48 != (int)(fourthfivenumber.ToString()[1]) - 48  &&
                       (int)MiddleNumberUniqueCheck.ToString()[1]-48 != (int)(fourthfivenumber.ToString()[0]) - 48  && (int)MiddleNumberUniqueCheck.ToString()[1]-48 != (int)(fourthfivenumber.ToString()[1]) - 48  &&
                       (int)MiddleNumberUniqueCheck.ToString()[2]-48 != (int)(fourthfivenumber.ToString()[0]) - 48  && (int)MiddleNumberUniqueCheck.ToString()[2]-48 != (int)(fourthfivenumber.ToString()[1]) - 48)
                        {
                            five = true;
                        }



                    if(first && second && third && fourth && five)
                    {
                        if(firstnumber*secondthirdnumber == MiddleNumber && MiddleNumber == sixnumber * fourthfivenumber)
                        {
                            flag = true;                       
                            Console.Write(firstnumber.ToString()+"*"+secondthirdnumber.ToString()+"="+MiddleNumber.ToString()+"="+fourthfivenumber+"*"+sixnumber);
                        }
                    }

                    first = false;
                    second = false;
                    third = false;
                    fourth = false;
                    five = false;
                    checkflag = true;

                }
                 
            }
       
            stopwatch.Stop();
         
            Console.Write(stopwatch.ElapsedMilliseconds);
            }
    };
            




  
    
    class Program
    {
        
        static void Main(string[] args)
        {
          _2 dada = new _2();
          dada.Calculate();
           
        }
    }
}
