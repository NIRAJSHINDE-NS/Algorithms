namespace Algorithms
{
    internal partial class AnagramDetectionS

    {
        internal class Anagram
        {
            public void AnagramMethod(string firstStr, string secondStr)
            {
                if (firstStr.Length != secondStr.Length)
                {
                    Console.WriteLine("String Length is not same");
                }

                char[] firstArray = firstStr.ToLower().ToCharArray();
                char[] secondArray = secondStr.ToLower().ToCharArray();
                char temp;

                for (int i = 0; i < firstArray.Length; i++)
                {
                    for (int j = i + 1; j < firstArray.Length; j++)
                    {
                        if (firstArray[i] > firstArray[j])
                        {
                            temp = firstArray[i];
                            firstArray[i] = firstArray[j];
                            firstArray[j] = temp;
                        }
                    }

                }

                for (int i = 0; i < secondArray.Length; i++)
                {
                    for (int j = i + 1; j < secondArray.Length; j++)
                    {
                        if (secondArray[i] > secondArray[j])
                        {
                            temp = secondArray[i];
                            secondArray[i] = secondArray[j];
                            secondArray[j] = temp;
                        }
                    }

                }

                for (int i = 0; i < firstArray.Length; i++)
                {

                    if (firstArray[i].ToString() == secondArray[i].ToString())
                    {

                        Console.WriteLine("Both the strings are Anagram strings");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not an Anagram string");
                        break;
                    }
                }
            }
        }
    }
}
