using System;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            //a.PlayingWithForLoops();
            

            var b = new birthdayParty();
            b.setupPartyList();
            Console.WriteLine(b.printPartyList());
            Console.WriteLine(b.printPartyList_reverse());
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
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;
        public dog Giselle;
        public dog Lulu;

        public dog head;
        public dog tail;
        public dog temp;

        public void setupPartyList()
        {
            peanut = new dog("peanut", "bichon");
            fifi = new dog("fifi", "poodle");
            clarence = new dog("Clarence", "German Sheppard");
            roy = new dog("roy", "beagle");
            Giselle = new dog("Giselle", "Border Collie");
            Lulu = new dog("Lulu", "Shitzu");


            peanut.previousdog = null;
            peanut.nextdog = fifi;
            fifi.previousdog = peanut;
            fifi.nextdog = clarence;
            clarence.previousdog = fifi;
            clarence.nextdog = Giselle;
            Giselle.previousdog = clarence;
            Giselle.nextdog = Lulu;
            Lulu.previousdog = Giselle;
            Lulu.nextdog = roy;
            roy.previousdog = Lulu;
            roy.nextdog = null;

            head = peanut;
            tail = roy;
        }
        
        public string printPartyList()
        {
            string inviteList = "---";
            temp = head;
            while(temp.nextdog != null)
            {               
                inviteList += temp.dog_name + "*---";
                temp = temp.nextdog;

            }
            inviteList += temp.dog_name + "*---";
            return inviteList;
        }

        public string printPartyList_reverse()
        {
            string inviteList = "---";
            temp = tail;
            while (temp.previousdog != null)
            {             
                inviteList += temp.dog_name + "*---";
                temp = temp.previousdog;

            }
            inviteList += temp.dog_name + "*---";
            return inviteList;
        }
    }
}
