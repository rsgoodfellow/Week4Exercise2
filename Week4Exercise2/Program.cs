using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise2
{
    internal class Program
    {
        static void NumbersPrint(int[] nums) //method to print out every number in the array
        {
            foreach (int num in nums) //foreach loop to loop through every index
            { 
                Console.WriteLine(num); //displays the number in the index
            }
        }
        static void NumbersSum(int[] nums) //method to determine the sum of all the numbers in the array
        {
            int sum = 0; //declares and initializes sum variable
            foreach (int num in nums) //foreach loop to loop through every index
            {
                sum += num; //adds the number in the index to the sum
            }
            Console.WriteLine("The total sum of the numbers in the array is: " + sum); //displays the sum
        }

        static void NumbersMax(int[] nums) //method to find the largest number of the array
        {
            int max = 0; //declares and initalizes max variable
            foreach (int num in nums) //foreach loop to check every index
            {
                if (num > max) max = num; //if number in this index is larger than max variable, it is set to be the max variable
            }
            Console.WriteLine("The largest number is: " + max); //displays text on what number is the largest
        }

        static void NumbersMin(int[] nums) //method to find the smallest number of the array
        {
            int min = 100; //declares and initalizes min variable
            foreach (int num in nums) //foreach loop to check every index
            {
                if (num < min) min = num; //if number in this index is smaller than min variable, it is set to be the min variable
            }
            Console.WriteLine("The smallest number is: " + min); //displays text on what number is the smallest
        }

        static void NumbersReverse(int[] nums) //method to print out the array in reverse order
        {
            for (int i = nums.Length - 1; i >= 0; i--) //loop to start at the end of the array and to loop to the begining
            {
                Console.WriteLine(nums[i]); //prints number in the index
            }
        }
        static void Main(string[] args) //main method
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //declares and initializes array

            NumbersPrint(numbers); //calls NumbersPrint method with the array as input
            NumbersSum(numbers); //calls NumbersSum method with the array as input
            NumbersMax(numbers); //calls NumbersMax method with the array as input
            NumbersMin(numbers); //calls NumbersMin method with the array as input
            NumbersReverse(numbers); //calls NumbersReverse method with the array as input

            Console.Read(); //lets user read program
        }
    }
}
