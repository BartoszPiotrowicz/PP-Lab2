//using System;

//class program
//{
//    static void Main()
//    {
//        int hp = 100;
//        Console.WriteLine("Your current hp: ");
//        int current_hp = int.Parse(Console.ReadLine());

//        Console.WriteLine("Your base damage: ");
//        int base_dmg = int.Parse(Console.ReadLine());

//        Console.WriteLine("Do you have a potion (true/false): ");
//        bool has_potion = bool.Parse(Console.ReadLine());

//        Console.WriteLine("Choose an action (1-3): ");
//        string action = Console.ReadLine();

//        if (current_hp <= 0)
//        {
//            Console.WriteLine("You're dead lil bro");
//        }
//        else
//        {
//            switch (action)
//            {
//                case "1":
//                    Console.WriteLine("Your damage is: " + base_dmg);
//                    break;
//                case "2":
//                    if (has_potion)
//                    {
//                        Console.WriteLine("Healed to full");
//                        current_hp = 100;
//                    }
//                    else
//                    {
//                        Console.WriteLine("No potions available");
//                    }
//                    break;
//                case "3":
//                    Console.WriteLine("You ran away");
//                    break;
//                default:
//                    Console.WriteLine("Inncorect action");
//                    break;
//            }
//            if (current_hp < 20)
//            {
//                Console.WriteLine("WARNING! LOW ON HEALTH");
//            }
//        }

//    }
//}