using System;
using Xunit;
using PalindromeLibrary;

namespace PalindromeTest
{
    public class PalindromeTest
    {
        [Fact]
        public void TestConvertToPureString()
        {
            Palindrome MyPalindrome = new Palindrome();
            string value = "wuba w a sder 8 r5h &*^ ob $%^ OIUN";
            var result = MyPalindrome.ConvertToPureString(value);

            Assert.Equal("wubawasder8r5hobOIUN", result);
        }
        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void TestPalindromeFalse(string value)
        {
            Palindrome MyPalindrome = new Palindrome();
            value = MyPalindrome.ConvertToPureString(value);
            var result = MyPalindrome.IsPalindrome(value);

            Assert.False(result, $"{value} should not be a palindrome");
        }
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void TestPalindromeTrue(string value)
        {
            Palindrome MyPalindrome = new Palindrome();
            value = MyPalindrome.ConvertToPureString(value);
            var result = MyPalindrome.IsPalindrome(value);

            Assert.True(result, $"{value} should be a palindrome");
        }
    }
}
