public class Monster : Combatant
{
    Random rand = new Random();

    private int _HP;


    public Monster(string name, int hpDiceType, int hpDiceCount, int hpBonus)
        : base(name, 0)
    {
        int totalHP = 0;
        for (int i = 0; i < hpDiceCount; i++)
        {
            totalHP += rand.Next(1, hpDiceType + 1);
        }
        totalHP += hpBonus;

        SetHP(totalHP);
        rollInitiative();
    }


    public int GetHP()
    {
        return _HP;
    }

    public void SetHP(int HP)
    {
        _HP = HP;
    }


    public void rollInitiative()
    {
        SetInitiative(rand.Next(1, 21));
    }

    public string GetInfo()
    {
        return GetInfo() + $"\nType: {GetName()}\nHP: {_HP}";
    }
}
