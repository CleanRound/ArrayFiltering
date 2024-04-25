internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the original array separated by spaces:");
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Enter the elements of the array for filtering separated by spaces:");
        int[] arrayForFiltering = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] result = FilterArray(originalArray, arrayForFiltering);

        Console.WriteLine("Result after filtering:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }

    static int[] FilterArray(int[] originalArray, int[] arrayForFiltering)
    {
        HashSet<int> filterSet = new HashSet<int>(arrayForFiltering);

        List<int> resultList = new List<int>();
        foreach (int num in originalArray)
        {
            if (!filterSet.Contains(num))
            {
                resultList.Add(num);
            }
        }

        return resultList.ToArray();
    }
}