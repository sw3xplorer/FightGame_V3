public class Fighter
{
    public List<int> playerHp = new() {500, 750}; //char 1 and char 2 hp
    public List<int> enemyHp = new() {100, 250, 500, 1250}; //agile unit, normal, brute, elite hp values
    public List<int> manaCapacity = new() {300, 200, 0}; //0 for enemy
    public int hp;
    int maxHp;
    public int mana;
    int maxMana;
    int speed;
    public Weapon weapon = new();
    public List<Ability> abilities = new();
}