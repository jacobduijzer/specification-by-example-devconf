namespace BowlingGame.Core;

public class Strike : IRollType
{
    private readonly int[] _score;
    private readonly int _frameIndex;

    public Strike(int[] score, int frameIndex)
    {
        _score = score;
        _frameIndex = frameIndex;
    }

    public (int score, int index) Roll() =>
        (10 + StrikeBonus(_frameIndex), 1);

    private int StrikeBonus(int frameIndex) =>
        _score[frameIndex + 1] + _score[frameIndex + 2];
}