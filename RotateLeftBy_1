public class Program
{
    public static void RotateLeftBy_1(int[] arr)
    {
        int temp = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            arr[i-1] = arr[i];
        }

        arr[arr.Length - 1] = temp;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        RotateLeftBy_1(arr);

        Console.WriteLine("After rotate the array left by one element");

        foreach(int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}