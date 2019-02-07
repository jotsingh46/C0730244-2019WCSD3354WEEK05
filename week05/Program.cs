using System;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
            Console.ReadLine();
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

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }

        public string dog_name;
        public string dog_breed;
        public dog nextdog;
        public dog previousdog;
    }
    class birthdayParty
    {
        public dog kalu;
        public dog sheru;
        public dog fifi;

        public dog head;
        public dog tail;
        public dog temp;
        //public dog current;
    }
}
