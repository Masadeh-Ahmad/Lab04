using System;
using Lab04_TicTacToe.Classes;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void winnerTest()
        {
            Player p1 = new Player();
            p1.Name = "Ahmad";
            p1.Marker = "X";
            Player p2 = new Player();
            p2.Name = "Ashraf";
            p2.Marker = "O";
            Game game = new Game(p1, p2);
            Board board = new Board();
            board.GameBoard = new string[,]
        {
            {"X", "X", "O"},
            {"4", "O", "6"},
            {"O", "8", "O"},
        };
            game.Board = board;
            Assert.True(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void switchTest()
        {
            Player p1 = new Player();
            p1.Name = "Ahmad";
            p1.Marker = "X";
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.Name = "Ashraf";
            p2.Marker = "O";
            p2.IsTurn = false;
            Game game = new Game(p1, p2);
            Assert.True(game.PlayerOne.IsTurn);
            Assert.False(game.PlayerTwo.IsTurn);
            game.SwitchPlayer();
            Assert.False(game.PlayerOne.IsTurn);
            Assert.True(game.PlayerTwo.IsTurn);
        }
        [Fact]
        public void positionTest()
        {
            int[] pos = new int[2];
            pos[0]= new Position(1, 1).Row;
            pos[1]= new Position(1, 1).Column;
            Assert.Equal(pos, new[] { Player.PositionForNumber(5).Row , Player.PositionForNumber(5).Column });
        }
        [Fact]
        public void nextPlayerTest()
        {
            Player p1 = new Player();
            p1.Name = "Ahmad";
            p1.Marker = "X";
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.Name = "Ashraf";
            p2.Marker = "O";
            p2.IsTurn = false;
            Game game = new Game(p1, p2);
            Assert.Equal("Ahmad",game.NextPlayer().Name);
            game.SwitchPlayer();
            Assert.Equal("Ashraf", game.NextPlayer().Name);
        }

    }
}
