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

        protected System.Void OmarButton_Click(System.Object sender, System.EventArgs e)
        {
            OmarProblem1.Text = "There are n children standing in a line.";
            OmarProblem2.Text = "Each child is assigned a rating value given in the integer array ratings.";
            OmarProblem3.Text = "You are giving candies to these children subjected to the following requirements:.";
            OmarProblem4.Text = "-Each child must have at least one candy.";
            OmarProblem5.Text = "-Children with a higher rating get more candies than their neighbors..";
            OmarProblem6.Text = "Return the minimum number of candies you need to have to distribute the candies to the children.";

            OmarTestCase1.Text = "Here is the test case of the candy problem:";
            OmarTestCase2.Text = "Input: ratings = [1,0,2]";
            OmarTestCase3.Text = "Output: 5";
            OmarTestCase4.Text = "Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.";

            OmarTestResults1.Text = "Here is the test result of problem 135:";
            int[] testRatings = { 1, 0, 2 };
            OmarAlkhawagaLeetCode calculator = new OmarAlkhawagaLeetCode();
            int result = calculator.Candy(testRatings);


            OmarTestResults1.Text = $"Here is the test result of problem 135: {result}";

        }


    }
}
    public partial class Index : System.Web.UI.Page
    {


        protected void ProblemConvertToWords(object sender, EventArgs e)
        {
            // Get input
            string input = peytonInput.Text;
            int num;
            if (int.TryParse(input, out num) && num >= 0)
            {
                // Solve using PeytonBockLeetCode
                PeytonBockLeetCode solution = new PeytonBockLeetCode();
                string words = solution.NumberToWords(num);

                // Display result
                peytonExplanation.Text = $"Input: {num}";
                peytonSolution.Text = $"Output: {words}";
            }
            else
            {
                peytonExplanation.Text = "Invalid input! Please enter a non-negative integer.";
                peytonSolution.Text = "";
            }
        }
        protected void SolveLeetCode773(object sender, EventArgs e)
        {
            // Problem description
            problemDescription.Text = "LeetCode Problem 773: On a 2x3 board, there are five tiles labeled from 1 to 5, and an empty square represented by 0. A move consists of choosing 0 and a 4-directionally adjacent number and swapping it.\n\nThe goal is to reach the state [[1,2,3],[4,5,0]].";

            // Example board
            int[][] exampleBoard = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 0, 5 }
            };

            // Display example board
            exampleBoardLabel.Text = "Example Board: [[1, 2, 3], [4, 0, 5]]";
            // Solve the puzzle using EvanBolinLeetCode class
            EvanBolinLeetCode solution = new EvanBolinLeetCode();
            int result = solution.SlidingPuzzle(exampleBoard);

            // Display solution
            if (result == -1)
            {
                solutionLabel.Text = "It is impossible to solve the puzzle.";
            }
            else
            {
                solutionLabel.Text = $"Number of moves required: {result}";
            }
        }
    }
}