/*
* Name: Omar Alkhawaga
* email: alkhawoe@mail.uc.edu
* Assignment: Final Project
* Due Date: 12/10/2024
* Course #/Section: IS3050/001
* Semester / Year: Fall/2024
* Brief Description of the assignment: Using an ASP.NET website to solve a LeetCode problem (Hard Level) in collaboration with a group using Git.
* Citations: ChatGPT, LeetCode
* Anything else that's relevant: N/A
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bluebirds_FinalProject
{
    public class OmarAlkhawagaLeetCode
    {
        public int Candy(int[] ratings)
        {
            int n = ratings.Length;
            int[] candies = new int[n];

            // Step 1: Give each child at least one candy
            for (int i = 0; i < n; i++)
            {
                candies[i] = 1;
            }

            // Step 2: Left to right pass
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            // Step 3: Right to left pass
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            // Step 4: Sum up all the candies
            int totalCandies = 0;
            for (int i = 0; i < n; i++)
            {
                totalCandies += candies[i];
            }

            return totalCandies;
        }
    }

}
