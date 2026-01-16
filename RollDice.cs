namespace Mission2;

// second class to roll the dice and them together for total and send back to first class
public class RollDice
{
    public int[] SimulateRolls(int numRolls)
    {
        Random rnd = new Random();
        int[] counts = new int[13];
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            int sum = die1 + die2;

            counts[sum] = counts[sum] + 1;
        }
        return counts;
    }
}