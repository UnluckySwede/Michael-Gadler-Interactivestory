using System;

namespace Michael_Gadler_Interactivestory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You should on use small letters while writing your answer! Type ok if you understand.");

            String Answer = Console.ReadLine();

            Console.ReadLine();
            if (Answer == "ok")
            {
                Console.WriteLine("What opposite of up?");
            }
            else
            {
                Console.WriteLine("kill yourself");
                Console.ReadLine();
            }

            Answer = "yes";
            Answer = Console.ReadLine();
            if (Answer == "down")
            {
            Console.WriteLine("You're Pretty Smart, but look retarded, now you can move left or right. Choose.");
            Answer = "placeholder";
            Answer = Console.ReadLine();
            if (Answer == "left" )
            {
            Console.WriteLine("You died! Noob, You wanna go to heaven or hell?");
            Answer = "placeholder";
            Answer = Console.ReadLine();
            if (Answer == "hell"){
                Console.WriteLine("Congrats the devil made you his bitch! Do you wanna embrace it or reject?");
                Answer = "placeholder";
                Answer = Console.ReadLine();
            if (Answer == "embrace"){
                Console.WriteLine("He takes a liking to you and grants you administration of hell.");
            }
            if (Answer == "reject"){
                Console.WriteLine("He locks you in his sex dungeon for eternity, torturing you with his creative sextoys.");
            }
            
            }
            if (Answer == "heaven"){
                Console.WriteLine("You wake upp seeing you mom at the door with belt in hand");
                Console.ReadLine();
            }
            }
            if (Answer == "right" ){
            Console.WriteLine("You're blind so you fall of a cliff and turn into mush");
            Console.ReadLine();
            }
            }
            else
            {
                Console.WriteLine("gay");
                Console.ReadLine();
            }
            Console.ReadLine();
            
        }
    }
}