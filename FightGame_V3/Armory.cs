public class Armory
{
    public List<Weapon> weapons = new();

    public Armory()
    {
        // Common weapons
        weapons.Add(new() { name = "Knife", extraDamage = 1 });
        weapons.Add(new() { name = "Sword", extraDamage = 2 });
        weapons.Add(new() { name = "Spear", extraDamage = 3 });
        weapons.Add(new() { name = "Greatsword", extraDamage = 4 });
        weapons.Add(new() { name = "Morning Star", extraDamage = 5 });

        // Uncommon weapons
        weapons.Add(new() { name = "Halberd", extraDamage = 6 });
        weapons.Add(new() { name = "Saber", extraDamage = 7 });
        weapons.Add(new() { name = "Magic wand", extraDamage = 8 });
        weapons.Add(new() { name = "Magic tome", extraDamage = 9 });
        weapons.Add(new() { name = "Magic staff", extraDamage = 10 });

        // Rare weapons
        weapons.Add(new() { name = "War axe", extraDamage = 15});
        weapons.Add(new() { name = "Enchanted sword", extraDamage = 20});
        weapons.Add(new() { name = "Khopesh", extraDamage = 25});
        weapons.Add(new() { name = "Magic gauntlet", extraDamage = 30});
        weapons.Add(new() { name = "Elder tome", extraDamage = 35});

        // Legendary weapons
        // (abilities are written on the side if they have any)

        weapons.Add(new() { name = "Superfors DB 2020 Dead Blow Hammer", extraDamage = 80, bonusSpeed = 10 }); // Chance of an extra turn
        weapons.Add(new() { name = "Masamune", extraDamage = 70, bonusDamage = 9999999, bonusSpeed = -1, bonusCritDamage = 7}); // Instantly exacute targets who are 7% hp or lower
        weapons.Add(new() { name = "Boltcaster", extraDamage = 65, bonusDamage = 30, bonusCritChance = 30, bonusCritDamage = 2}); // Chance to shock the target dealing damage again
        weapons.Add(new() { name = "Archmage Tome", extraDamage = 150}); 
        weapons.Add(new() { name = "Silver Knives", extraDamage = 50, bonusSpeed = 999, bonusCritChance = 100, bonusCritDamage = 3 }); // Gain an extra turn with 100% crit chance and increased crit damage



        // weapons.Add(new() { name = "Buster Sword", extraDamage = 100, bonusCritChance = 15, bonusSpeed = -2 });
        // weapons.Add(new() { name = "Excalibur", extraDamage = 100});
        // weapons.Add(new() { name = "Spear of Gungnir", extraDamage = 100, bonusCritChance = 20, bonusCritDamage = 2 }); // Gain lifesteal on attacks
        // weapons.Add(new() { name = "Mini Hakkero", extraDamage = 90, bonusCritChance = 20, bonusCritDamage = 1}); //Crit chance and damage up
        // weapons.Add(new() { name = "Sword of Hisou", extraDamage = 85, bonusDamage = 15}); // Chance of an earthquake, damaging enemy again and gaining another turn
        // weapons.Add(new() { name = "Nuclear Fusion Cannon", extraDamage = 105, bonusSpeed = -5 }); // Chance to burn the target dealing damage again. One leg turns to stone, reducing speed
        // weapons.Add(new() { name = "Wado Ichimonji", extraDamage = 99, bonusCritChance = 15 } );
    }

}