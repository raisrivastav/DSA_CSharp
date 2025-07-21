public class Program
{
    public static int RemoveElement(int[] arr, int val)
    {
        int j = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == val)
            {
                j = i; 
                break;
            }
        }

        if (j == -1) return 0;

        for(int i = j + 1; i < arr.Length; i++)
        {
            if (arr[i] != val)
            {
                arr[j] = arr[i];
                j++;
            }
        }
        return j;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 3, 2, 2, 3 };
        int val = 3;
        int newLength = RemoveElement(arr, val);

        // Output the modified array and new length
        Console.WriteLine("New length: " + newLength);
        Console.WriteLine("Modified array: " + string.Join(", ", arr.Take(newLength)));
    }
}