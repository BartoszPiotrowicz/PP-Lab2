using System;

class program
{
    static void Main()
    {
        // Get parameters
        Console.WriteLine("Your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hero's max hp: ");
        int max_hp = int.Parse(Console.ReadLine());

        Console.WriteLine("Hero's current hp: ");
        int current_hp = int.Parse(Console.ReadLine());

        Console.WriteLine("Hero's level: ");
        int level = int.Parse(Console.ReadLine());

        Console.WriteLine("Hero's strength: ");
        int strength = int.Parse(Console.ReadLine());

        Console.WriteLine("Potion count: ");
        int potion_count = int.Parse(Console.ReadLine());

        Console.WriteLine("Do they have a map (true/false): ");
        bool has_map = bool.Parse(Console.ReadLine());

        Console.WriteLine("Choose an action (1-4): ");
        string action = Console.ReadLine();

        // Testing variables
        //string name = "Jerzy";
        //int max_hp = 100;
        //int current_hp = 20;
        //int level = 1;
        //int strength = 5;
        //int potion_count = 1;
        //bool has_map = true;

        // Declare states
        bool is_alive = true;
        bool is_low_health;
        bool is_prepared;

        // Deciding two states
        if (((double)current_hp <= (double)max_hp * 0.25) && current_hp > 0) {
            is_low_health = true;
        }
        else if ((double)current_hp >= (double)max_hp * 0.25)
        {
            is_low_health = false;
        }
        else
        {
            is_low_health = true;
            is_alive = false;
        }

        // Deciding the third state
        is_prepared = has_map && potion_count > 0 ? true : false;

        // Write out Hero card
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=====HERO CARD=====");
        Console.ResetColor();
        Console.WriteLine("Hero: " + name);
        Console.WriteLine("Health: " + current_hp + "/" + max_hp);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Strength: " + strength);
        Console.WriteLine("Potion count: " + potion_count);
        Console.WriteLine("Has map: " + has_map);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("------STATUS------");
        Console.ResetColor();
        Console.Write("Has low health: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(is_low_health);
        Console.ResetColor();
        Console.Write("Is alive: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(is_alive);
        Console.ResetColor();
        Console.Write("Is prepared: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(is_prepared);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("------ACTION------");
        Console.ResetColor();

        //Action logic
        if (is_alive)
        {
            switch (action)
            {
                case "1":
                    Console.WriteLine("Your damage is: " + strength);
                    break;
                case "2":
                    if (potion_count > 0)
                    {
                        Console.WriteLine("Healed to full");
                        current_hp = max_hp;
                        potion_count--;
                    }
                    else
                    {
                        Console.WriteLine("You have no potions");
                    }
                    break;
                case "3":
                    if (is_prepared)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You travel to The Dungeon");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You're not prepared for The Dungeon");
                        Console.ResetColor();
                    }
                    break;
                case "4":
                    Console.WriteLine("You sewerslided");
                    current_hp = 0;
                    break;
                default:
                    Console.WriteLine("Inncorect action");
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Cannot perform action. You're dead!");
            Console.ResetColor();
        }
    }
}