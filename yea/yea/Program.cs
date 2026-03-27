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
            bool ForestCheck = false;

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
            else if (TownState == "Forest")
            {
                Console.Clear();
                Console.WriteLine("You went back to the town reflecting on every other aspect of you");
                Console.WriteLine("The clarity you felt seemed different than before");
                Console.WriteLine("It feels like you understood yourself way more");
            }

            if (SwampCheck && MountainCheck && OceanCheck && CanyonCheck && ForestCheck)
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

            Console.WriteLine("========================================================================");
            Console.WriteLine("||   (A) SWAMP   (B) MOUNTAIN   (C) OCEAN   (D) CANYON   (E) FOREST   ||");
            Console.WriteLine("========================================================================");
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
                case ('e'):
                    goto Forest;
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
            Console.WriteLine("==============================================================");
            Console.WriteLine("||   (A) Physical   (B) Sexual   (C) Spiritual   (D) Town   ||");
            Console.WriteLine("==============================================================");
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
                        Console.WriteLine("Looking directly unto yourself, you look at your body");
                        Console.WriteLine("Thin arms and a lanky figure, these are parts of you that have been teased for as long as you can remember");
                        Console.WriteLine("A sense of insecurity looms towards your mind but you quickly shut it down");
                        Console.WriteLine("This is who you are and you are proud of it");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("||  () Go back                     ||");
                        Console.WriteLine("=====================================");
                        Console.ReadKey();
                        goto Canyon;
                    case ('b'):
                        Console.Clear();
                        Console.WriteLine("Sexuality comes up from your mind, not something that you think about greatly but are still aware of");
                        Console.WriteLine("Thinking about it more, you realize how diverse the sexuality of the people around you have been for the past years");
                        Console.WriteLine("Looking at yourself, being basic seems to fit you the best in terms of sexuality");
                        Console.WriteLine("Wishing for an intimate, passionate and committed monogamous relationship from the opposite sex, a goal for the future");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("||  () Go back                     ||");
                        Console.WriteLine("=====================================");
                        Console.ReadKey();
                        goto Canyon;
                    case ('c'):
                        Console.Clear();
                        Console.WriteLine("Spirituality, a topic that comes up way too often for you");
                        Console.WriteLine("Living with a religious family and culture, you grew up adopting most of their traditions and beliefs");
                        Console.WriteLine("Starting to question them from a very young age, you realize that being religious is not a good fit for you");
                        Console.WriteLine("Now you have firm beliefs while still respecting other peoples beliefs");
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
        Forest:
            Console.Clear();
            Console.WriteLine("You went to the Forest");
            Console.WriteLine("When your journey started this was your first path");
            Console.WriteLine("Now you use your serene surroundings to understand other aspects of yourself");
            Console.WriteLine("===============================================================");
            Console.WriteLine("||   (A) Material   (B) Political   (C) Digital   (D) Town   ||");
            Console.WriteLine("===============================================================");
            ForestCheck = true;
            TownState = "Forest";
            string inputForest = Console.ReadLine();
            string inputF = inputForest.ToLower();

            if (string.IsNullOrEmpty(inputF))
            {
                goto Forest;
            }
            char ForestChoice = inputF[0];
            switch (ForestChoice)
            {
                case ('a'):
                    Console.Clear();
                    Console.WriteLine("You think about your material self");
                    Console.WriteLine("You lived your whole life consuming different kinds of media to the point that it's a large part of your personality");
                    Console.WriteLine("Being able to work towards something to buy what makes you happy or listening and appreciating your fellow people's creations");
                    Console.WriteLine("You can't imagine ever living without being a consumer");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Forest;
                case ('b'):
                    Console.Clear();
                    Console.WriteLine("Thinking about your political self, you weren't the most political person");
                    Console.WriteLine("If anything you felt more averse and apathetic towards discussions towards politics. Not that you didn't care, mostly that nothing will change");
                    Console.WriteLine("Putting your energy onto other things felt much better to you and although feeling the effects of bad governance");
                    Console.WriteLine("You still feel pity and aversion to them for both being a scapegoat for the nations rage but not condoning their actions");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Forest;
                case ('c'):
                    Console.Clear();
                    Console.WriteLine("Living life digitally has been a large part of your life, especially in this era where everyone is on the internet and you can interact with everyone everywhere");
                    Console.WriteLine("Meeting a lot of friends, expressing yourself freely and finding comfort with discussing the things you love with people far away");
                    Console.WriteLine("You also appreciate the convenience and innovations that came with technology. Being able to explore new interests or keeping in touch with loved ones");
                    Console.WriteLine("One of the things you appreciate the most about living in present times");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("||  () Go back                     ||");
                    Console.WriteLine("=====================================");
                    Console.ReadKey();
                    goto Forest;
                case ('d'):
                    goto Town;
                default:
                    goto Forest;

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
