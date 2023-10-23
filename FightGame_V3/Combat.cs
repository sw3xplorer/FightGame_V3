public class Combat
{
    Random generator = new Random();

    public static void InCombat(Fighter player, Fighter enemy)
    {
        while(player.hp >= 0)
        {
            UI.HpBar(5, 10, player.maxHp, player.hp);
            UI.ManaBar(5, 13, player.maxMana, player.mana);
            UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
            UI.HpBar(65, 10, enemy.maxHp, enemy.hp);



        }

    }


    public static void Control()
    {

    }
    public static void Affect(Fighter attacker, Fighter target)
    {
        bool confirmAttack = false;
        int choice = 0;

        while(!confirmAttack)
        {

        }
    }
    
}
