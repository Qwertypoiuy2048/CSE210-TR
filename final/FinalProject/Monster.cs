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

        totalHP = Math.Max(totalHP, 1); // Ensure HP is at least 1
        _HP = totalHP;
        rollInitiative();
    }



    public void rollInitiative()
    {
        SetInitiative(rand.Next(1, 21));
    }

    public string GetInfo()
    {
        return GetInfo() + $"\nType: {GetName()}\nHP: {_HP}\nInitiative: {GetInitiative()}";
    }
}
