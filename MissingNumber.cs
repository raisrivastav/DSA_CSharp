class Program
{
    public static int MissingNumber(int[] nums)
    {
        int totalSum = nums.Length;
        int arrSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            totalSum += i;
            arrSum += nums[i];
        }
        return totalSum - arrSum;
    }

    public static void Main(string[] args)
    {
        int[] nums = [0, 1];

        Console.WriteLine(MissingNumber(nums));
    }
}