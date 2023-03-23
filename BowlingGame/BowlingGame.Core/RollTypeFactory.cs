namespace BowlingGame.Core;

public static class RollTypeFactory
{
    public static IRollType CreateRollType(int[] score, int frameIndex)
    {
        if (IsStrike(score[frameIndex]))
            return new Strike(score, frameIndex);
        if (IsSpare(score[frameIndex], score[frameIndex + 1]))
            return new Spare(score, frameIndex);
        return new Normal(score, frameIndex);
    }
    
    private static bool IsStrike(int roll) => 
        roll == 10;
    
    private static bool IsSpare(int firstRoll, int secondRoll) => 
        firstRoll + secondRoll == 10;
}