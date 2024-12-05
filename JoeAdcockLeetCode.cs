/*
* Name: Joseph Adcock
* email: adcockjb @mail.uc.edu
* Assignment: Final Project
* Due Date: 12 / 10 / 24
* Course #/Section: IS3050-001
* Semester / Year: Fall 2024
* Brief Description of the assignment: Using an ASP.NET website to solve a LeetCode problem in collaboration with a group using Git.

* Brief Description of what this module does. This class solves sudoku puzzles.
* Citations: LeetCode, ChatGPT
* Anything else that's relevant: Solves puzzles.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bluebirds_FinalProject
{
    public class JoeAdcockLeetCode
    {
        public void SudokuSolver(char[][] board)
        {
            Solve(board);
        }
        // Function to check if it's valid to place the number at position (row, col)
        private bool IsValid(char[][] board, int row, int col, char num)
        {
            // Check the row
            for (int c = 0; c < 9; c++)
            {
                if (board[row][c] == num)
                {
                    return false;
                }
            }

            // Check the column
            for (int r = 0; r < 9; r++)
            {
                if (board[r][col] == num)
                {
                    return false;
                }
            }

            // Check the 3x3 sub-grid
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;
            for (int r = startRow; r < startRow + 3; r++)
            {
                for (int c = startCol; c < startCol + 3; c++)
                {
                    if (board[r][c] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Function to solve the Sudoku puzzle using backtracking
        private bool Solve(char[][] board)
        {
            // Find the first empty cell ('.')
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] == '.')
                    {
                        // Try digits 1-9
                        for (char num = '1'; num <= '9'; num++)
                        {
                            if (IsValid(board, row, col, num))
                            {
                                // Try placing the number
                                board[row][col] = num;
                                // Recursively try to solve the rest of the board
                                if (Solve(board))
                                {
                                    return true;
                                }
                                // Backtrack: undo the placement if it doesn't work
                                board[row][col] = '.';
                            }
                        }
                        return false; // If no number can be placed, return false
                    }
                }
            }
            return true; // Puzzle solved if all cells are filled
        }
    }
}