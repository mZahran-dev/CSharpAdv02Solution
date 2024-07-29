using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Xml.Linq;
namespace Advance02
{
    internal class Program
    {
        public static void ReverseInPlace(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        public static int FindFirstNonRepeatedCharacterIndex(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            #region Part 1
            //The Report Link (https://paint-wednesday-ebf.notion.site/Report-on-Collections-in-C-104c7f5f140c4e8fa3c8a7f76c05ed3c)

            #endregion

            #region Part 2
            #region 1.You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            //ReverseInPlace(list);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}


            #endregion

            #region 2.You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> evenNumbers = GetEvenNumbers(numbers);

            //foreach (var num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //}




            #endregion

            #region 3.implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            //Requirements:
            //1.Create a generic class named FixedSizeList<T>.
            //2.Implement a constructor that takes the fixed capacity of the list as a
            //parameter.
            //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            //try
            //{
            //    FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);
            //    fixedSizeList.Add(1);
            //    fixedSizeList.Add(2);
            //    fixedSizeList.Add(3);

            //    for (int i = 0; i < fixedSizeList.Count; i++)
            //    {
            //        Console.WriteLine(fixedSizeList.Get(i));
            //    }

            //    // Console.WriteLine(fixedSizeList.Get(3)); // This will throw an exception

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            #endregion

            #region 4.Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
            //string input = "mahmoud";
            //int index = FindFirstNonRepeatedCharacterIndex(input);
            //Console.WriteLine(index);

            #endregion

            #endregion

        }
    }
}
