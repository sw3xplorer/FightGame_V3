using System.ComponentModel.DataAnnotations;

public class Armory
{
    int itemChoice;
    int roll;
    Random generator = new Random();
    public List<Weapon> commonWeapons = new();
    public List<Weapon> uncommonWeapons = new();
    public List<Weapon> rareWeapons = new();
    public List<Weapon> legendaryWeapons = new();


    public Armory()
    {
        // Common weapons
        commonWeapons.Add(new() { name = "Knife", extraDamage = 1 });
        commonWeapons.Add(new() { name = "Sword", extraDamage = 2 });
        commonWeapons.Add(new() { name = "Spear", extraDamage = 3 });
        commonWeapons.Add(new() { name = "Greatsword", extraDamage = 4 });
        commonWeapons.Add(new() { name = "Morning Star", extraDamage = 5 });

        // Uncommon weapons
        uncommonWeapons.Add(new() { name = "Halberd", extraDamage = 6 });
        uncommonWeapons.Add(new() { name = "Saber", extraDamage = 7 });
        uncommonWeapons.Add(new() { name = "Magic wand", extraDamage = 8 });
        uncommonWeapons.Add(new() { name = "Magic tome", extraDamage = 9 });
        uncommonWeapons.Add(new() { name = "Magic staff", extraDamage = 10 });

        // Rare weapons
        rareWeapons.Add(new() { name = "War axe", extraDamage = 15 });
        rareWeapons.Add(new() { name = "Enchanted sword", extraDamage = 20 });
        rareWeapons.Add(new() { name = "Khopesh", extraDamage = 25 });
        rareWeapons.Add(new() { name = "Magic gauntlet", extraDamage = 30 });
        rareWeapons.Add(new() { name = "Elder tome", extraDamage = 35 });

        // Legendary weapons
        // (abilities are written on the side if they have any)

        legendaryWeapons.Add(new() { name = "Moonlight Greatsword", extraDamage = 100 });
        legendaryWeapons.Add(new() { name = "Archmage Tome", extraDamage = 150 });



        legendaryWeapons.Add(new() { name = "Boltcaster", extraDamage = 65, passiveBonusDamage = 30, bonusCritChance = 30, bonusCritDamage = 2 }); // Chance to shock the target dealing damage again
        legendaryWeapons.Add(new() { name = "Superfors DB 2020 Dead Blow Hammer", extraDamage = 116, bonusSpeed = 10 }); // Chance of an extra turn
        legendaryWeapons.Add(new() { name = "Masamune", extraDamage = 70, bonusSpeed = -1, bonusCritChance = 77, bonusCritDamage = 7 }); // Instantly exacute targets who are 7% hp or lower
        legendaryWeapons.Add(new() { name = "Buster Sword", extraDamage = 100, bonusCritChance = 15, bonusSpeed = -2 });
        legendaryWeapons.Add(new() { name = "Silver Knives", extraDamage = 50, bonusSpeed = 999, bonusCritChance = 45, bonusCritDamage = 3 }); // Gain an extra turn with 100% crit chance and increased crit damage
        legendaryWeapons.Add(new() { name = "Spear of Gungnir", extraDamage = 100, bonusCritChance = 20, bonusCritDamage = 2 }); // Gain lifesteal on attacks
        legendaryWeapons.Add(new() { name = "Mini Hakkero", extraDamage = 90, bonusCritChance = 20, bonusCritDamage = 1 }); //Crit chance and damage up
        legendaryWeapons.Add(new() { name = "Sword of Hisou", extraDamage = 85, passiveBonusDamage = 15 }); // Chance of an earthquake, damaging enemy again and gaining another turn
        legendaryWeapons.Add(new() { name = "Nuclear Fusion Cannon", extraDamage = 105, passiveBonusDamage = 20, bonusSpeed = -5 }); // Chance to burn the target dealing damage again. One leg turns to stone, reducing speed
        legendaryWeapons.Add(new() { name = "Wado Ichimonji", extraDamage = 99, bonusCritChance = 15, bonusCritDamage = 2 });
    }

    public void GiveReward(Fighter fighter)
    {
        roll = generator.Next(100);

        if (roll <= 19) //19
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("You got nothing");
            Task.Delay(1000).Wait();
            UI.ClearArea(0, 1, 50, 0);
        }
        else if (roll <= 39) //39
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("HP restored");
            Task.Delay(1000).Wait();
            UI.ClearArea(0, 1, 50, 0);
            fighter.hp = fighter.maxHp;
        }
        else if (roll <= 59) //59
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Mana restored");
            Task.Delay(1000).Wait();
            UI.ClearArea(0, 1, 50, 0);
            fighter.mana = fighter.maxMana;
        }
        else if (roll <= 79) // 79
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("HP and mana restored");
            Task.Delay(1000).Wait();
            UI.ClearArea(0, 1, 50, 0);
            fighter.hp = fighter.maxHp;
            fighter.mana = fighter.maxMana;
        }
        else
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Weapon found");
            Task.Delay(1000).Wait();
            UI.ClearArea(0, 0, 50, 1);
            roll = generator.Next(100);
            if (roll <= 99)
            {
                roll = generator.Next(legendaryWeapons.Count);
                Console.SetCursorPosition(40, 0);
                Console.WriteLine($"Weapon: {legendaryWeapons[roll].name}");
                Console.SetCursorPosition(40, 1);
                Console.WriteLine($"Damage: {legendaryWeapons[roll].extraDamage}");
                LegendaryBonus(legendaryWeapons, roll);

                if (fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = legendaryWeapons[roll];
                }
            }
            else if (roll <= 29)
            {
                roll = generator.Next(rareWeapons.Count);
                Console.SetCursorPosition(40, 0);
                Console.WriteLine($"Weapon: {rareWeapons[roll].name}");
                Console.SetCursorPosition(40, 1);
                Console.WriteLine($"Damage: {rareWeapons[roll].extraDamage}");

                if (fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = rareWeapons[roll];
                }
            }
            else if (roll <= 59)
            {
                roll = generator.Next(uncommonWeapons.Count);
                Console.SetCursorPosition(40, 0);
                Console.WriteLine($"Weapon: {uncommonWeapons[roll].name}");
                Console.SetCursorPosition(40, 1);
                Console.WriteLine($"Damage: {uncommonWeapons[roll].extraDamage}");

                if (fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = uncommonWeapons[roll];
                }
            }
            else
            {
                roll = generator.Next(commonWeapons.Count);
                Console.SetCursorPosition(40, 0);
                Console.WriteLine($"Weapon: {commonWeapons[roll].name}");
                Console.SetCursorPosition(40, 1);
                Console.WriteLine($"Damage: {commonWeapons[roll].extraDamage}");

                if (fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = commonWeapons[roll];
                }
            }
        }
        UI.ClearArea(0, 0, 170, 4);
    }

    // Activates the bonus of the weapon if it has one
    public static void LegendaryBonus(List<Weapon> weapons, int roll)
    {
        if (weapons[roll].name == "Boltcaster")
        {
            WriteMiscStats(weapons, roll, "Chance to shock the target, dealing damage again");
        }
        else if (weapons[roll].name == "Superfors DB 2020 Dead Blow Hammer")
        {
            WriteMiscStats(weapons, roll, "Chance for an extra turn");
        }
        else if (weapons[roll].name == "Masamune")
        {
            WriteMiscStats(weapons, roll, "Execute targets at 7% or lower HP");
        }
        // else if (weapons[roll].name == "Silver Knives")
        // {
        //     WriteMiscStats(weapons, roll, "Gain an extra turn with extra crit damage and 100% crit chance");
        // }
        else if (weapons[roll].name == "Spear of Gungnir")
        {
            WriteMiscStats(weapons, roll, "Heal on attacks");
        }
        else if (weapons[roll].name == "Mini Hakkero")
        {
            WriteMiscStats(weapons, roll, "Crit chance and damage up");
        }
        else if (weapons[roll].name == "Sword of Hisou")
        {
            WriteMiscStats(weapons, roll, "Chance of earthquake, causing damage and gaining an extra turn");
        }
        else if (weapons[roll].name == "Nuclear Fusion Cannon")
        {
            WriteMiscStats(weapons, roll, "Chance of burning the target causing extra damage");
        }
        else if (weapons[roll].name == "Wado Ichimonji")
        {
            WriteMiscStats(weapons, roll, "");
        }
        else if (weapons[roll].name == "")
        {

        }
    }

    // Writes other stats such as crit rate & damage and bonuses
    public static void WriteMiscStats(List<Weapon> weapons, int roll, string bonus)
    {
        Console.SetCursorPosition(85, 0);
        Console.WriteLine(bonus);
        Console.SetCursorPosition(85, 1);
        Console.WriteLine($"Extra crit rate: {weapons[roll].bonusCritChance}");
        Console.SetCursorPosition(85, 2);
        Console.WriteLine($"Extra crit damage: {weapons[roll].bonusCritDamage}");
    }
}