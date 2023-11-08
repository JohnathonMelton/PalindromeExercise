using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null ||  word.Length == 0)
            {
                return false;
            }
            string lowerWord = word.ToLower();
            string backwards = "";

            for (int i = lowerWord.Length - 1; i >= 0; i--)
            {
                backwards += lowerWord[i];
            }

            if (lowerWord == backwards)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
