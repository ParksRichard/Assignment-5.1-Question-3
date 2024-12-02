
/*
 * Given an integer array nums, return true if any value appears at least twice in teh array and return false
 * if every element is distinct 
*/


//similar to an older problem
//dictionary instead of array

namespace Assignment_5._1_Question_3
{
    class Program
    {
        public static bool dupes(int[] nums)
        {
            Dictionary<int, int> count = new Dictionary<int, int>(); 

            foreach (var num in nums) //numnumnum
            {
                if (count.ContainsKey(num))
                    //do it the easier way
                {
                    return true;
                }

                count[num] = 1;
            }

            return false;
        }
        public static void Main(string[] args)
        {
            //how to user input?
                //seperate elements?

            //sample numbers
            int[] nums = { 1, 2, 5, 7, 6, 9, 3};

            bool result = dupes(nums);

            if (result)
            {
                Console.WriteLine("There is a duplicate within the numbers.");
            }
            else
            {
                Console.WriteLine("There are no duplicates here.");
            }
        }
    }

}
