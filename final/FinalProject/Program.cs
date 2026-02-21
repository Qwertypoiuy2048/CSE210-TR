/*
Final Project: DND Combat Tracker
Evan Crenshaw
I am forgoing Initiative and just going to have the combat tracker track status effects. 
I will track combat rounds and be able to add effects to each character that will last for a specified number of rounds. 
The tracker will display combatants and their current status effects and how many rounds they have left.
I will be able to add and remove monsters, but players will be hard coded.

I will be using classes to represent combatants and effects.
Characters and monsters will be children of a parent class called combatant.
each combatant will have a name and a list of status effects.
Each status effect will have a name and a duration in rounds.

I will also have a class for the combat tracker itself, which will manage the list of combatants and the current round number.
There will be methods to add and remove monsters, add status effects to combatants, advance the round, and to initialize a new combat.
initializing a new combat will reset the round number to 1, clear all status effects from all characters, and remove all monsters. 
adding a monster will roll health and initiative for the monster and add it to the combatants list.

*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        Console.WriteLine("Welcome to my Combat tracker!");

    

    }
}