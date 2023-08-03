using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
 public class CodeChallenge13Tests
    {

        [Fact]
        public void Test_BalancedBrackets_RoundBrackets()
        {
            string syntax = "((()))";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.True(result);
        }

        [Fact]
        public void Test_BalancedBrackets_SquareBrackets()
        {
            string syntax = "[[[]]]";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.True(result);
        }

        [Fact]
        public void Test_BalancedBrackets_CurlyBrackets()
        {
            string syntax = "{{{}}}";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.True(result);
        }

        [Fact]
        public void Test_UnbalancedBrackets_MissingClosingBracket()
        {
            string syntax = "({[})";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.False(result);
        }

        [Fact]
        public void Test_UnbalancedBrackets_MissingOpeningBracket()
        {
            string syntax = "(})";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.False(result);
        }

        [Fact]
        public void Test_UnbalancedBrackets_WrongOrder()
        {
            string syntax = "{[}]";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.False(result);
        }

        [Fact]
        public void Test_UnbalancedBrackets_ExtraClosingBracket()
        {
            string syntax = "{()}]";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.False(result);
        }

        [Fact]
        public void Test_UnbalancedBrackets_ExtraOpeningBracket()
        {
            string syntax = "{[()";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.False(result);
        }

        [Fact]
        public void Test_UnbalancedBrackets_EmptyString()
        {
            string syntax = "";
            bool result = CodeChallenge13.ValidateBrackets(syntax);
            Assert.True(result); // Empty string is considered balanced
        }
    }
}