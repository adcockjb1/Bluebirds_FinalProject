/*
* Name: Peyton Bock
* email: bockps@mail.uc.edu
* Assignment: Final Project
* Due Date: 12 / 10 / 24
* Course #/Section: IS3050-001
* Semester / Year: Fall 2024
* Brief Description of the assignment: Final project to prove some of what we know.

* Brief Description of what this module does. Recaps the semester. 
* Citations: LeetCode, ChatGPT, W3 schools, Slack Overflow
* Anything else that's relevant: Naaaaahhhhh
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System;
using System.Text;

namespace Bluebirds_FinalProject
{
    public class PeytonBockLeetCode
    {
        private readonly string[] belowTwenty =
        {
            "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private readonly string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        private readonly string[] thousands = { "", "Thousand", "Million", "Billion" };

        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";

            int i = 0;
            string words = "";

            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    words = Helper(num % 1000) + thousands[i] + " " + words;
                }
                num /= 1000;
                i++;
            }

            return words.Trim();
        }

        private string Helper(int num)
        {
            if (num == 0)
                return "";
            else if (num < 20)
                return belowTwenty[num] + " ";
            else if (num < 100)
                return tens[num / 10] + " " + Helper(num % 10);
            else
                return belowTwenty[num / 100] + " Hundred " + Helper(num % 100);
        }
    }
}
