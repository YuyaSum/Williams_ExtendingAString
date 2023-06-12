using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Williams_ExtendingAString
{
    public static class ExtendingClass
    {
        public static bool IsPalindrome(this string test)
        {
            int left = 0;
            int right = test.Length - 1;

            while (left < right)
            {
                if (test[left] != test[right]) { return false; }
                left++;
                right--;
            }
            return true;
        }

        public static bool IsPalindrome(this string test, bool sensitive)
        {
            if (sensitive == false)
            {
                test = test.ToLower();
            }

            return IsPalindrome(test);
        }

        public static string ReverseString(this string test)
        {
            char[] charArray = test.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseString(this string test, bool keepCapsSpot)
        {
            StringBuilder reversedString = new StringBuilder(test.Length);
            int length = test.Length;

            if (keepCapsSpot == true)
            {
                for (int i = 0; i < length; i++)
                {
                    char currentChar = test[i];
                    char reversedChar = char.IsUpper(currentChar)
                        ? char.ToUpper(test[length - i - 1])
                        : char.ToLower(test[length - i - 1]);

                    reversedString.Append(reversedChar);
                }

                return reversedString.ToString();
            }
            else
            {
                return ReverseString(test);
            }
        }

        public static int CountOccurrences(this string test, string pattern)
        {
            int count = 0;
            int lastIndex = 0;

            while ((lastIndex = test.IndexOf(pattern, lastIndex)) != -1)
            {
                count++;
                lastIndex += pattern.Length;
            }

            if (count == 0) { return -1; }

            return count;
        }

        public static string RemoveDups(this string test)
        {
            StringBuilder result = new StringBuilder();
            HashSet<char> seenChars = new HashSet<char>();

            foreach (char c in test)
            {
                if (!seenChars.Contains(c))
                {
                    result.Append(c);
                    seenChars.Add(c);
                }
            }

            return result.ToString();
        }

        public enum OccurrenceOptions
        {
            MAX_OCCURANCE,
            MIN_OCCURANCE,
            MAX_OCCURANCE_VOWELS,
            MIN_OCCURANCE_VOWELS
        }

        public static int CountOccurrences(this string test, OccurrenceOptions type)
        {
            Dictionary<char, int> charNums = new Dictionary<char, int>();
            Dictionary<char, int> vowelNums = new Dictionary<char, int>();

            foreach (char c in test)
            {
                if (char.IsLetter(c)) {

                    char lowerC = char.ToLower(c);
                    if (charNums.ContainsKey(lowerC))
                    {
                        charNums[lowerC] += 1;
                    }
                    else {
                        charNums[lowerC] = 1;
                    }
                }
            }

            foreach (KeyValuePair<char, int> pair in charNums)
            {
                char key = pair.Key;

                if (IsVowel(key))
                {
                    vowelNums.Add(key, pair.Value);
                }
            }

            if (type == OccurrenceOptions.MAX_OCCURANCE)
            {
                return charNums.Values.Max();
            }
            else if (type == OccurrenceOptions.MIN_OCCURANCE) 
            {
                return charNums.Values.Min();
            }
            else if (type == OccurrenceOptions.MAX_OCCURANCE_VOWELS) 
            {
                return vowelNums.Values.Max();
            }
            else 
            {
                return vowelNums.Values.Min();
            }
        }

        private static bool IsVowel(char c)
        {
            char lowerC = char.ToLower(c);

            return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
        }

    }
}
