namespace BowlingGame.Core;

public class Game
{
    private readonly int[] _score = new int[21];
    private int _currentRoll = 0;
    
    public string PlayerName { get; }

    public Game(string playerName) => PlayerName = playerName;

    public void Roll(int pins)
    {
        _score[_currentRoll] = pins;
        _currentRoll++;
    }

    public int Score()
    {
        var score = 0;
        var frameIndex = 0;

        for (var frame = 0; frame < 10; frame++)
        {
            var (localScore, indexAdd) = RollTypeFactory
                .CreateRollType(_score, frameIndex)
                .Roll();
            score += localScore;
            frameIndex += indexAdd;

        }
        return score;
    }
}