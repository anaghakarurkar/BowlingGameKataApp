namespace BowlingGameKata.Tests;
using FluentAssertions;
public class Tests
{
    private BowlingGame _bowlingGame;
    [SetUp]
    public void Setup()
    {
        _bowlingGame = new BowlingGame();
    }

    



    [Test]
    public void Should_Return_False_When_Negative_Knoked_Pins_Number_Provided()
    {

        _bowlingGame.FirstGo(-1).Should().Be(false);

    }

    [Test]
    public void Should_Return_False_When_Knoked_Pins_Number_Provided_Is_Greater_Than_Ten()
    {
        _bowlingGame.SecondGo(11).Should().Be(false);
    }



}