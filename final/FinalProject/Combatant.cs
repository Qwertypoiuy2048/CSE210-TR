/*
I will be using classes to represent combatants and effects.
Characters and monsters will be children of a parent class called combatant.
each combatant will have a name and a list of status effects.

*/

public class Combatant
{

    private string _name;
    private List<StatusEffect> _statusEffects;
    private int _initiative;

    

    public Combatant(string name, int initiative)
    {
        _name = name;
        _initiative = initiative;
        _statusEffects = new List<StatusEffect>();
    }


    public string GetName() 
    { 
        return _name; 
    }    
    public void SetName(string name) 
    { 
        _name = name; 
    }
    public void SetInitiative(int value)
    {
        _initiative = value;
    }



    public List<StatusEffect> GetStatusEffects() 
    { 
        return _statusEffects; 
    }
    public void AddStatusEffect(StatusEffect effect) 
    { 
        _statusEffects.Add(effect); 
    }

    public void RemoveStatusEffect(StatusEffect effect)
    {
        _statusEffects.Remove(effect);
    }

    public void ClearStatusEffects()
    {
        _statusEffects.Clear();
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Initiative: {_initiative}");
        if (_statusEffects.Count > 0)
        {
            Console.WriteLine("Status Effects:");
            foreach (StatusEffect effect in _statusEffects)
            {
                Console.WriteLine($"- {effect.GetName()} (Duration: {effect.GetDuration()} rounds)");
            }
        }
        else
        {
            Console.WriteLine("No Status Effects");
        }
    }
}
