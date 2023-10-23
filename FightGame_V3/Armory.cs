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

        legendaryWeapons.Add(new() { name = "Excalibur", extraDamage = 100});
        legendaryWeapons.Add(new() { name = "Archmage Tome", extraDamage = 150 });



        // weapons.Add(new() { name = "Boltcaster", extraDamage = 65, passiveBonusDamage = 30, bonusCritChance = 30, bonusCritDamage = 2 }); // Chance to shock the target dealing damage again
        // weapons.Add(new() { name = "Superfors DB 2020 Dead Blow Hammer", extraDamage = 80, bonusSpeed = 10 }); // Chance of an extra turn
        // weapons.Add(new() { name = "Masamune", extraDamage = 70, passiveBonusDamage = 9999999, bonusSpeed = -1, bonusCritDamage = 7 }); // Instantly exacute targets who are 7% hp or lower
        // weapons.Add(new() { name = "Silver Knives", extraDamage = 50, bonusSpeed = 999, bonusCritChance = 100, bonusCritDamage = 3 }); // Gain an extra turn with 100% crit chance and increased crit damage
        // weapons.Add(new() { name = "Buster Sword", extraDamage = 100, bonusCritChance = 15, bonusSpeed = -2 });
        // weapons.Add(new() { name = "Spear of Gungnir", extraDamage = 100, bonusCritChance = 20, bonusCritDamage = 2 }); // Gain lifesteal on attacks
        // weapons.Add(new() { name = "Mini Hakkero", extraDamage = 90, bonusCritChance = 20, bonusCritDamage = 1}); //Crit chance and damage up
        // weapons.Add(new() { name = "Sword of Hisou", extraDamage = 85, bonusDamage = 15}); // Chance of an earthquake, damaging enemy again and gaining another turn
        // weapons.Add(new() { name = "Nuclear Fusion Cannon", extraDamage = 105, bonusSpeed = -5 }); // Chance to burn the target dealing damage again. One leg turns to stone, reducing speed
        // weapons.Add(new() { name = "Wado Ichimonji", extraDamage = 99, bonusCritChance = 15 } );
    }

    public void GiveReward(Fighter fighter)
    {
        roll = generator.Next(100);

        if(roll <= 19)
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("You got nothing");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("                         ");
        }
        else if(roll <= 39)
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("HP restored");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("                         ");
            fighter.hp = fighter.maxHp;
        }
        else if(roll <= 59)
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Mana restored");
            Console.SetCursorPosition(0,0);
            Task.Delay(1000).Wait();
            Console.WriteLine("                         ");
            fighter.mana = fighter.maxMana;
        }
        else if(roll <= 79)
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("HP and mana restored");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("                         ");
            fighter.hp = fighter.maxHp;
            fighter.mana = fighter.maxMana;
        }
        else
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Weapon found");
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("                         ");
            roll = generator.Next(100);
            if(roll <= 9)
            {
                roll = generator.Next(legendaryWeapons.Count); 
                Console.SetCursorPosition(40,0);
                Console.WriteLine($"Weapon: {legendaryWeapons[roll].name}");
                Console.SetCursorPosition(40,1);
                Console.WriteLine($"Damage: {legendaryWeapons[roll].extraDamage}");

                if(fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = legendaryWeapons[roll]; 
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                                       ");
                Console.SetCursorPosition(0,1);
                Console.WriteLine("                                                                       ");
            }
            else if(roll <= 29)
            {
                roll = generator.Next(rareWeapons.Count); 
                Console.SetCursorPosition(40,0);
                Console.WriteLine($"Weapon: {rareWeapons[roll].name}");
                Console.SetCursorPosition(40,1);
                Console.WriteLine($"Damage: {rareWeapons[roll].extraDamage}");

                if(fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = rareWeapons[roll]; 
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                                       ");
                Console.SetCursorPosition(0,1);
                Console.WriteLine("                                                                       ");
            }
            else if(roll <= 59)
            {
                roll = generator.Next(uncommonWeapons.Count); 
                Console.SetCursorPosition(40,0);
                Console.WriteLine($"Weapon: {uncommonWeapons[roll].name}");
                Console.SetCursorPosition(40,1);
                Console.WriteLine($"Damage: {uncommonWeapons[roll].extraDamage}");

                if(fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = uncommonWeapons[roll]; 
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                                       ");
                Console.SetCursorPosition(0,1);
                Console.WriteLine("                                                                       ");
            }
            else
            {  
                roll = generator.Next(commonWeapons.Count); 
                Console.SetCursorPosition(40,0);
                Console.WriteLine($"Weapon: {commonWeapons[roll].name}");
                Console.SetCursorPosition(40,1);
                Console.WriteLine($"Damage: {commonWeapons[roll].extraDamage}");

                if(fighter.ItemControl(itemChoice) == 1)
                {
                    fighter.weapon = commonWeapons[roll]; 
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("                                                                       ");
                Console.SetCursorPosition(0,1);
                Console.WriteLine("                                                                       ");
            }
        }
    }

}