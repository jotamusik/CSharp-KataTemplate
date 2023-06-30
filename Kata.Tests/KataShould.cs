using FluentAssertions;

namespace Kata.Tests;

public class KataShould
{
    [Fact]
    public void DoNothing()
    {
        SuperDuperKata.DoSomething().Should().Be(string.Empty);
    }
}
