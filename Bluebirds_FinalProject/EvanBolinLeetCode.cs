/*
* Name: Evan Bolin
* email: bolinen@mail.uc.edu
* Assignment: Final Project
* Due Date: 12 / 10 / 24
* Course #/Section: IS3050-001
* Semester / Year: Fall 2024
* Brief Description of the assignment: Using an ASP.NET website to solve a LeetCode problem in collaboration with a group using Git.

* Brief Description of what this module does. This class solves LeetCode Problem 773: Sliding Puzzle.
* Citations: LeetCode, ChatGPT
* Anything else that's relevant: 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bluebirds_FinalProject
{
    public class EvanBolinLeetCode
    {
        public int SlidingPuzzle(int[][] board)
        {
            // Convert the board to a single string to represent the state of the puzzle
            var target = "123450"; // The solved state of the puzzle
            var start = string.Join("", board.SelectMany(row => row).Select(x => x.ToString())); // Create a single string from the board elements

            // If the start state is already the target, return 0 moves
            if (start == target) return 0;

            // Define possible moves (left, right, up, down)
            var directions = new[] { -1, 1, -3, 3 }; // Left, Right, Up, Down
            var visited = new HashSet<string> { start }; // Set to keep track of visited states
            var queue = new Queue<(string, int)>(); // Queue for BFS: stores current state and move count
            queue.Enqueue((start, 0));

            // Perform Breadth-First Search (BFS)
            while (queue.Count > 0)
            {
                var (current, moves) = queue.Dequeue(); // Dequeue the current state and move count

                int zeroPos = current.IndexOf('0'); // Find the position of the empty space (0)
                foreach (var dir in directions)
                {
                    int newPos = zeroPos + dir; // Calculate new position after the move
                    // Ensure the move is valid (no out-of-bound or invalid moves)
                    if (newPos < 0 || newPos >= 6 || (zeroPos % 3 == 0 && dir == -1) || (zeroPos % 3 == 2 && dir == 1))
                        continue;

                    // Swap the zero with the adjacent number to create a new state
                    char[] currentArray = current.ToCharArray();
                    currentArray[zeroPos] = currentArray[newPos];
                    currentArray[newPos] = '0';
                    string newState = new string(currentArray); // Create the new state string

                    // If the new state is the target, return the number of moves
                    if (newState == target)
                        return moves + 1;

                    // If the new state hasn't been visited, add it to the queue and mark it as visited
                    if (!visited.Contains(newState))
                    {
                        visited.Add(newState);
                        queue.Enqueue((newState, moves + 1));
                    }
                }
            }

            return -1; // Return -1 if no solution is found (unsolvable)
        }
    }
}