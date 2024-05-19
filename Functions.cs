using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements2024
{
    public static class Display
    {        
        public static void PrintNumbers(int startNum, int endNum)
        {
            while (startNum >= endNum)
            {
                Console.WriteLine($"{startNum}");
                startNum--;
            }
        }        
        public static void Three(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualityCheck(int startNum, int endNum)
        {                                
            Console.Write($"The numbers provided ({startNum},{endNum}) are equal: {Functions.IsMatch(startNum, endNum)}");
        }
        public static void MultiplicatonTable(int num)
        {
            for (var i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
    public static class Functions
    {
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsMatch(int startNum, int endNum)
        {
            return startNum == endNum;
        }

        //Write a method to check whether a given number is even or odd
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num)
        {
            return num >= 0;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool VoterEligible(int num)
        {
            return num >= 18;
        }       
        public static bool IsInRange(int firstNum, int secondNum, int givenNum)
        {                   
            return (givenNum >= firstNum && givenNum <= secondNum) ? true : false;
        }        
    }
}
