using Williams_ExtendingAString;

namespace ExtendingTests
{
    [TestClass]
    public class ExtendingTests
    {
        [TestMethod]
        public void IsPalindromeIsTrue()
        {
            string word = "tattarrattat";
            Assert.IsTrue(word.IsPalindrome());
        }
        [TestMethod]
        public void IsPalindromeIsFalse()
        {
            string word = "Alabaster";
            Assert.IsFalse(word.IsPalindrome());
        }
        [TestMethod]
        public void IsPalindromeWithTrueBoolIsTrue()
        {
            string word = "TattarrattaT";
            Assert.IsTrue(word.IsPalindrome(true));
        }
        [TestMethod]
        public void IsPalindromeWithFalseBoolIsTrue()
        {
            string word = "Tattarrattat";
            Assert.IsTrue(word.IsPalindrome(false));
        }
        public void IsPalindromeWithFalseBoolIsFalse() 
        {
            string word = "Alabastor";
            Assert.IsFalse(word.IsPalindrome(false));
        }
        [TestMethod]
        public void ReverseStringWithoutCasing() 
        {
            string word = "Kevin";
            string reversed = "niveK";
            Assert.AreEqual(word.ReverseString(false), reversed);
        }
        [TestMethod]
        public void ReverseStringWithCasing() {
            string word = "Kevin";
            string reversed = "Nivek";
            Assert.AreEqual(word.ReverseString(true), reversed);
        }
        [TestMethod]
        public void DuplicatesRemoved() {
            string word = "Doggos";
            string dupsRemoved = "Dogs";
            Assert.AreEqual(word.RemoveDups(), dupsRemoved);
        }

        [TestMethod]
        public void CountOccurencesWithPattern() 
        {
            string word = "tattarrattat";
            string pattern = "tat";
            Assert.AreEqual(word.CountOccurrences(pattern), 2);
        }
        [TestMethod]
        public void CountOccurensesWithPatternNoMatchs() {
            string word = "Song";
            string pattern = "ew";
            Assert.AreEqual(word.CountOccurrences(pattern), -1);
        }

        [TestMethod]
        public void CountOccurensesByMAX() {
            string word = "tattarrattat";
            ExtendingClass.OccurrenceOptions type = ExtendingClass.OccurrenceOptions.MAX_OCCURANCE;

            Assert.AreEqual(word.CountOccurrences(type), 6);
        }

        [TestMethod]
        public void CountOccurensesByMIN()
        {
            string word = "tattarrattat";
            ExtendingClass.OccurrenceOptions type = ExtendingClass.OccurrenceOptions.MIN_OCCURANCE;

            Assert.AreEqual(word.CountOccurrences(type), 2);
        }

        [TestMethod]
        public void CountOccurensesByMAXVOWELS()
        {
            string word = "alabastor";
            ExtendingClass.OccurrenceOptions type = ExtendingClass.OccurrenceOptions.MAX_OCCURANCE_VOWELS;

            Assert.AreEqual(word.CountOccurrences(type), 3);
        }

        [TestMethod]
        public void CountOccurensesByMINVOWELS()
        {
            string word = "alabastor";
            ExtendingClass.OccurrenceOptions type = ExtendingClass.OccurrenceOptions.MIN_OCCURANCE_VOWELS;

            Assert.AreEqual(word.CountOccurrences(type), 1);
        }
    }
}