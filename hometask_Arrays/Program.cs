class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        // Task 1
        PrintArray(arr);

        // Task 2
        Console.WriteLine(SumArray(arr));

        // Task 3
        PrintArrayReverse(arr);

        // Task 4
        int[] reversedArray = ReverseArray(arr);
        PrintArray(reversedArray);

        // Task 5
        Console.WriteLine(MaxArray(arr));

        // Task 6
        Console.WriteLine(CountArray(arr));

        // Task 7
        SortArray(arr);
        PrintArray(arr);

        // Task 8
        Console.WriteLine(CountZeros(arr));

        // Task 9
        Console.WriteLine(CountNegative(arr));

        // Task 10
        Console.WriteLine(SumPositive(arr));

        // Task 11
        int[] squaredArray = SquareArray(arr);
        PrintArray(squaredArray);

        // Task 12
        SortArrayDescending(arr);
        PrintArray(arr);
    }

    // Task 1
    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }

    // Task 2
    public static int SumArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }

    // Task 3
    public static void PrintArrayReverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }

    // Task 4
    public static int[] ReverseArray(int[] arr)
    {
        int[] reversed = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversed[i] = arr[arr.Length - 1 - i];
        }
        return reversed;
    }

    // Task 5
    public static int MaxArray(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    // Task 6
    public static int CountArray(int[] arr)
    {
        return arr.Length;
    }

    // Task 7
    public static void SortArray(int[] arr)
    {
        Array.Sort(arr);
    }

    // Task 8
    public static int CountZeros(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num == 0)
            {
                count++;
            }
        }
        return count;
    }

    // Task 9
    public static int CountNegative(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num < 0)
            {
                count++;
            }
        }
        return count;
    }

    // Task 10
    public static int SumPositive(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            if (num > 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    // Task 11
    public static int[] SquareArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= arr[i];
        }
        return arr;
    }

    // Task 12
    public static void SortArrayDescending(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }
}