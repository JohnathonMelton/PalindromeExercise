using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("Hannah", true)]
        [InlineData("level", true)]
        [InlineData("word", false)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void IsAPalindrome(string word,  bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
