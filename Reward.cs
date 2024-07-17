using System;
using System.Collections.Generic;

public class Reward // class Reward
{
	public class Reward()
	{
		public string Name { get; set; } //flelds 
        public double Value { get; set; }/* Properties with get and set are used to encapsulate fields within a class
                                          * while providing controlled access to them. Here’s why get and set are used  */       
                                          

        // constructor 
        public Reward(string name, decimal value) /*This should take in a name and value in the parameters and assign them 
                                                   * to the associated properties */
        {
            Name = name;
            Value = value;
        }
    }

}
public static class ClawMachine
{
    public static List<Reward> AllRewards { get; private set; }
    public static decimal CostToPlay { get; private set; }
    private static Random _random = new Random();

    // Static constructor to initialize static properties
    static ClawMachine()
    {
        AllRewards = new List<Reward>
        {
            new Reward("Cheap candy", 0.50m),
            new Reward("Cheap candy", 0.50m),
            new Reward("Cheap candy", 0.50m),
            new Reward("Candy Bar", 1.00m),
            new Reward("Candy Bar", 1.00m),
            new Reward("Stuffed Animal", 10.00m)
        };

        CostToPlay = 1.50m;
    }

    public static Reward GetReward()
    {
        int index = _random.Next(AllRewards.Count);
        return AllRewards[index];
    }

    public static bool MadeProfit(Reward reward)
    {
        return reward.Value > CostToPlay;
    }

    public static void Play()
    {
        Reward reward = GetReward();
        Console.WriteLine($"You got: {reward.Name}");

        if (MadeProfit(reward))
        {
            Console.WriteLine("You made a profit");
        }
        else
        {
            Console.WriteLine("You lost money");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClawMachine.Play();
    }
}