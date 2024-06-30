using System;

class Program
{
    static void Main()
    {
        int[] ints = { 1, 2, 3,8,9,1 };

        var result = MinimalWindow(ints, 3);
        foreach (int i in result) 
        {
            Console.WriteLine(i);
        }
    }
    public static List<int> MinimalWindow(int[] array, int window)
    {
        List<int> minNumber = new List<int>();
        List<int> windowList = new List<int>();

        for (int i = 0; i < array.Length - window + 1; i++) 
        {
            for (int j = i; j < window +i; j++)
            {
                windowList.Add(array[j]);
            }
            minNumber.Add(windowList.Min());
            windowList.Clear();
        }
        return minNumber;
    }
}
