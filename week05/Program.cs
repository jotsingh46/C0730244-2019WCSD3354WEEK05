﻿using System;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }


    class TestQuestion2
    {
        public int myFavouriteVariable = 0;
        public void PlayingWithForLoops()
        {
            for( ; MyMethod() ; )
            {
                if (myFavouriteVariable > 10)
                {
                    Console.WriteLine("i am so out of here");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("oh no i have to go through this again");
                    
                }
            }
        }
        public bool MyMethod()
        {
            myFavouriteVariable++;
            return true;
        }
    }

}
