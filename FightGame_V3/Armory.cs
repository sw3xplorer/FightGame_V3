public class Armory
{
    Weapon greatsword = new();
    public List<Weapon> weapons = new();
    
    public Armory()
    {
        // Common weapons
        weapons.Add(new() {name = "Knife", damageBonus = 1});
        weapons.Add(new() {name = "Sword", damageBonus = 2});
        weapons.Add(new() {name = "Spear", damageBonus = 3});
        weapons.Add(new() {name = "Greatsword", damageBonus = 4});
        weapons.Add(new() {name = "Morning Star", damageBonus = 5});

        // Uncommon weapons
        weapons.Add(new() {name = "Halberd", damageBonus = 6});
        weapons.Add(new() {name = "Saber", damageBonus = 7});
        weapons.Add(new() {name = "Magic wand", damageBonus = 8});
        weapons.Add(new() {name = "Magic tome", damageBonus = 9});
        weapons.Add(new() {name = "Magic staff", damageBonus = 10});

        // Rare weapons
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });

        // Legendary weapons

        weapons.Add(new() {name = "Superfors DB 2020 Dead Blow Hammer", damageBonus = 30});
        weapons.Add(new() {name = "Masamune", damageBonus = 70});
        weapons.Add(new() {name = "Silver knives", damageBonus = 50});
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });
        weapons.Add(new() {name = "", damageBonus = });

    }

}