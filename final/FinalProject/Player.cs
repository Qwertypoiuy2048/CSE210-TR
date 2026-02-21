
public class Player : Combatant
{
    
    public Player(string name, int initiative) : base(name, initiative){}

    public string GetInfo()
    {
        string info = $"\nName: {GetName()}";
        if (GetStatusEffects().Count > 0)
        {
            info += "\nStatus Effects:";
            foreach (StatusEffect effect in GetStatusEffects())
            {
                info += $"\n- {effect.GetName()} (Duration: {effect.GetDuration()} rounds)";
            }
        }
        else
        {
            info += "\nNo Status Effects";
        }
        return info;
    }
}
