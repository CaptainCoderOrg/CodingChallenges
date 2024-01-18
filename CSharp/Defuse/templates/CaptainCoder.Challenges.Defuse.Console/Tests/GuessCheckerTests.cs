using Shouldly;

namespace CaptainCoder.Defuse.Tests;

public class GuessCheckerTests
{
    [Fact]
    public void test_correct_abc_abc_is_3()
    {
        GuessChecker checker = new GuessChecker();

        checker.Correct(['A', 'B', 'C'], ['A', 'B', 'C']).ShouldBe(3);
    }

    [Fact]
    public void test_correct_symbol_abc_abc_is_0()
    {
        GuessChecker checker = new GuessChecker();

        checker.CorrectSymbols(['A', 'B', 'C'], ['A', 'B', 'C']).ShouldBe(0);
    }

    [Fact]
    public void test_correct_abc_acb_is_3()
    {
        GuessChecker checker = new GuessChecker();

        checker.Correct(['A', 'B', 'C'], ['A', 'C', 'B']).ShouldBe(1);
    }

    [Fact]
    public void test_correct_symbol_abc_acb_is_2()
    {
        GuessChecker checker = new GuessChecker();
        checker.CorrectSymbols(['A', 'B', 'C'], ['A', 'C', 'B']).ShouldBe(2);
    }

    [Fact]
    public void test_correct_abc_abd_is_2()
    {
        GuessChecker checker = new GuessChecker();

        checker.Correct(['A', 'B', 'C'], ['A', 'B', 'D']).ShouldBe(2);
    }

    [Fact]
    public void test_correct_symbol_abc_abd_is_0()
    {
        GuessChecker checker = new GuessChecker();

        checker.CorrectSymbols(['A', 'B', 'C'], ['A', 'B', 'D']).ShouldBe(0);
    }

    [Fact]
    public void test_correct_abc_cab_is_0()
    {
        GuessChecker checker = new GuessChecker();

        checker.Correct(['A', 'B', 'C'], ['C', 'A', 'B']).ShouldBe(0);
    }

    [Fact]
    public void test_correct_symbols_abc_cab_is_3()
    {
        GuessChecker checker = new GuessChecker();

        checker.CorrectSymbols(['A', 'B', 'C'], ['C', 'A', 'B']).ShouldBe(3);
    }

}