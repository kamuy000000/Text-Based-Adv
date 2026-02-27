using System;
using System.Transactions;

namespace yea
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SwampCheck = false;
            bool MountainCheck = false;
            bool OceanCheck = false;
            bool CanyonCheck = false;

            string TownState = "Neutral";

        Town:

            if (TownState == "Neutral")
            {
                Console.Clear();
                Console.WriteLine("You wake up in an unfamiliar town");
                Console.WriteLine("Everyone around you generally seems happy and goes on about their day, yet you feel unsettled by this place");
                Console.WriteLine("You want to leave this place as fast as possible and are given four different options");
            }
            else if (TownState == "Swamp")
            {
                Console.Clear();
                Console.WriteLine("You went back to the town with a new outlook");
                Console.WriteLine("You didn't expect some people to have that kind of mindset");
                Console.WriteLine("But it strangely resonated with you");
            }
            else if (TownState == "Mountain")
            {
                Console.Clear();
                Console.WriteLine("You went back to the town with a clear head");
                Console.WriteLine("Going through your thoughts filled you with clarity");
                Console.WriteLine("Things seemed to make sense even if just a tiny bit");
            }
            else if (TownState == "Ocean")
            {
                Console.Clear();
                Console.WriteLine("You went back to the town feeling relieved");
                Console.WriteLine("You appreciated everyone around you more");
                Console.WriteLine("Their warmth and kindness gives you a reason to continue on");
            }
            else if (TownState == "Canyon")
            {
                Console.Clear();
                Console.WriteLine("You went back to the town with a new outlook");
                Console.WriteLine("You reflected inwards and looked at everything at a top-down point of view");
                Console.WriteLine("It fills you anxiety but strangely also excitement");
            }

                if (SwampCheck && MountainCheck && OceanCheck && CanyonCheck)
                {
                    Console.Clear();
                    Console.WriteLine("You ventured through swamp, mountain, ocean and canyon");
                    Console.WriteLine("You feel like you've gained a new perspective on this world");
                    Console.WriteLine("Only thing left to do is to enter the clocktower in the middle of everything");
                    Console.WriteLine("======================================================");
                    Console.WriteLine("||               () ClockTower                      ||");
                    Console.WriteLine("======================================================");
                    Console.ReadKey();
                    goto Clocktower;
                }

            Console.WriteLine("===========================================================");
            Console.WriteLine("||   (A) SWAMP   (B) MOUNTAIN   (C) OCEAN   (D) CANYON   ||");
            Console.WriteLine("===========================================================");
            string inputTown = Console.ReadLine();
            string inputT = inputTown.ToLower();


            if (string.IsNullOrEmpty(inputT))
            {
                goto Town;
            }
            char StartingPoint = inputT[0];
            switch (StartingPoint)
            {
                case ('a'):
                    goto Swamp;
                case ('b'):
                    goto Mountain;
                case ('c'):
                    goto Ocean;
                case ('d'):
                    goto Canyon;
                default:
                    goto Town;

            }
        Swamp:
            Console.Clear();
            Console.WriteLine("You went to the Swamp");
            Console.WriteLine("You see a bunch of people but they all feel devoid of life and just lounging around");
            Console.WriteLine("And yet, they all just feel relaxed somehow");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("||  (A) Lazy Person   (B) Drained Person   (C) Listless Person   (D) Town   ||");
            Console.WriteLine("==============================================================================");
            SwampCheck = true;
            TownState = "Swamp";
            string inputSwamp = Console.ReadLine();
            string inputS = inputSwamp.ToLower();

            if (string.IsNullOrEmpty(inputS))
            {
                goto Swamp;
            }
            char SwampChoice = inputS[0];
            switch (SwampChoice)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine("You decided to talk to the person lounging around near a bridge");
                    Console.WriteLine(" You: This place is pretty weird isn't it?");
                    Console.WriteLine(" Lazy Person: Uhh I guess so? It's always been this way though");
                    Console.WriteLine(" Lazy Person: Who cares honestly. It's all the same to me.");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Swamp;
                case ('b'):
                    Console.Clear();
                    Console.WriteLine("You decided to talk to the person who seems devoid of life");
                    Console.WriteLine(" You: Are you alright?");
                    Console.WriteLine(" Drained Person: You could say that.");
                    Console.WriteLine(" You: What does that mean...");
                    Console.WriteLine(" Drained Person: Being tired or full of life. Is there really a difference?");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Swamp;
                case ('c'):
                    Console.Clear();
                    Console.WriteLine("You decided to talk to the person who had a bored expression");
                    Console.WriteLine(" You: Is it really that boring?");
                    Console.WriteLine(" Listless Person: Everthing is ever-changing and yet it always feels the same.");
                    Console.WriteLine(" Listless Person: Why is that?");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Swamp;
                case ('d'):
                    goto Town;
                default:
                    goto Swamp;

            }
        Mountain:
            Console.Clear();
            Console.WriteLine("You went to the Mountain");
            Console.WriteLine("It felt peaceful while the cold winds breezed through your face");
            Console.WriteLine("It was also quiet as there was no one in site. You take this time to sit down and think");
            Console.WriteLine("==============================================================");
            Console.WriteLine("||   (A) Identity   (B) Belief   (C) Influence   (D) Town   ||");
            Console.WriteLine("==============================================================");
            MountainCheck = true;
            TownState = "Mountain";
            string inputMountain = Console.ReadLine();
            string inputM = inputMountain.ToLower();

            if (string.IsNullOrEmpty(inputM))
            {
                goto Mountain;
            }
            char MountainChoice = inputM[0];
            switch (MountainChoice)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine("You recalled things that defined you");
                    Console.WriteLine("The days where you did nothing but play on your gameboy and ds");
                    Console.WriteLine("The times where you were obsessed with drawing whatever comes to mind");
                    Console.WriteLine("And the music you play on repeat hoping that you can create something that made you proud one day");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Mountain;
                case ('b'):
                    Console.Clear();
                    Console.WriteLine("You pondered about your beliefs");
                    Console.WriteLine("You thought about what the word belief even meant");
                    Console.WriteLine("How can someone say something is true when the truth changes overtime");
                    Console.WriteLine("Belief is important to this world but how are you meant to define it");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Mountain;
                case ('c'):
                    Console.Clear();
                    Console.WriteLine("You thought about the people who shaped you");
                    Console.WriteLine("The friends you made along the way, the things you do together and the games you played with them");
                    Console.WriteLine("The people you looked up to who shaped your interests, who built the games you adored and wrote the stories which affected your mindset");
                    Console.WriteLine("And the people you see and talk to in random places. Their life holds meaning to you too since you valued their experiences and learned from them");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Mountain;
                case ('d'):
                    goto Town;
                default:
                    goto Mountain;

            }
        Ocean:
            Console.Clear();
            Console.WriteLine("You went to the Ocean");
            Console.WriteLine("The sound of the waves was calming and u felt a sense of familiarity and comfort");
            Console.WriteLine("In there, you were greeted by people who seemed familiar");
            Console.WriteLine("==================================================================================");
            Console.WriteLine("||   (A) Worried Person   (B) Chill Dude   (C) Approachable Person   (D) Town   ||");
            Console.WriteLine("==================================================================================");
            OceanCheck = true;
            TownState = "Ocean";
            string inputOcean = Console.ReadLine();
            string inputO = inputOcean.ToLower();

            if (string.IsNullOrEmpty(inputO))
            {
                goto Ocean;
            }
            char OceanChoice = inputO[0];
            switch (OceanChoice)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine("You talked to the person who seemed to be dying from worry");
                    Console.WriteLine(" You: Hey, are you alright?");
                    Console.WriteLine(" Worried Person: OMG! Where have you been? Are you fine? Have you ate? We've been so worried.");
                    Console.WriteLine(" You: Yea I'm good I think");
                    Console.WriteLine("You got a bit dizzy from this interaction");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Ocean;
                case ('b'):
                    Console.Clear();
                    Console.WriteLine("You decided to talk to the chill looking person");
                    Console.WriteLine(" Chill Dude: Yo where you been?");
                    Console.WriteLine(" You: Idk where anything is...");
                    Console.WriteLine(" Chill Dude: HASGDHHSAAGHS quit joking around bro");
                    Console.WriteLine(" Chill Dude: You trynna hop on later though?");
                    Console.WriteLine("What is bro on about");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Ocean;
                case ('c'):
                    Console.Clear();
                    Console.WriteLine("There seemed to be an approachable person nearby");
                    Console.WriteLine(" Approachable person: Hey man, you want some bbq?");
                    Console.WriteLine(" You: Nah I'm good thanks");
                    Console.WriteLine(" Approachable person: Alright just say if you want anything");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Ocean;
                case ('d'):
                    goto Town;
                default:
                    goto Ocean;

            }
        Canyon:
            Console.Clear();
            Console.WriteLine("You went to the Canyon");
            Console.WriteLine("It was completely empty but unlike the mountain you felt a sense of unease");
            Console.WriteLine("In here you were forced to reflect onto yourself");
            Console.WriteLine("========================================================");
            Console.WriteLine("||   (A) Past   (B) Present   (C) Future   (D) Town   ||");
            Console.WriteLine("========================================================");
            CanyonCheck = true;
            TownState = "Canyon";
            string inputCanyon = Console.ReadLine();
            string inputC = inputCanyon.ToLower();

            if (string.IsNullOrEmpty(inputC))
            {
                goto Canyon;
            }
            char CanyonChoice = inputC[0];
            switch (CanyonChoice)
            {
                    case ('a'):
                        Console.Clear();
                        Console.WriteLine("Looking into your past");
                        Console.WriteLine("Although not the kindest you appreciate it nonetheless");
                        Console.WriteLine("All the struggles you've endured are not for naught");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("||  () Go back                     ||");
                        Console.WriteLine("=====================================");
                        Console.ReadKey();
                        goto Canyon;
                    case ('b'):
                        Console.Clear();
                        Console.WriteLine("In the present time");
                        Console.WriteLine("Life has been better towards you, enduring countless struggles made you more determined");
                        Console.WriteLine("Although hints of stagnancy and complacency still exists");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("||  () Go back                     ||");
                        Console.WriteLine("=====================================");
                        Console.ReadKey();
                        goto Canyon;
                    case ('c'):
                        Console.Clear();
                        Console.WriteLine("Hopes for the future");
                        Console.WriteLine("You wish for a kinder future, where all your hardwork has paid off");
                        Console.WriteLine("Will I be happy? Will I be able to achieve my dreams?");
                        Console.WriteLine("Only time will tell");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("||  () Go back                     ||");
                        Console.WriteLine("=====================================");
                        Console.ReadKey();
                        goto Canyon;
                    case ('d'):
                        goto Town;
                    default:
                        goto Canyon;

            }
            Clocktower:
            Console.Clear();
            Console.WriteLine("You went inside the clocktower");
            Console.WriteLine("Everything seemed to make more sense");
            Console.WriteLine("The world you explored was how you viewed the world around you");
            Console.WriteLine("The smaller things in life is what made life worth living to you ");
            Console.WriteLine("You who was named john benedict carabeo");
            Console.WriteLine("Are not alone in this world");
            Console.WriteLine("===================================");
            Console.WriteLine("||   () Thank You for Playing!   ||");
            Console.WriteLine("===================================");
            Console.ReadKey();
            return;
        }
    }
}
