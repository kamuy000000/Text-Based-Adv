using System;
using System.Transactions;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
        Entrance:
            Console.Clear();
            Console.WriteLine("You wake up in an unfamiliar pitch white room");
            Console.WriteLine("You don't know why you're here but you're filled with a strange urge to leave this place as fast as possible");
            Console.WriteLine("You see two doors of equal size one to your left and one to your right");
            Console.WriteLine("=====================================");
            Console.WriteLine("||  (A) go left    (B) go right    ||");
            Console.WriteLine("=====================================");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                goto Entrance;
            }
            char StartingPoint = input[0];
            switch (StartingPoint)
            {
                case ('a'):
                    goto LeftRoom1;
                    break;
                case ('b'):
                    goto RightRoom1;
                    break;
                default:
                    goto Entrance;
                    break;

            }
        LeftRoom1:
            Console.Clear();
            Console.WriteLine("You went left");
            Console.WriteLine("You were blinded by the flashing lights that intruded your eyes the moment you step forth");
            Console.WriteLine("But when the light subsided you saw a sticky note sticked to a pin locked door");
            Console.WriteLine("=======================================");
            Console.WriteLine("||  (A) note  (B) door  (C) go back  ||");
            Console.WriteLine("=======================================");
            string inputL = Console.ReadLine();

            if (string.IsNullOrEmpty(inputL))
            {
                goto LeftRoom1;
            }
            char LeftChoice1 = inputL[0];
            switch (LeftChoice1)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine(" Three pages");
                    Console.WriteLine(" Number you see the most");
                    Console.WriteLine(" Count");
                    Console.WriteLine(" 5 digits");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto LeftRoom1;
                    break;
                case ('b'):
                    goto Passdoor;
                    break;
                case ('c'):
                    goto Entrance;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid");
                    Console.ReadKey(true);
                    goto LeftRoom1;
                    break;

            }
        RightRoom1:
            Console.Clear();
            Console.WriteLine("You went right");
            Console.WriteLine("The room was a mess and was filled with various items scattered around the floor");
            Console.WriteLine("Three items in particular caught your attention: a NINTENDO DS, a STACKED PAPER and a LAPTOP");
            Console.WriteLine("==============================================");
            Console.WriteLine("|| (A) DS  (B) paper (C) laptop (D) go back ||");
            Console.WriteLine("==============================================");
            string inputR = Console.ReadLine();

            if (string.IsNullOrEmpty(inputR))
            {
                goto RightRoom1;
            }
            char RightChoice1 = inputR[0];
            switch (RightChoice1)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine("You saw a nintendo ds that seems very worn out and used");
                    Console.WriteLine("You tried turning it on but it only contained the following numbers");
                    Console.WriteLine("00000");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto RightRoom1;
                    break;
                case ('b'):
                    goto Paper;
                    break;
                case ('c'):
                    Console.Clear();
                    Console.WriteLine("You checked out the dell laptop");
                    Console.WriteLine("You tried opening it and it showed a blue screen but something about it seemed a bit off");
                    Console.WriteLine("ZERO ZERO ZERO ZERO ZERO");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto RightRoom1;
                    break;
                case ('d'):
                    goto Entrance;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid");
                    Console.ReadKey(true);
                    goto RightRoom1;
                    break;

            }
        Paper:
            Console.Clear();
            Console.WriteLine("You checked the stacked papers and it felt rugged and old");
            Console.WriteLine("There were a ton of papers with words that seemed undecipherable to you but there were THREE pages in which you could make out words");
            Console.WriteLine("========================================================");
            Console.WriteLine("|| (A) Page 1  (B) Page 2   (C) Page 3   (D) go back  ||");
            Console.WriteLine("========================================================");
            string inputP = Console.ReadLine();

            if (string.IsNullOrEmpty(inputP))
            {
                goto Paper;
            }
            char PaperChoice = inputP[0];
            switch (PaperChoice)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine("My greatest fear?");
                    Console.WriteLine("I'd guess it'd be stagnancy and complacency");
                    Console.WriteLine("I'd remember a time where I was basically forced into it not only by my environment but also by myself");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  (000000) go back               ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Paper;
                    break;
                case ('b'):
                    Console.Clear();
                    Console.WriteLine("Finding meaning in life is pretty simple");
                    Console.WriteLine("You'd first have to come to the realization that you don't have one");
                    Console.WriteLine("Only then can you make one up");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  (00) go back                    ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Paper;
                    break;
                case ('c'):
                    Console.Clear();
                    Console.WriteLine("I acknowledge that I am who I am only because of how I grew up");
                    Console.WriteLine("If I were raised in a different environment, different household, had different friends");
                    Console.WriteLine("That person would probably not be me");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  (0000000) go back              ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Paper;
                    break;
                case ('d'):
                    goto RightRoom1;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid");
                    Console.ReadKey(true);
                    goto Paper;
                    break;

            }
        Passdoor:
            Console.Clear();
            Console.WriteLine("You checked the door");
            Console.WriteLine("There's a 9 key numpad from numbers 1-9");
            Console.WriteLine("It seems to require a passcode to enter");
            Console.WriteLine("======================================");
            Console.WriteLine("||  (Enter Passcode)   (A) go back  ||");
            Console.WriteLine("======================================");
            string Passdoor = Console.ReadLine();
            if (Passdoor == "a")
            {
                goto LeftRoom1;
            }
            else if (Passdoor == "62705")
            {
                Console.Clear();
                Console.WriteLine("To live is to suffer, to survive is to find some meaning in the suffering ― Friedrich Nietzsche");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That's not the password");
                Console.ReadKey();
                goto Passdoor;
            }

        }
    }
}
