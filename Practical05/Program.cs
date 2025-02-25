namespace Practical05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array initialization with 5 elements
            int[] arr = { 1, 2, 3, 4, 5 };
            //Try block to handle exception
            try
            {
                //Iterating through the array and printing with its index
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine($"Index {i}:- {arr[i]}");
                }
            }
            //Catch Block to handle IndexOutOfRangeException
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("You have an error:- " + e.Message);
            }
            //Finally block to execute the code even if exception occurs
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
        }
    }
}
