using BowlingGame.Core;
using TechTalk.SpecFlow;

namespace BowlingGame.Specs;

[Binding]
public class BowlingGameScore
{
    private Game _game;
    private int _numberOfThrows = 0;
    
    [Given(@"(.*) is playing a game of bowling")]
    public void GivenNameIsPlayingAGameOfBowling(string name)
    {
        _game = new Game();
    }

    [When(@"she throws all balls in the gutter")]
    public void WhenSheThrowsAllBallsInTheGutter()
    {
        ThrowMany(20, 0);
    }
    
    [When(@"she throws (.*) pin at every turn")]
    public void WhenSheThrowsPinAtEveryTurn(int pins)
    {
        ThrowMany(20, pins);
    }
    
    [When(@"she throws a spare")]
    public void WhenSheThrowsASpare()
    {
        _game.Roll(5);
        _game.Roll(5);
        _numberOfThrows += 2;
    }
    
    [When(@"she throws a strike")]
    public void WhenSheThrowsAStrike()
    {
        _game.Roll(10);
        _numberOfThrows += 1;
    }
    
    [When(@"she throws (\d+) pins")]
    public void WhenSheThrowsPins(int pins)
    {
       _game.Roll(pins);
       _numberOfThrows += 1;
    }
    
    [When(@"she scores (.*) pins and (.*) pins")]
    public void WhenSheScoresPinsAndPins(int firstPins, int secondPins)
    {
        _game.Roll(firstPins);
        _game.Roll(secondPins);
        _numberOfThrows += 2;
    }
    
    [When(@"she scores nothing else")]
    public void WhenSheScoresNothingElse()
    {
        ThrowMany(20 - _numberOfThrows, 0);
    }
    
    [When(@"she throws (.*) strikes")]
    public void WhenSheThrowsStrikes(int p0)
    {
        ThrowMany(12, 10);
    }
    
    [When(@"she scores the following")]
    public void WhenSheScoresTheFollowing(Table table)
    {
        foreach (var row in table.Rows)
        {
            _game.Roll(int.Parse(row[1]));
            if(row[2] != "x")
                _game.Roll(int.Parse(row[2]));
        }
    }

    [Then(@"her total score should be (.*)")]
    public void ThenHerTotalScoreShouldBe(int expectedScore)
    {
        Assert.Equal(expectedScore, _game.Score());
    }

    private void ThrowMany(int turns, int pins)
    {
        for(var turn = 0; turn < turns; turn++)
            _game.Roll(pins);
    }


    
}