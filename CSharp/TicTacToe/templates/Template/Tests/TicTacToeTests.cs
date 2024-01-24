using Shouldly;

namespace Tests;

public class TicTacToeTests
{
    [Fact]
    public void initializes_with_CurrentPlayer_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer.ShouldBe(1);
    }

    [Fact]
    public void initializes_with_board_of_numbers()
    {
        TicTacToe game = new TicTacToe();
        game.Board[0].ShouldBe('0');
        game.Board[1].ShouldBe('1');
        game.Board[2].ShouldBe('2');
        game.Board[3].ShouldBe('3');
        game.Board[4].ShouldBe('4');
        game.Board[5].ShouldBe('5');
        game.Board[6].ShouldBe('6');
        game.Board[7].ShouldBe('7');
        game.Board[8].ShouldBe('8');
    }

    [Fact]
    public void SwitchPlayer_should_change_CurrentPlayer()
    {
        TicTacToe game = new TicTacToe();

        game.CurrentPlayer.ShouldBe(1);
        game.SwitchPlayer();
        game.CurrentPlayer.ShouldBe(2);
        game.SwitchPlayer();
        game.CurrentPlayer.ShouldBe(1);
        game.SwitchPlayer();
        game.CurrentPlayer.ShouldBe(2);
    }

    [Fact]
    public void MakeMove_should_return_false_when_occupied()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'O', '1', 'O', 
            '3', 'X', '5', 
            '6', '7', 'X'
        ];

        game.MakeMove(0).ShouldBeFalse();
        game.MakeMove(2).ShouldBeFalse();
        game.MakeMove(4).ShouldBeFalse();
        game.MakeMove(8).ShouldBeFalse();

        
    }

    [Fact]
    public void MakeMove_should_return_false_if_invalid_location()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'O', '1', 'O', 
            '3', 'X', '5', 
            '6', '7', 'X'
        ];

        game.MakeMove(-7).ShouldBeFalse();
        game.MakeMove(9).ShouldBeFalse();
        game.MakeMove(15).ShouldBeFalse();

        game.Board[0].ShouldBe('O');
        game.Board[1].ShouldBe('1');
        game.Board[2].ShouldBe('O');
        game.Board[3].ShouldBe('3');
        game.Board[4].ShouldBe('X');
        game.Board[5].ShouldBe('5');
        game.Board[6].ShouldBe('6');
        game.Board[7].ShouldBe('7');
        game.Board[8].ShouldBe('X');
    }

    [Fact]
    public void MakeMove_should_place_X_when_CurrentPlayer_is_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = ['0', '1', '2', '3', '4', '5', '6', '7', '8'];

        bool changed = game.MakeMove(0);
        changed.ShouldBeTrue();
        game.Board[0].ShouldBe('X');

        changed = game.MakeMove(7);
        changed.ShouldBeTrue();
        game.Board[7].ShouldBe('X');

        changed = game.MakeMove(3);
        changed.ShouldBeTrue();
        game.Board[3].ShouldBe('X');

        changed = game.MakeMove(8);
        changed.ShouldBeTrue();
        game.Board[8].ShouldBe('X');

        game.Board[0].ShouldBe('X');
        game.Board[1].ShouldBe('1');
        game.Board[2].ShouldBe('2');
        game.Board[3].ShouldBe('X');
        game.Board[4].ShouldBe('4');
        game.Board[5].ShouldBe('5');
        game.Board[6].ShouldBe('6');
        game.Board[7].ShouldBe('X');
        game.Board[8].ShouldBe('X');
    }

    [Fact]
    public void MakeMove_should_place_O_when_CurrentPlayer_is_2()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = ['0', '1', '2', '3', '4', '5', '6', '7', '8'];

        bool changed = game.MakeMove(0);
        changed.ShouldBeTrue();
        game.Board[0].ShouldBe('O');

        changed = game.MakeMove(7);
        changed.ShouldBeTrue();
        game.Board[7].ShouldBe('O');

        changed = game.MakeMove(3);
        changed.ShouldBeTrue();
        game.Board[3].ShouldBe('O');

        changed = game.MakeMove(8);
        changed.ShouldBeTrue();
        game.Board[8].ShouldBe('O');

        game.Board[0].ShouldBe('O');
        game.Board[1].ShouldBe('1');
        game.Board[2].ShouldBe('2');
        game.Board[3].ShouldBe('O');
        game.Board[4].ShouldBe('4');
        game.Board[5].ShouldBe('5');
        game.Board[6].ShouldBe('6');
        game.Board[7].ShouldBe('O');
        game.Board[8].ShouldBe('O');
    }

    [Fact]
    public void top_row_win_player_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'X', 'X', 'X',
            '3', '4', '5',
            '6', '7', '8'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void mid_row_win_player_2()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            '1', '2', '3',
            'O', 'O', 'O',
            '6', '7', '8'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void bottom_row_win_player_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            '1', '2', '3',
            '3', '4', '5',
            'X', 'X', 'X'
        ];
        // Current player is 2 (no win)
        game.CheckWin().ShouldBeFalse();

        // Player 1 is X and has won
        game.CurrentPlayer = 1;
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void left_column_win_player_2()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            'O', '2', '3',
            'O', '4', '5',
            'O', 'X', 'X'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void center_column_win_player_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'O', 'X', '3',
            'O', 'X', '5',
            '6', 'X', '8'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void right_column_win_player_2()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            'O', '2', 'O',
            'X', '4', 'O',
            'O', 'X', 'O'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void left_diag_win_player_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'X', '2', 'O',
            'X', 'X', 'O',
            'O', 'X', 'X'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void right_diag_win_player_2()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            'X', '2', 'O',
            'X', 'O', 'O',
            'O', 'X', 'X'
        ];
        game.CheckWin().ShouldBeTrue();
    }

    [Fact]
    public void right_diag_no_win_player_1()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'X', '2', 'O',
            'X', 'O', 'O',
            'O', 'X', 'X'
        ];
        game.CheckWin().ShouldBeFalse();
    }

    [Fact]
    public void check_not_draw()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            'X', '2', 'X',
            'X', 'O', 'O',
            'O', 'X', 'X'
        ];
        game.CheckDraw().ShouldBeFalse();
    }

    [Fact]
    public void check_not_draw2()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 1;
        game.Board = [
            'X', '2', 'X',
            'X', 'O', '5',
            'O', 'X', 'X'
        ];
        game.CheckDraw().ShouldBeFalse();
    }
    
    [Fact]
    public void check_not_a_draw_when_won()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            'X', 'X', 'O',
            'X', 'O', 'X',
            'O', 'X', 'O'
        ];
        game.CheckDraw().ShouldBeFalse();
    }

    [Fact]
    public void check_is_draw()
    {
        TicTacToe game = new TicTacToe();
        game.CurrentPlayer = 2;
        game.Board = [
            'X', 'O', 'X',
            'X', 'O', 'O',
            'O', 'X', 'X'
        ];
        game.CheckDraw().ShouldBeTrue();
    }

    
}