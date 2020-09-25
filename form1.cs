/*
Finish the following:
1.diagonal should be marked as a winning move
2. fix bugs
3. should reset the board after a player wins and the victory is declared

Below is the code for form1.cs that we went over in the class
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        TicTicToeUtility tictactoe = new TicTicToeUtility();
        private static int turn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void HandleButtonClick(object sender)
        {
            Button b = (Button)sender;
            b.Text = turn.ToString();
            UpdateBoard(b.Name);
            // Check is winning move for the player whose turn it is
            if (tictactoe.IsWinningMove(turn) == true)
            {
                DialogResult result = MessageBox.Show("Player " + turn + " won the game!");
            }

            FlipTurn();
        }

        private void FlipTurn()
        {
            if (turn == 0)
            {
                turn = 1;
            }
            else
            {
                turn = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
            tictactoe.PrintBoard();
        }

        public void UpdateBoard(string buttonName)
        {
            switch (buttonName)
            {
                case "button1":
                    tictactoe.SetBoardItem(0, 0, turn);
                    break;
                case "button2":
                    tictactoe.SetBoardItem(0, 1, turn);
                    break;
                case "button3":
                    tictactoe.SetBoardItem(0, 2, turn);
                    break;
                case "button4":
                    tictactoe.SetBoardItem(1, 0, turn);
                    break;
                case "button5":
                    tictactoe.SetBoardItem(1, 1, turn);
                    break;
                case "button6":
                    tictactoe.SetBoardItem(1, 2, turn);
                    break;
                case "button7":
                    tictactoe.SetBoardItem(2, 0, turn);
                    break;
                case "button8":
                    tictactoe.SetBoardItem(2, 1, turn);
                    break;
                case "button9":
                    tictactoe.SetBoardItem(2, 2, turn);
                    break;
                default:
                    break;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class TicTicToeUtility
    {
        int[,] board = new int[,] {{-1,-1,-1},
                                    {-1,-1,-1},
                                    {-1,-1,-1}
                                    };

        public void PrintBoard()
        {
            // print rows
            for (int i = 0; i < 3; i++)
            {
                //print columns
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
            }
        }

        public void SetBoardItem(int i, int j, int turn)
        {
            board[i, j] = turn;
        }

        public bool IsWinningMove(int turn)
        {
            // Check all rows if there is a full row
            for (int i = 0; i < 3; i++)
            {
                bool isRowComplete = true;
                for (int j = 0; j < 3; j++)
                {
                    // if board[i,j] != turn) then isRowComplete = false
                    if (board[i, j] != turn)
                    {
                        isRowComplete = false;
                    }
                }

                if (isRowComplete)
                    return true;
            }

            // check all columns if there is a full column
            for (int i = 0; i < 3; i++)
            {
                bool isColumnComplete = true;
                for (int j = 0; j < 3; j++)
                {
                    // if board[i,j] != turn) then isRowComplete = false
                    if (board[j, i] != turn)
                    {
                        isColumnComplete = false;
                    }
                }

                if (isColumnComplete)
                {
                    board = int{
                        { -1,-1,-1},
                                    { -1,-1,-1},
                                    { -1,-1,-1}
                    };
                }
                    return true;
            }
            bool isDiagonalComplete = true;
            // check both diagonals
            for (int i = 0; i < 3; i++)
            {
                if (board[i, i] != turn)
                {
                    isDiagonalComplete = true;
                }
                if (isDiagonalComplete)
                {
                    board = { { -1,-1,-1}, { -1,-1,-1}, { -1,-1,-1} };
                }
            }
            }
            return false;
        }
    }
}
