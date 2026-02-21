// filepath: c:\Users\ehcre\.vscode\projects\CSE210\CSE210-TR\final\FinalProject\StatusEffect.cs

using System;

public class StatusEffect
{
    private string _name;
    private int _duration;



    public StatusEffect(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }



    public string GetName()
    {
        return _name;
    }
    public int GetDuration()
    {
        return _duration;
    }



    public void DecrementDuration()
    {
        if (_duration > 0)
        {
            _duration--;
        }
    }
    public void AddDuration(int rounds)
    {
        _duration += rounds;
    }

    public bool IsActive()
    {
        return _duration > 0;
    }
}
