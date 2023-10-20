public class Constructor
{
    public List<int> playerHp = new() {500, 750}; //char 1 and char 2 hp
    public List<int> playerSpeed = new() {25, 20};
    public List<int> enemyHp = new() {100, 250, 500, 1250}; //agile unit, normal, brute, elite hp values
    public List<int> enemySpeed = new() {30, 15, 18, 19};
    public List<int> manaCapacity = new() {300, 250, 0}; //0 for enemy
    public Constructor(Fighter player)
    {
        if(player.name == "Owen")
        {
            player.maxHp = 500;
            player.hp = 500;
            player.maxMana = 300;
            player.mana = 300;
            player.speed = 25;
        }
        else
        {
            player.maxHp = 750;
            player.hp = 750;
            player.maxMana = 250;
            player.mana = 250;
        }
    }
}
