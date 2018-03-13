using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tictactoe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void ActiveFields()
        {
            Game game = new Game();
            game.CreateBoard();

            Assert.AreEqual(9, game.board.Length);
        }

        [TestMethod()]
        public void CurrentPlayerIsX()
        {
            Game game = new Game();
            
            Assert.AreEqual(1, game.currentPlayer);
        }

        [TestMethod()]
        public void CurrentPlayerIsO()
        {
            Game game = new Game();
            game.ChangePlayer();
            Assert.AreEqual(2, game.currentPlayer);
        }

        [TestMethod()]
        public void MakeMoveTestX()
        {
            Game game = new Game();
            game.CreateBoard();
            game.MakeMove(0, 1);
            Assert.AreEqual(1,game.board[0,1]);
        }

        [TestMethod()]
        public void MakeMoveTestO()
        {
            Game game = new Game();
            game.CreateBoard();
            game.ChangePlayer();
            game.MakeMove(0, 2);
            Assert.AreEqual(2, game.board[0, 2]);
        }

        [TestMethod()]
        public void SpaceInUseTest()
        {
            Game game = new Game();
            game.CreateBoard();

            Assert.AreEqual(false, game.SpaceInUse(0, 0));
        }
    }
}