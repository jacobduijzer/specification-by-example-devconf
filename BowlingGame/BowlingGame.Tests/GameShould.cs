using BowlingGame.Core;

namespace BowlingGame.Tests;

public class GameShould
{
    [Fact]
    public void ScoreZeroWhenAllThrowsAreInTheGutter()
    {
        Game game = new();

        ThrowMany(20, 0, ref game);
        
        Assert.Equal(0, game.Score());
    }

    [Fact]
    public void ScoreTwentyWhenOnePinAtATime()
    {
        Game game = new();
        
        ThrowMany(20, 1, ref game);
        
        Assert.Equal(20, game.Score());
    }

    [Fact]
    public void ScoreOneSpare()
    {
        Game game = new();
        
        ScoreSpare(ref game);
        game.Roll(3);
        ThrowMany(17, 0, ref game);
        
        Assert.Equal(16, game.Score());
    }

    [Fact]
    public void ScoreOneStrike()
    {
        Game game = new();
        
        ScoreStrike(ref game);
        game.Roll(3);
        game.Roll(4);
        ThrowMany(17, 0, ref game);
            
        Assert.Equal(24, game.Score());
    }

    [Fact]
    public void CalculatePerfectScore()
    {
        Game game = new();
        
        ThrowMany(12, 10, ref game);
        
        Assert.Equal(300, game.Score());
    }

    private void ThrowMany(int turns, int pins, ref Game game)
    {
        for(var turn = 0; turn < turns; turn++)
            game.Roll(pins);
    }

    private void ScoreSpare(ref Game game)
    {
        game.Roll(5);
        game.Roll(5);
    }

    private void ScoreStrike(ref Game game) =>
        game.Roll(10);
}