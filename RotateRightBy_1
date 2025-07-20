class Program
{
    public static void RotateRightBy1(int[] arr)
    {
        // code here
        int temp = arr[arr.Length - 1];
        for (int i = arr.Length - 1; i > 0 ; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = temp;
    }

    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};

        RotateRightBy1(arr);

        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}