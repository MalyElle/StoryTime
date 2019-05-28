using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maly Fairytale!");

            Console.WriteLine("Choose your title: 'Princess', 'Prince'");

            string answer = Console.ReadLine();

            if (answer == "Princess")
            {
                Console.WriteLine("You are a Princess who is stuck in a tower with a fire breathing dragon. You are waiting for a prince to come and rescue you, and also plotting your own way to escape");
            }
            else if (answer == "Prince")
            {
                Console.WriteLine("You are a Prince who is going on a journey and heard of a princess who need to be save."); 
            }

            Console.WriteLine("If you are a princess or prince, pick your task: PrincessTask, PrinceTask");

            string task = Console.ReadLine();

            if (task == "PrincessTask")
            {
                Console.WriteLine("Princess, You are thinking ways to escape the dragon lair. The dragon is blocking the only door to escape!");
            }
            else if (task == "PrinceTask")
            {
                Console.WriteLine("Prince, You came upon the dragon lair and started thinking ways to defeat the dragon.  The dragon is blocking the only door to enter the tower!");
            }

            Console.WriteLine("If you are a Princess you have two option: PrincessFirstOpt, PrincessSecondOpt." +  
                " If you are a Prince you have two option: PrinceFirstOpt, PrinceSecondOpt.");

            string dragonEncounter = Console.ReadLine();

            if (dragonEncounter == "PrincessFirstOpt")
            {
                Console.WriteLine("Princess you pick up the sword on the floor and approach the sleeping dragon.  While the dragon is sleeping you pity the lonely dragon and decide not to kill the dragon.  The dragon was happy and you escape the tower!");
            }
            else if (dragonEncounter == "PrincessSecondOpt")
            {
                Console.WriteLine("Princess you start picking up the scatter meat on the floor and plate it for the dragon while it is sleeping.  You wake up the dragon and fed the hungry dragon. The dragon is very happy!");
            }

            else if (dragonEncounter == "PrinceFirstOpt")
            {
                Console.WriteLine("Prince you grab your sword and walk through the door and prepared to slay the dragon.  You found the dragon sleeping and you slay the dragon head.  You rush to the princess tower and rescue her and escape the dragon lair! ");
            }
            else if (dragonEncounter == "PrinceSecondOpt")
            {
                Console.WriteLine("Prince you grab your sword and walk throuh the door and prepared to slay the dragon.  You found the dragon sleeping and was preparing to slay the dragon head, when you trip on a rock and woke up the dragon.  The sleepy and grouchy dragon woke up angry and tried to eat you, when all of a sudden, the princess came out of nowhere and rescue you by slaying the dragon head!");
            }

            Console.WriteLine("If you are the Princess you have two ending: PrincessFirstEnding, PrincessSecondEnding." +  
                "  If you are the Prince you have two ending: PrinceFirstEnding, PrinceSecondEnding.");

            string finalOutcome = Console.ReadLine();

            if (finalOutcome == "PrincessFirstEnding")
            {
                Console.WriteLine("Princess after you escape the tower, you found a prince at the door and you rob him of his horse and rode off into the sunset to go back home! THE END!");
            }
            else if ( finalOutcome == "PrincessSecondEnding")
            {
                Console.WriteLine("Princess after you made the dragon happy, you befriended the dragon.  The dragon let you ride on the dragon neck and took you back home!  THE END!");
            }

            else if (finalOutcome == "PrinceFirstEnding")
            {
                Console.WriteLine("Prince after you and the princess escape from the dragon lair, you took the princess back home with you and live HAPPILY EVER AFTER!  THE END! ");
            }
            else if (finalOutcome == "PrinceSecondEnding")
            {
                Console.WriteLine("Prince, after the princess rescue you from the dragon, the princess rob you of your horse and rode off into the sunset to go back home! THE END! ");
            }
        }
    }
}
