public class Fighter
{
    public string name;
    public int hp;
    public int maxHp;
    public int mana;
    public int maxMana;
    public int speed;
    public Weapon weapon = new();
    public List<Ability> abilities = new();
}