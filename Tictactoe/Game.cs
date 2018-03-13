using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    public class Game
    {
        public int[,] board;
        public int currentPlayer = 1;
        
        public void CreateBoard()
        {
            board = new int[3, 3];
            for(int i = 0; i > 3; i++)
            {
                for(int j = 0; j>3; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        public int CurrentPlayer()
        {
            return currentPlayer;
        }

        public void ChangePlayer()
        {
            if(currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else if (currentPlayer == 2)
            {
                currentPlayer = 1;
            }
        }

        public void MakeMove(int x, int y)
        {
            if (!SpaceInUse(x,y))
            {
                board[x, y] = currentPlayer;
            }
            
        }

        public bool SpaceInUse(int x, int y)
        {
            if (board[x,y] == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
