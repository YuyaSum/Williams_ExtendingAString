using System.Text;

namespace Williams_ExtendingAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What string would you like to test?");
            string test = "Doggo";

            Console.WriteLine("Test to see if " + test + " is a Palindrome");
            Console.WriteLine(ExtendingClass.IsPalindrome(test) + "\n");

            test = "Racecar";
            Console.WriteLine("Test to see if " + test + " is a Palindrome without and with Case sensitive");
            Console.WriteLine(ExtendingClass.IsPalindrome(test, false));
            Console.WriteLine(ExtendingClass.IsPalindrome(test, true) + "\n");

            Console.WriteLine("Removes any Duplicate Characters (R and r are differnt)");
            Console.WriteLine(ExtendingClass.RemoveDups(test) + "\n");

            Console.WriteLine("Reverses text and second one keeps track of where caps are");
            Console.WriteLine(ExtendingClass.ReverseString(test));
            Console.WriteLine(ExtendingClass.ReverseString(test, true) + "\n");
            
            Console.WriteLine("Inserting pattern (ca) to see how many times it appears in text");
            Console.WriteLine(ExtendingClass.CountOccurrences(test, "ca") + "\n");

            test = "DoggooosBeCute";
            Console.WriteLine("Testing " + test + " to see the Max and Min characters in the text");
            Console.WriteLine(ExtendingClass.CountOccurrences(test, ExtendingClass.OccurrenceOptions.MAX_OCCURANCE));
            Console.WriteLine(ExtendingClass.CountOccurrences(test, ExtendingClass.OccurrenceOptions.MIN_OCCURANCE) + "\n");

            Console.WriteLine("Same test, but only for Vowles");
            Console.WriteLine(ExtendingClass.CountOccurrences(test, ExtendingClass.OccurrenceOptions.MAX_OCCURANCE_VOWELS));
            Console.WriteLine(ExtendingClass.CountOccurrences(test, ExtendingClass.OccurrenceOptions.MIN_OCCURANCE_VOWELS));

        }
    }
}