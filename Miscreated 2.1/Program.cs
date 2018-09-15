using System;

namespace Miscreated_2._1
{
    class Program
    {
        static void Main(string[] args)
        {   //Variables
            string choix = "oopsie";
            Random aleatoire = new Random();

            //Introduction
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Miscreated 2.1.exe has launched");
            Console.WriteLine("Several years has passed since it happened... Nobody knows what started the Final War. It was over too fast. Bioweapons, nukes, nanoweapons were used. The Empty World is the result of it. Only 100 millions people survived, worldwide.");
            Console.WriteLine("100 millions... and it gets lower every day... faster than ever. People are fighting to survive.");
            Console.WriteLine("Many people became mutants due to radiation sickness. The world is falling apart since then.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You are alone and left in a world that is hostile. You need food and everything you need to survive.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Every action you make has consequences.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What will you do?");
            Console.WriteLine();
            Console.WriteLine("Press any key to START");
            Console.ReadKey();
            Console.Clear();

            //Début histoire
            //Niveau 0
            Console.WriteLine("You've passed the previous days safe in your tent, which is your camp. No much food is left. You have to figure out something.");
            Console.WriteLine();
            Console.WriteLine("You currently have:");
            Console.WriteLine("*(1) Pocket Knife");
            Console.WriteLine("*(1) Hatchet");
            Console.WriteLine("*(2) Cans of beans");
            Console.WriteLine("*(1) Water bottle");
            Console.WriteLine();
            Console.WriteLine("Make a choice:");
            Console.WriteLine("-Stay in your camp: (1)");
            Console.WriteLine("-Get outside and explore the world (2)");

            //Niveau 1.1
            choix = Convert.ToString(Console.ReadLine());
            if (choix == "1")
            {
                Console.Clear();
                Console.WriteLine("You've eaten all your food left. You're beggining to starve really bad.");
                Console.WriteLine();
                Console.WriteLine("You currently have:");
                Console.WriteLine("*(1) Pocket Knife");
                Console.WriteLine("*(1) Hatchet");
                Console.WriteLine("*(1) Empty water bottle");
                Console.WriteLine();
                Console.WriteLine("Make a choice:");
                Console.WriteLine("-Stay in your camp, starve and die (1)");
                Console.WriteLine("-Get outside and explore the world (2)");

                //Niveau 2.1.1
                choix = Convert.ToString(Console.ReadLine());
                if (choix == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You died.");
                    Console.WriteLine();
                    Console.WriteLine("Reason: Death by starving.");
                    Console.WriteLine();
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.ReadKey();


                }

                //Niveau 2.1.2 /Pinecrest
                else if (choix == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Due to a lack of food, you will go to the nearest town called Pinecrest.");
                    Console.WriteLine();
                    Console.WriteLine("This town is known for having many mutants. This is a hostile area. Therefore, you won't have to worry about radiation.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    //PINECREST
                    Console.WriteLine("You are now in Pinecrest.");
                    Console.WriteLine();
                    Console.WriteLine("You can hear a car further in town.");
                    Console.WriteLine();
                    Console.WriteLine("You currently have:");
                    Console.WriteLine("*(1) Pocket Knife");
                    Console.WriteLine("*(1) Hatchet");
                    Console.WriteLine("*(1) Empty water bottle");
                    Console.WriteLine();
                    Console.WriteLine("Make a choice:");
                    Console.WriteLine("-Get closer to the car (1)");
                    Console.WriteLine("-Loot some houses in the neighborhood (2)");

                    //Niveau 3.1.1
                    choix = Convert.ToString(Console.ReadLine());
                    if (choix == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You are getting closer to the car.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("You are now at around 50 meters away from the car. ");
                        Console.WriteLine();
                        Console.WriteLine("It is not moving. There are two men standing by it. Looks like they have guns. ");
                        Console.WriteLine();
                        Console.WriteLine("They have duffle bags, military helmets. They look like true soldiers.");
                        Console.WriteLine();
                        Console.WriteLine("Many mutant corpses are laying down around them.");
                        Console.WriteLine();
                        Console.WriteLine("You currently have:");
                        Console.WriteLine("*(1) Pocket Knife");
                        Console.WriteLine("*(1) Hatchet");
                        Console.WriteLine("*(1) Empty water bottle");
                        Console.WriteLine();
                        Console.WriteLine("Make a choice:");
                        Console.WriteLine("-Get closer and start a conversation (1)");
                        Console.WriteLine("-Sneak behind them (2)");
                        Console.WriteLine("-Nevermind and loot the neighborhood (3)");


                        //Niveau 4.2.1
                        choix = Convert.ToString(Console.ReadLine());
                        if (choix == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You are going towards them.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("As soon as they see you, they both pull out their guns.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("*BANG*");
                            Console.Beep(115, 285);
                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine("You died.");
                            Console.WriteLine();
                            Console.WriteLine("Reason: Death by murder (12 Gauge Shotgun)");
                            Console.WriteLine();
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                            Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                            Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.ReadKey();




                        }

                        //Niveau 4.2.2
                        else if (choix == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("They didn't see you. You are now at less than 10 meters away from them.");
                            Console.WriteLine();
                            Console.WriteLine("There is no way you can sneak out without them noticing. ");
                            Console.WriteLine();
                            Console.WriteLine("You currently have:");
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(1) Empty water bottle");
                            Console.WriteLine();
                            Console.WriteLine("Make a choice:");
                            Console.WriteLine("-Pull out your pocket knife and rush them (1)");
                            Console.WriteLine("-Use your skills and throw your hatchet at one of them -50% chance- (2)");


                            //Niveau 5.1
                            choix = Convert.ToString(Console.ReadLine());
                            if (choix == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You stand out the bush and rush the man that is closer to you.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("As you run towards him, his mate has the time to pull out his gun.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("*BANG* *BANG* *BANG*");
                                Console.Beep(140, 250);
                                Console.Beep(140, 250);
                                Console.Beep(140, 250);
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by murder (5.56 AR-15 Rifle)");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();


                            }

                            //Niveau 5.1.2
                            else if (choix == "2")
                            {
                                int mois = aleatoire.Next(1, 3);

                                //Niveau 6.1.1
                                if (mois == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You stand up and throw your hatchet.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You hit the man that is the closest to you.");

                                    Console.WriteLine("*BANG*");
                                    Console.Beep(115, 285);
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("As he jumpscared, he shot his gun and killed his mate. Both of them are slowly dying, running out of blood... ");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You pick up all of their loot. There is so many that you have to store some in the car trunk.");
                                    Console.WriteLine();
                                    Console.WriteLine("There is a 12 Gauge Shotgun, one 5.56 AR-15, many MREs and 12 gallons of water.");

                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You're going back to your camp with the car as the sky is getting darker.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("Congratulation,");
                                    Console.WriteLine();
                                    Console.WriteLine("You survived ending up with:");
                                    Console.WriteLine();
                                    Console.WriteLine("*(1) Japanese sedan car");
                                    Console.WriteLine("*(1) 12 Gauge Shotgun");
                                    Console.WriteLine("*(1) 5.56 AR-15");
                                    Console.WriteLine("*(1) Pocket Knife");
                                    Console.WriteLine("*(1) Bloody Hatchet");
                                    Console.WriteLine("*(1) Water bottle");
                                    Console.WriteLine("*(12) Gallons of water");
                                    Console.WriteLine("*(24) Meals Ready to Eat");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                //Niveau 6.1.2
                                else if (mois == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You stand up and throw your hatchet.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You missed them.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("*BANG*");
                                    Console.Beep(115, 285);
                                    Console.ReadKey();

                                    Console.Clear();
                                    Console.WriteLine("You died.");
                                    Console.WriteLine();
                                    Console.WriteLine("Reason: Death by murder (12 Gauge Shotgun)");
                                    Console.WriteLine();
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.ReadKey();





                                }



                            }
                        }

                        //Niveau 4.2.3
                        else if (choix == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You are going back where you came from.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();


                            Console.WriteLine("You are now in the neighborhood.");
                            Console.WriteLine();
                            Console.WriteLine("Many hungry mutants are walking down the streets, looking for something to eat.");
                            Console.WriteLine();
                            Console.WriteLine("You have to be quick, since it's late in the afternoon, you have to get back at the camp before the night comes.");
                            Console.WriteLine();
                            Console.WriteLine("Many houses look safe to loot, there might be good stuff there. Therefore, there is a gas station that you could loot too. ");
                            Console.WriteLine();
                            Console.WriteLine("You currently have:");
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(1) Empty water bottle");
                            Console.WriteLine();
                            Console.WriteLine("Make a choice:");
                            Console.WriteLine("-Loot a house (1)");
                            Console.WriteLine("-Loot the gas station (2)");


                            //Niveau 5.2.1
                            choix = Convert.ToString(Console.ReadLine());
                            if (choix == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You are getting to a house.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("The door is closed. It's not locked, so you easiely get inside.");
                                Console.WriteLine();
                                Console.WriteLine("After many minutes, you've been through every rooms. There was nothing good to keep. ");
                                Console.ReadKey();
                                Console.WriteLine("Oh wait, the kitchen...");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("It is full of... rotten food.... ");
                                Console.ReadKey();
                                Console.WriteLine("BUT...");
                                Console.ReadKey();
                                Console.WriteLine("There are cans of food and water bottles, which aren't outdated yet.");
                                Console.WriteLine();
                                Console.WriteLine("There are:");
                                Console.WriteLine("*(7) Water bottles");
                                Console.WriteLine("*(2) Cans of peas");
                                Console.WriteLine("*(7) Cans of dog food");
                                Console.WriteLine("*(3) Cans of jelly");
                                Console.WriteLine("*(12) Cans of soup");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You're getting back at your camp with all the food you found, as it gets darker outside.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Congratulation,");
                                Console.WriteLine();
                                Console.WriteLine("You survived ending up with:");
                                Console.WriteLine();
                                Console.WriteLine("*(1) Pocket Knife");
                                Console.WriteLine("*(1) Hatchet");
                                Console.WriteLine("*(7) Water bottle");
                                Console.WriteLine("*(2) Cans of peas");
                                Console.WriteLine("*(7) Cans of dog food");
                                Console.WriteLine("*(3) Cans of jelly");
                                Console.WriteLine("*(12) Cans of soup");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                                Console.ReadKey();
                                Console.Clear();



                            }

                            //Niveau 5.2.2
                            else if (choix == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You are getting towards the gas station.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("It looks already looted, but you walk in because that's what you chose.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Once inside, you can clearly see that there is nothing good left.");
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.WriteLine("SUDDENLY...");
                                Console.ReadKey();
                                Console.WriteLine("*BANG*");
                                Console.Beep(115, 285);
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You got shot from behind...");
                                Console.ReadKey();
                                Console.WriteLine("As you fall down on your knees, you can see the string that you just walked on.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by a shotgun trap.");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();








                            }


                        }
                    }
                    //Niveau 3.1.2
                    else if (choix == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You are now in the neighborhood.");
                        Console.WriteLine();
                        Console.WriteLine("Many hungry mutants are walking down the streets, looking for something to eat.");
                        Console.WriteLine();
                        Console.WriteLine("You have to be quick, since it's late in the afternoon, you have to get back at the camp before the night comes.");
                        Console.WriteLine();
                        Console.WriteLine("Many houses look safe to loot, there might be good stuff there. Therefore, there is a gas station that you could loot too. ");
                        Console.WriteLine();
                        Console.WriteLine("You currently have:");
                        Console.WriteLine("*(1) Pocket Knife");
                        Console.WriteLine("*(1) Hatchet");
                        Console.WriteLine("*(1) Empty water bottle");
                        Console.WriteLine();
                        Console.WriteLine("Make a choice:");
                        Console.WriteLine("-Loot a house (1)");
                        Console.WriteLine("-Loot the gas station (2)");

                        //Niveau 4.3.1
                        choix = Convert.ToString(Console.ReadLine());
                        if (choix == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You are getting to a house.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("The door is closed. It's not locked, so you easiely get inside.");
                            Console.WriteLine();
                            Console.WriteLine("After many minutes, you've been through every rooms. There was nothing good to keep. ");
                            Console.ReadKey();
                            Console.WriteLine("Oh wait, the kitchen...");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("It is full of... rotten food.... ");
                            Console.ReadKey();
                            Console.WriteLine("BUT...");
                            Console.ReadKey();
                            Console.WriteLine("There are cans of food and water bottles, which aren't outdated yet.");
                            Console.WriteLine();
                            Console.WriteLine("There are:");
                            Console.WriteLine("*(7) Water bottles");
                            Console.WriteLine("*(2) Cans of peas");
                            Console.WriteLine("*(7) Cans of dog food");
                            Console.WriteLine("*(3) Cans of jelly");
                            Console.WriteLine("*(12) Cans of soup");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You're getting back at your camp with all the food you found, as it gets darker outside.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("Congratulation,");
                            Console.WriteLine();
                            Console.WriteLine("You survived ending up with:");
                            Console.WriteLine();
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(7) Water bottle");
                            Console.WriteLine("*(2) Cans of peas");
                            Console.WriteLine("*(7) Cans of dog food");
                            Console.WriteLine("*(3) Cans of jelly");
                            Console.WriteLine("*(12) Cans of soup");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                            Console.ReadKey();
                            Console.Clear();



                        }

                        //Niveau 4.3.2
                        else if (choix == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You are getting towards the gas station.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("It looks already looted, but you walk in because that's what you chose.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("Once inside, you can clearly see that there is nothing good left.");
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.WriteLine("SUDDENLY...");
                            Console.ReadKey();
                            Console.WriteLine("*BANG*");
                            Console.Beep(115, 285);
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You got shot from behind...");
                            Console.ReadKey();
                            Console.WriteLine("As you fall down on your knees, you can see the string that you just walked on.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You died.");
                            Console.WriteLine();
                            Console.WriteLine("Reason: Death by a shotgun trap.");
                            Console.WriteLine();
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                            Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                            Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.ReadKey();


                        }


                    }



                }


            }
            //Niveau 1.2
            else if (choix == "2")
            {
                Console.Clear();
                Console.WriteLine("Where would you like to go?");
                Console.WriteLine();
                Console.WriteLine("-Pinecrest, a small town (1)");
                Console.WriteLine("-Amalgamated Airfield, a military airbase (2)");




                //Niveau 2.2.1 /Pinecrest
                choix = Convert.ToString(Console.ReadLine());
                if (choix == "1")
                {
                    Console.Clear();

                    //PINECREST
                    Console.WriteLine("You are now in Pinecrest.");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("This town is known for having many mutants. This is a hostile area. Therefore, you won't have to worry about radiation.");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("You can hear a car further in town.");
                    Console.WriteLine();
                    Console.WriteLine("You currently have:");
                    Console.WriteLine("*(1) Pocket Knife");
                    Console.WriteLine("*(1) Hatchet");
                    Console.WriteLine("*(2) Cans of beans");
                    Console.WriteLine("*(1) Water bottle");
                    Console.WriteLine();
                    Console.WriteLine("Make a choice:");
                    Console.WriteLine("-Get closer to the car (1)");
                    Console.WriteLine("-Loot some houses in the neighborhood (2)");

                    //Niveau 3.2.1
                    choix = Convert.ToString(Console.ReadLine());
                    if (choix == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You are getting closer to the car.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("You are now at around 50 meters away from the car. ");
                        Console.WriteLine();
                        Console.WriteLine("It is not moving. There are two men standing by it. Looks like they have guns. ");
                        Console.WriteLine();
                        Console.WriteLine("They have duffle bags, military helmets. They look like true soldiers.");
                        Console.WriteLine();
                        Console.WriteLine("Many mutant corpses are laying down around them.");
                        Console.WriteLine();
                        Console.WriteLine("You currently have:");
                        Console.WriteLine("*(1) Pocket Knife");
                        Console.WriteLine("*(1) Hatchet");
                        Console.WriteLine("*(2) Cans of beans");
                        Console.WriteLine("*(1) Water bottle");
                        Console.WriteLine();
                        Console.WriteLine("Make a choice:");
                        Console.WriteLine("-Get closer and start a conversation (1)");
                        Console.WriteLine("-Sneak behind them (2)");
                        Console.WriteLine("-Nevermind and loot the neighborhood (3)");


                        //Niveau 4.2.1
                        choix = Convert.ToString(Console.ReadLine());
                        if (choix == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You are going towards them.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("As soon as they see you, they both pull out their guns.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("*BANG*");
                            Console.Beep(115, 285);
                            Console.ReadKey();

                            Console.Clear();
                            Console.WriteLine("You died.");
                            Console.WriteLine();
                            Console.WriteLine("Reason: Death by murder (12 Gauge Shotgun)");
                            Console.WriteLine();
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                            Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                            Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.ReadKey();




                        }

                        //Niveau 4.2.2
                        else if (choix == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("They didn't see you. You are now at less than 10 meters away from them.");
                            Console.WriteLine();
                            Console.WriteLine("There is no way you can sneak out without them noticing. ");
                            Console.WriteLine();
                            Console.WriteLine("You currently have:");
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(2) Cans of beans");
                            Console.WriteLine("*(1) Water bottle");
                            Console.WriteLine();
                            Console.WriteLine("Make a choice:");
                            Console.WriteLine("-Pull out your pocket knife and rush them (1)");
                            Console.WriteLine("-Use your skills and throw your hatchet at one of them -50% chance- (2)");


                            //Niveau 5.2.1
                            choix = Convert.ToString(Console.ReadLine());
                            if (choix == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You stand out the bush and rush the man that is closer to you.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("As you run towards him, his mate has the time to pull out his gun.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("*BANG* *BANG* *BANG*");
                                Console.Beep(140, 250);
                                Console.Beep(140, 250);
                                Console.Beep(140, 250);
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by murder (5.56 AR-15 Rifle)");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();


                            }

                            //Niveau 5.2.2
                            else if (choix == "2")
                            {
                                int mois = aleatoire.Next(1, 3);

                                //Niveau 6.2.1
                                if (mois == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You stand up and throw your hatchet.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You hit the man that is the closest to you.");

                                    Console.WriteLine("*BANG*");
                                    Console.Beep(115, 285);
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("As he jumpscared, he shot his gun and killed his mate. Both of them are slowly dying, running out of blood... ");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You pick up all of their loot. There is so many that you have to store some in the car trunk.");
                                    Console.WriteLine();
                                    Console.WriteLine("There is a 12 Gauge Shotgun, one 5.56 AR-15, many MREs and 12 gallons of water.");

                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You're going back to your camp with the car as the sky is getting darker.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("Congratulation,");
                                    Console.WriteLine();
                                    Console.WriteLine("You survived ending up with:");
                                    Console.WriteLine();
                                    Console.WriteLine("*(1) Japanese sedan car");
                                    Console.WriteLine("*(1) 12 Gauge Shotgun");
                                    Console.WriteLine("*(1) 5.56 AR-15");
                                    Console.WriteLine("*(1) Pocket Knife");
                                    Console.WriteLine("*(1) Bloody Hatchet");
                                    Console.WriteLine("*(2) Cans of beans");
                                    Console.WriteLine("*(1) Water bottle");
                                    Console.WriteLine("*(12) Gallons of water");
                                    Console.WriteLine("*(24) Meals Ready to Eat");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                                //Niveau 6.2.2
                                else if (mois == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You stand up and throw your hatchet.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You missed them.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("*BANG*");
                                    Console.Beep(115, 285);
                                    Console.ReadKey();

                                    Console.Clear();
                                    Console.WriteLine("You died.");
                                    Console.WriteLine();
                                    Console.WriteLine("Reason: Death by murder (12 Gauge Shotgun)");
                                    Console.WriteLine();
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.ReadKey();





                                }



                            }
                        }

                        //Niveau 4.2.3
                        else if (choix == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You are going back where you came from.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();


                            Console.WriteLine("You are now in the neighborhood.");
                            Console.WriteLine();
                            Console.WriteLine("Many hungry mutants are walking down the streets, looking for something to eat.");
                            Console.WriteLine();
                            Console.WriteLine("You have to be quick, since it's late in the afternoon, you have to get back at the camp before the night comes.");
                            Console.WriteLine();
                            Console.WriteLine("Many houses look safe to loot, there might be good stuff there. Therefore, there is a gas station that you could loot too. ");
                            Console.WriteLine();
                            Console.WriteLine("You currently have:");
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(2) Cans of beans");
                            Console.WriteLine("*(1) Water bottle");
                            Console.WriteLine();
                            Console.WriteLine("Make a choice:");
                            Console.WriteLine("-Loot a house (1)");
                            Console.WriteLine("-Loot the gas station (2)");


                            //Niveau 5.2.1
                            choix = Convert.ToString(Console.ReadLine());
                            if (choix == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You are getting to a house.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("The door is closed. It's not locked, so you easiely get inside.");
                                Console.WriteLine();
                                Console.WriteLine("After many minutes, you've been through every rooms. There was nothing good to keep. ");
                                Console.ReadKey();
                                Console.WriteLine("Oh wait, the kitchen...");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("It is full of... rotten food.... ");
                                Console.ReadKey();
                                Console.WriteLine("BUT...");
                                Console.ReadKey();
                                Console.WriteLine("There are cans of food and water bottles, which aren't outdated yet.");
                                Console.WriteLine();
                                Console.WriteLine("There are:");
                                Console.WriteLine("*(7) Water bottles");
                                Console.WriteLine("*(2) Cans of peas");
                                Console.WriteLine("*(7) Cans of dog food");
                                Console.WriteLine("*(3) Cans of jelly");
                                Console.WriteLine("*(12) Cans of soup");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You're getting back at your camp with all the food you found, as it gets darker outside.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Congratulation,");
                                Console.WriteLine();
                                Console.WriteLine("You survived ending up with:");
                                Console.WriteLine();
                                Console.WriteLine("*(1) Pocket Knife");
                                Console.WriteLine("*(1) Hatchet");
                                Console.WriteLine("*(8) Water bottle");
                                Console.WriteLine("*(2) Cans of beans");
                                Console.WriteLine("*(2) Cans of peas");
                                Console.WriteLine("*(7) Cans of dog food");
                                Console.WriteLine("*(3) Cans of jelly");
                                Console.WriteLine("*(12) Cans of soup");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                                Console.ReadKey();
                                Console.Clear();



                            }

                            //Niveau 5.2.2
                            else if (choix == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You are getting towards the gas station.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("It looks already looted, but you walk in because that's what you chose.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Once inside, you can clearly see that there is nothing good left.");
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.WriteLine("SUDDENLY...");
                                Console.ReadKey();
                                Console.WriteLine("*BANG*");
                                Console.Beep(115, 285);
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You got shot from behind...");
                                Console.ReadKey();
                                Console.WriteLine("As you fall down on your knees, you can see the string that you just walked on.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by a shotgun trap.");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();








                            }


                        }
                    }
                    //Niveau 3.2.2
                    else if (choix == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You are now in the neighborhood.");
                        Console.WriteLine();
                        Console.WriteLine("Many hungry mutants are walking down the streets, looking for something to eat.");
                        Console.WriteLine();
                        Console.WriteLine("You have to be quick, since it's late in the afternoon, you have to get back at the camp before the night comes.");
                        Console.WriteLine();
                        Console.WriteLine("Many houses look safe to loot, there might be good stuff there. Therefore, there is a gas station that you could loot too. ");
                        Console.WriteLine();
                        Console.WriteLine("You currently have:");
                        Console.WriteLine("*(1) Pocket Knife");
                        Console.WriteLine("*(1) Hatchet");
                        Console.WriteLine("*(1) Empty water bottle");
                        Console.WriteLine();
                        Console.WriteLine("Make a choice:");
                        Console.WriteLine("-Loot a house (1)");
                        Console.WriteLine("-Loot the gas station (2)");

                        //Niveau 4.2.1
                        choix = Convert.ToString(Console.ReadLine());
                        if (choix == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You are getting to a house.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("The door is closed. It's not locked, so you easiely get inside.");
                            Console.WriteLine();
                            Console.WriteLine("After many minutes, you've been through every rooms. There was nothing good to keep. ");
                            Console.ReadKey();
                            Console.WriteLine("Oh wait, the kitchen...");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("It is full of... rotten food.... ");
                            Console.ReadKey();
                            Console.WriteLine("BUT...");
                            Console.ReadKey();
                            Console.WriteLine("There are cans of food and water bottles, which aren't outdated yet.");
                            Console.WriteLine();
                            Console.WriteLine("There are:");
                            Console.WriteLine("*(7) Water bottles");
                            Console.WriteLine("*(2) Cans of peas");
                            Console.WriteLine("*(7) Cans of dog food");
                            Console.WriteLine("*(3) Cans of jelly");
                            Console.WriteLine("*(12) Cans of soup");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You're getting back at your camp with all the food you found, as it gets darker outside.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("Congratulation,");
                            Console.WriteLine();
                            Console.WriteLine("You survived ending up with:");
                            Console.WriteLine();
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(7) Water bottle");
                            Console.WriteLine("*(2) Cans of peas");
                            Console.WriteLine("*(7) Cans of dog food");
                            Console.WriteLine("*(3) Cans of jelly");
                            Console.WriteLine("*(12) Cans of soup");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                            Console.ReadKey();
                            Console.Clear();



                        }

                        //Niveau 4.2.2
                        else if (choix == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You are getting towards the gas station.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("It looks already looted, but you walk in because that's what you chose.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("Once inside, you can clearly see that there is nothing good left.");
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.WriteLine("SUDDENLY...");
                            Console.ReadKey();
                            Console.WriteLine("*BANG*");
                            Console.Beep(115, 285);
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You got shot from behind...");
                            Console.ReadKey();
                            Console.WriteLine("As you fall down on your knees, you can see the string that you just walked on.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You died.");
                            Console.WriteLine();
                            Console.WriteLine("Reason: Death by a shotgun trap.");
                            Console.WriteLine();
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                            Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                            Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.ReadKey();


                        }


                    }

                }

                //Niveau 2.2.2 /Amalgamated Airfield
                else if (choix == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You are heading towards Amalgamated Airfield.");
                    Console.ReadKey();
                    Console.WriteLine("As it's far away, you decide to stop and eat a can of beans.");
                    Console.ReadKey();
                    Console.WriteLine("Then you get back on track.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("You are now in Amalgamated Airfield.");
                    Console.WriteLine();
                    Console.WriteLine("This place is very hostile. There are many people fighting for their life with weapons, firearms included.");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("There is also a huge risk of radiation poisoning, since the government used to hide nuclear waste near the location.");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("You can hear many gunshots further away in the military base. ");
                    Console.WriteLine();
                    Console.WriteLine("Sounds like they are coming from the control tower.");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("There are also military hangars that you can loot.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You currently have:");
                    Console.WriteLine("*(1) Pocket Knife");
                    Console.WriteLine("*(1) Hatchet");
                    Console.WriteLine("*(1) Can of beans");
                    Console.WriteLine("*(1) Water bottle");
                    Console.WriteLine();
                    Console.WriteLine("Make a choice:");
                    Console.WriteLine("-Get closer the control tower");
                    Console.WriteLine("-Loot the military hangars");

                    choix = Convert.ToString(Console.ReadLine());
                    //Niveau 3.3.1
                    if (choix == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("As you get closer to the control tower, you see a human figure laid down in the bushed near you.");
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.WriteLine("Do you loot him? (1)");
                        Console.WriteLine("or");
                        Console.WriteLine("Do you pass by? (2)");

                        choix = Convert.ToString(Console.ReadLine());
                        //Niveau 4.4.1
                        if (choix == "1")
                        {
                            int mois = aleatoire.Next(1, 3);

                            // Le mode aléatoire permet de décider si tu tombes sur un homme mort ou un homme vivant.

                            Console.Clear();
                            Console.WriteLine("You decided to loot him.");
                            Console.ReadKey();
                            Console.Clear();

                            //Niveau 5.3.1
                            if (mois == 1)
                            {
                                Console.WriteLine("As you get closer, you can clearly see that the man is dead. ");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("Lucky you, he has a lot of gear on him!");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("He had a SKS Rifle, many MREs and two military canteen full of water.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("You currently have:");
                                Console.WriteLine("*(1) Pocket Knife");
                                Console.WriteLine("*(1) Hatchet");
                                Console.WriteLine("*(1) Can of beans");
                                Console.WriteLine("*(1) Water bottle");
                                Console.WriteLine("*(2) Military canteens");
                                Console.WriteLine("*(1) 7.62 SKS Rifle");
                                Console.WriteLine("*(6) Meals ready to Eat");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You're going back to your camp with all the loot, since it's far and it's getting darker outside.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Congratulation,");
                                Console.WriteLine();
                                Console.WriteLine("You survived.");
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                                Console.ReadKey();
                                Console.Clear();


                            }

                            //Niveau 5.3.2
                            else if (mois == 2)
                            {
                                Console.WriteLine("As you get closer, you can see that the figure is moving.");
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.WriteLine("It's clearly a man... and he's heavily breathing...");
                                Console.ReadKey();
                                Console.WriteLine("SUDDENLY...");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("*BANG*");
                                Console.Beep(115, 285);
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by murder (7.62x39 SKS Rifle)");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();





                            }

                        }

                        //Niveau 4.4.2
                        else if (choix == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You decided to pass by the figure.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You are now hidding in the bushes right bedise the main entrance.");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("You can hear people screaming for their life. Gunshots can be heard too. ");
                            Console.ReadKey();

                            Console.WriteLine();
                            Console.WriteLine("You currently have:");
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(1) Can of beans");
                            Console.WriteLine("*(1) Water bottle");
                            Console.WriteLine();
                            Console.WriteLine("Make a choice:");
                            Console.WriteLine("-Rush inside with your hatchet (1)");
                            Console.WriteLine("-Sneak in with your pocket knife (2)");

                            choix = Convert.ToString(Console.ReadLine());


                            //Niveau 5.4.1
                            if (choix == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You're running inside the building.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("SUDDENLY,");
                                Console.Clear();

                                Console.WriteLine("Someone gets in front of you, coming out of nowhere.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("As you're running really fast, you swing your hatchet at him, without asking any questions.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("You instantly chop off his head.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You pick up the shotgun that he had.");
                                Console.WriteLine();
                                Console.WriteLine("You rush further inside the building.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("*BANG*");
                                Console.Beep(125, 285);
                                Console.ReadKey();
                                Console.WriteLine("*BANG*");
                                Console.Beep(125, 285);
                                Console.ReadKey();
                                Console.WriteLine("*BANG*");
                                Console.Beep(125, 285);
                                Console.ReadKey();

                                Console.WriteLine();
                                Console.WriteLine("TRIPLE KILL!");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You have killed 4 people.");
                                Console.WriteLine();
                                Console.WriteLine("The control tower is now completely silent.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("You loot the 4 bodies. You pick up the essential and run away towards your camp, before anyone else invites himself at the party.  ");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Congratulation,");
                                Console.WriteLine();
                                Console.WriteLine("You survived ending up with:");
                                Console.WriteLine();
                                Console.WriteLine("*(1) 12 Gauge Shotgun");
                                Console.WriteLine("*(1) 5.56 AR-15 Rifle");
                                Console.WriteLine("*(1) 7.62x39 SKS Rifle");
                                Console.WriteLine("*(1) Pocket Knife");
                                Console.WriteLine("*(1) Bloody Hatchet");
                                Console.WriteLine("*(1) Water bottle");
                                Console.WriteLine("*(6) Gallons of water");
                                Console.WriteLine("*(24) Meals Ready to Eat");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Easter egg: Chuck Norris ending.");
                                Console.ReadKey();
                                Console.Clear();



                            }

                            //Niveau 5.4.2
                            else if (choix == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You silently get out the bushes you were hidding in. ");
                                Console.WriteLine();
                                Console.WriteLine("You sneak in the main entrance with your pocket knife pulled out.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Suddenly, passed the door frame, you freeze.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("You're beginning to taste blood in your mouth ");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("Your legs are weaker. You collapse on the floor.");
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("You're seeing black dots... you feel weak... you're slowly fainting.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by murder (stabbed in the neck).");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();






                            }



                        }



                    }

                    //Niveau 3.3.2
                    else if (choix == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You are heading towards the hangars.");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("There are two hangars that you can loot.");
                        Console.WriteLine();
                        Console.WriteLine("There is one at the beginning of the landing strip and the other one is at the end of it.");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("Make a choice:");
                        Console.WriteLine("-Choose the one at the beginning of the landing strip (1)");
                        Console.WriteLine("-Choose the one at the end of the landing strip (2)");

                        choix = Convert.ToString(Console.ReadLine());

                        //Niveau 4.5.1
                        if (choix == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You're heading towards the nearest hangar.");
                            Console.ReadKey();
                            Console.Clear();


                            Console.WriteLine("Once there, you can see that the door is open. There might be someone inside. ");
                            Console.WriteLine();
                            Console.WriteLine("There are also containers that you can loot around the hangar.");



                            Console.WriteLine("You currently have:");
                            Console.WriteLine("*(1) Pocket Knife");
                            Console.WriteLine("*(1) Hatchet");
                            Console.WriteLine("*(1) Can of beans");
                            Console.WriteLine("*(1) Water bottle");
                            Console.WriteLine();
                            Console.WriteLine("Make a choice:");
                            Console.WriteLine("-Loot the containers");
                            Console.WriteLine("-Get inside the hangar");

                            choix = Convert.ToString(Console.ReadLine());




                            //Niveau 5.5.1
                            if (choix == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You're getting to the containers.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Once there, you can see that they have locks on them.");
                                Console.WriteLine();
                                Console.WriteLine("You crouch at one to see if they are breackable...");
                                Console.ReadKey();


                                Console.WriteLine("*BANG*");
                                Console.Beep(130, 285);
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("There is blood all in front of you.");
                                Console.WriteLine();
                                Console.WriteLine("Your chest hurts and you fall down.");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("You died.");
                                Console.WriteLine();
                                Console.WriteLine("Reason: Death by murder (7.62x54r Mosin-Nagant Rifle");
                                Console.WriteLine();
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                Console.ReadKey();

                            }

                            //Niveau 5.5.2
                            else if (choix == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You're getting towards the hangar.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Suddenly,");
                                Console.WriteLine("*BANG*");
                                Console.Beep(130, 285);
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine("There was a gunshot.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You pull out your hatchet and get inside the hangar.");
                                Console.ReadKey();
                                Console.WriteLine("You can hear someone crying.");
                                Console.ReadKey();
                                Console.WriteLine("*BANG*");
                                Console.Beep(130, 285);
                                Console.ReadKey();
                                Console.WriteLine("There was a second gunshot.");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("You get further inside.");
                                Console.WriteLine();
                                Console.WriteLine("And then you see what happenned.");
                                Console.ReadKey();
                                Console.WriteLine("One man is standing by two corpses, which appear to a mom and her son.");
                                Console.ReadKey();
                                Console.WriteLine("The man is looking at you. He has a gun. He look desesparated.");
                                Console.ReadKey();

                                Console.WriteLine();
                                Console.WriteLine("You currently have:");
                                Console.WriteLine("*(1) Pocket Knife");
                                Console.WriteLine("*(1) Hatchet");
                                Console.WriteLine("*(1) Can of beans");
                                Console.WriteLine("*(1) Water bottle");
                                Console.WriteLine();
                                Console.WriteLine("Make a choice:");
                                Console.WriteLine("-Kill the man (1)");
                                Console.WriteLine("-Let him alive (2)");


                                choix = Convert.ToString(Console.ReadLine());

                                //Niveau 6.3.1
                                if (choix == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("You rush at him and swing your hatchet.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You decapitated him.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    Console.WriteLine("You pick up his gun and his backpack. ");
                                    Console.WriteLine();
                                    Console.WriteLine("You're getting back to your camp, since the night is coming.");
                                    Console.ReadKey();
                                    Console.Clear();




                                    Console.WriteLine();
                                    Console.WriteLine("You survived ending up with:");
                                    Console.WriteLine();
                                    Console.WriteLine("*(1) 20 Gauge Shotgun");
                                    Console.WriteLine("*(1) Pocket Knife");
                                    Console.WriteLine("*(1) Bloody Hatchet");
                                    Console.WriteLine("*(5) Water bottle");
                                    Console.WriteLine("*(6) Cereal bars");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Live long...");
                                    Console.ReadKey();
                                    Console.Clear();


                                }
                                //Niveau 6.3.2
                                else if (choix == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("He is crying at you.");
                                    Console.ReadKey();
                                    Console.WriteLine("He lifts up the gun and...");
                                    Console.ReadKey();
                                    Console.WriteLine("*BANG*");
                                    Console.Beep(130, 285);
                                    Console.ReadKey();

                                    Console.Clear();
                                    Console.WriteLine("You died.");
                                    Console.WriteLine();
                                    Console.WriteLine("Reason: Death by murder (20 Gauge Shotgun).");
                                    Console.WriteLine();
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                                    Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                                    Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                                    Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                                    Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                                    Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                                    Console.ReadKey();


                                }


                            }

                        }



                        //Niveau 4.5.2
                        else if (choix == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You're heading towards the end of the landing strip.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("It's very far away. You can barely see it.");
                            Console.WriteLine();
                            Console.WriteLine("The weather is very hot today. You're sweating really bad.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You've done half the distance to get there.");
                            Console.ReadKey();
                            Console.WriteLine("Your head is beginning to hurt really bad.");
                            Console.WriteLine();
                            Console.WriteLine("You also have a metallic taste in your mouth.");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("You're getting weak. You decide to take a break.");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("You begin to puke really bad. Blood is mostly coming.");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("You're beginning to see black dots. You feel sleepy.");
                            Console.WriteLine();
                            Console.WriteLine("You lay down and close your eyes.");


                            Console.Clear();
                            Console.WriteLine("You died.");
                            Console.WriteLine();
                            Console.WriteLine("Reason: Death by radiation poisoning.");
                            Console.WriteLine();
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                            Console.WriteLine("██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                            Console.WriteLine("██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                            Console.WriteLine("███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                            Console.WriteLine("██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                            Console.WriteLine("███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                            Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                            Console.ReadKey();

                        }


                    }

                }






            }

        }
    }

}