using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bluebirds_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //add your button methods here

        protected void Problem37(object sender, EventArgs e)
        {
            joeExplanation1.Text = "Write a program to solve a Sudoku puzzle by filling the empty cells.";
            joeExplanation2.Text = "A sudoku solution must satisfy all of the following rules:";
            joeExplanation3.Text = "Each of the digits 1-9 must occur exactly once in each row.";
            joeExplanation4.Text = "Each of the digits 1-9 must occur exactly once in each column.";
            joeExplanation5.Text = "Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.";
            joeExplanation6.Text = "The '.' character indicates empty cells.";

            char[][] exampleBoard = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            example37.Text = "Here is an example Sudoku puzzle...";
            exBoard1.Text = "{" + string.Join(", ", exampleBoard[0]) + "}";
            exBoard2.Text = "{" + string.Join(", ", exampleBoard[1]) + "}";
            exBoard3.Text = "{" + string.Join(", ", exampleBoard[2]) + "}";
            exBoard4.Text = "{" + string.Join(", ", exampleBoard[3]) + "}";
            exBoard5.Text = "{" + string.Join(", ", exampleBoard[4]) + "}";
            exBoard6.Text = "{" + string.Join(", ", exampleBoard[5]) + "}";
            exBoard7.Text = "{" + string.Join(", ", exampleBoard[6]) + "}";
            exBoard8.Text = "{" + string.Join(", ", exampleBoard[7]) + "}";
            exBoard9.Text = "{" + string.Join(", ", exampleBoard[8]) + "}";

            JoeAdcockLeetCode solution37 = new JoeAdcockLeetCode();
            solution37.SudokuSolver(exampleBoard);

            string solutionString = "{";
            foreach (var row in exampleBoard)
            {
                solutionString += new string(row) + "}\n{";
            }
            response37.Text = "Here is the example board solved";
            solvedBoard1.Text = "{" + string.Join(", ", exampleBoard[0]) + "}";
            solvedBoard2.Text = "{" + string.Join(", ", exampleBoard[1]) + "}";
            solvedBoard3.Text = "{" + string.Join(", ", exampleBoard[2]) + "}";
            solvedBoard4.Text = "{" + string.Join(", ", exampleBoard[3]) + "}";
            solvedBoard5.Text = "{" + string.Join(", ", exampleBoard[4]) + "}";
            solvedBoard6.Text = "{" + string.Join(", ", exampleBoard[5]) + "}";
            solvedBoard7.Text = "{" + string.Join(", ", exampleBoard[6]) + "}";
            solvedBoard8.Text = "{" + string.Join(", ", exampleBoard[7]) + "}";
            solvedBoard9.Text = "{" + string.Join(", ", exampleBoard[8]) + "}";
        }
    }
}