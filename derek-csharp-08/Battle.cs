using System;

namespace derek_csharp_08
{
    class Battle
    {
        // StartFight
        // Warior1 Warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over" || GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
        }

        // Get AttackResult
        // WarriorA, WarriorB
        // Calculate 1 warriors attack and the other block
        // Subtrack block from attack
        // If there was damage subtract that from the health
        // Print out info on who attacked who and for how much damage
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttackAmount = warriorA.Attack();
            double warBBlockAmount = warriorB.Block();
            double damage2WarB = warAAttackAmount - warBBlockAmount;

            if (damage2WarB > 0)
            {
                warriorB.Health = warriorB.Health - damage2WarB;
            }
            else
            {
                damage2WarB = 0;
            }
            Console.WriteLine($"{warriorA.Name} Attack {warriorB.Name} and Deals {damage2WarB} Domage");
            Console.WriteLine($"{warriorB.Name} Has {warriorB.Health} Health");

            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} has Died and {warriorA.Name} is Victorius");
                return "Game Over";
            }
            else
            {
                return "Fight Again";
            }
        }

        // Provide output on the change in health

        // Check if the warriors health fell below 0 and if so print a message and then send a response that will end the loop
    }
}
