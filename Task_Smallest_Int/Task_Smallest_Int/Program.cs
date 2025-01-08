namespace Solution //don't work in common, need to comment 1 of 2 solution for start
{
    //TASK----------------------------------------------------
    /*
    Implement a function that takes an array of integers and returns the smallest positive integer (greater than 0) that is missing from the array.

    Examples:
    For the array [1, 3, 6, 4, 1, 2], the function should return 5 because all numbers from 1 to 4 are present, but 5 is missing.
    For the array [1, 2, 3], the result should be 4 because all numbers from 1 to 3 are present.
    For the array [-1, -3], the result should be 1 because there are no positive numbers in the array.
    Constraints:
    The size of the array is between 1 and 100,000.
    Each element in the array is an integer within the range of −1,000,000 to 1,000,000.
    The algorithm should be efficient and handle large input sizes effectively.*/
    class Solution //positive:easy to write, don't use additional memory
        //negative:bad decision for large arrays cuz hard to operate. hard to read. 
    {
        static void SolutionMethod(Array array)
        {
            int maxint = 1000000;
            int answer = 0;
            int count = 0;
            int i;

            if (array.Length > 100000 || array.Length < 1)
            {
                Console.WriteLine("Wrong array");
                return;
            }

            foreach (int element in array)
            {

            }
            for (i = 1; i < maxint; i++)
            {
                count = 0;
                if (answer != 0)
                {
                    break;
                }
                foreach (int integer in array)
                {
                    if (i == integer)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    answer = i;
                }
            }
            Console.WriteLine(answer);
        }
        public static void Main(string[] args)
        {

            int[] A = { 1, 3, 6, 4, 1, 2 };
            SolutionMethod(A);
        }
    }
    class Solution2//positive: easy to read, good decision for large arrays, in general better realisation of task.
        //negative: uses additional memory for hashset.
    {
        static void SolutionMethod(int[] array)
        {
            
            HashSet<int> variables = new HashSet<int>();
            foreach (int element in array)
            {
                if (element < -1000000 || element > 1000000)
                {
                    Console.WriteLine("Wrong array");
                    return;
                }
                if (element > 0) { variables.Add(element); }
            }
            int i = 1;
            while (i<1000000)
            {
                if (!variables.Contains(i))
                {
                    Console.WriteLine("The smallest positive integer: {0}",i);
                    return;
                }
                else { i++; }
                
            }

        }
        public static void Main(string[] args)
        {

            int[] A = { 1, 3, 6, 4, 1, 2 };
            SolutionMethod(A);
        }
    
    }
}