/*
Breathing Activity
The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
After each message, the program should pause for several seconds and show a countdown.
It should continue until it has reached the number of seconds the user specified for the duration.
The activity should conclude with the standard finishing message for all activities.
*/

public class Breathing : Activity
{

    private int _breatheIn;
    private int _breatheOut;
    public Breathing(string name, string description) : base(name, description)
    {
    }

    private void CalculateBreatheInOut()
    {
        int totalTime = GetDuration();
        int parody;
        if (totalTime % 2 == 0)
        {
            parody = 1;
        } else {
            parody = 0;
        }

        if (totalTime < 5)
        {
            SetBreatheIn(2);
            SetBreatheOut(2);
        } else if (totalTime < 8)
        {
            _breatheIn = totalTime / 2;
            _breatheOut = totalTime / 2;
        } else if (totalTime < 15)
        {
            _breatheIn = totalTime / 3;
            _breatheOut = totalTime / 3;
        } else if (totalTime < 20)
        {
            _breatheIn = totalTime / 4;
            _breatheOut = totalTime / 4;
        } else
        {
            SetBreatheIn(4);
            SetBreatheOut(6);
        } 
        if (parody == 1)
        {
            _breatheIn += 1;
        }
    }
    public void SetBreatheIn(int breatheIn)
    {
        _breatheIn = breatheIn;
    }
    public void SetBreatheOut(int breatheOut)
    {
        _breatheOut = breatheOut;
    }

    public void Breathe()
    {
        CalculateBreatheInOut();
        int time = GetDuration();
        int elapsedTime = 0;
        while (elapsedTime < time)
        {
            Console.Write("Breathe in...  ");
            Animate(_breatheIn);
            elapsedTime += _breatheIn;
            if (elapsedTime >= time) break;
            Console.Write("\nBreathe out...  ");
            Animate(_breatheOut);
            elapsedTime += _breatheOut;
        }
    }
}
