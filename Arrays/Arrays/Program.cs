using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"One","Two","Three"};
            int[] numbers = {1,2,3};

            for(int c = 0; c < names.Length; c++) 
            {
                Console.WriteLine(names[c]);
                Console.WriteLine(numbers[c]);
            }

            //Changes the first value at postion 0 of names to "NumberOne"
            names[0] = "NumberOne";

            for (int c = 0; c < names.Length; c++)
            {
                Console.WriteLine(names[c]);
                Console.WriteLine(numbers[c]);
            }

            //Prints value at numbers index 1
            Console.WriteLine(numbers[1]);

            //retunrs array length
            Console.WriteLine("Names array has " + names.Length + " elements");
            Console.WriteLine("Numbers array has " + numbers.Length + " elements");

            //using foreach loop to iterate over array 
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Sorts array using Array.Sort(); this will always sort in ascending order
            int[] NumbersTwo = { 8, 6, 2, 1, 9, 10, 500 };
            Array.Sort(NumbersTwo);
            foreach(int number in NumbersTwo) 
            {
                Console.Write(" " + number);
            }

            //You can also declare an array that is yet to be filled. 
            string[] Words = new string[4];

            Words[1] = "Hello";
            Words[2] = "World";

            foreach(string word in Words)
            {
                Console.WriteLine(" " + word);
            }
            
        }
    }
}
