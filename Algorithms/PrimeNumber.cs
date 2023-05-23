namespace Algorithms
{
    internal partial class AnagramDetectionS


    {
        class PrimeNumber

    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            int i = 0;
            int j = numStr.Length - 1;

            while (i < j)
            {
                if (numStr[i] != numStr[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }

        static bool IsAnagram(int number)
        {
            string numStr = number.ToString();
            char[] numChars = numStr.ToCharArray();
            Array.Sort(numChars);

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    string factorStr = i.ToString();
                    char[] factorChars = factorStr.ToCharArray();
                    Array.Sort(factorChars);

                    if (numChars.SequenceEqual(factorChars))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers from 1 to 100:");

            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i);

                    if (IsPalindrome(i))
                    {
                        Console.Write(" (Palindrome)");
                    }

                    if (IsAnagram(i))
                    {
                        Console.Write(" (Anagram)");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }

}
}


