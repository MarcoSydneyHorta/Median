using System;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first array : ");
            string[] num1 = Console.ReadLine().Split(" ");
            Console.Write("Enter second array : ");
            string[] num2 = Console.ReadLine().Split(" ");
            double res = FindMedianSortedArrays(num1, num2);
            Console.Write("The median numbers is = " + res );
        }
        static public double FindMedianSortedArrays(string[] nums1, string[] nums2)
        {
            
            double median = 0;
            int tam1 = nums1.Length;
            if (nums1[0] == "") tam1 = 0;   // Because the system returns length = 1, even if there is no number
            int tam2 = nums2.Length;
            if (nums2[0] == "") tam2 = 0;
            int tam3 = tam1 + tam2;
            int j = 0;
            string[] nums3 = new string[tam1+tam2];

            if (tam1 <= 0 || tam1 > 1000 || tam2 <= 0 || tam2 > 1000 || (tam1 + tam2) <= 1 || (tam1 + tam2) > 2000)
            { 
                Console.WriteLine("There must be at least one and at most 1000 numbers in each array");
                System.Environment.Exit(1);
            }

            // Put the two string arrays into just one string array

            for (int i = 0; i < tam1; i++)
            {
                nums3[i] = nums1[i];
                j++;
            }
            for (int i = 0; i < tam2; i++)
            {
                nums3[j] = nums2[i];
                j++;
            }

            Array.Sort(nums3);


            if ( tam3 % 2 == 0) // If it's even, take the middle numbers
            {
                median = (double.Parse(nums3[tam3 / 2]) + double.Parse(nums3[tam3 / 2 - 1])) / 2;
            }
            else                // If it's odd, take the center number
            {
                median = double.Parse(nums3[tam3 / 2]);
            }

            
            return median;
        }
    }
}
