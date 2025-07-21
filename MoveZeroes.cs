 public class Program
{
    public static void MoveZeroes(int[] nums)
    {
        int j = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                j=i; 
                break;
            }
        }

        if(j==-1) return;

        for (int i = j+1; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j++;
            }
        }


    }

    public static void Main(string[] args)
    {
        int[] nums = [3, 0, 1, 0, 3, 12];
        MoveZeroes(nums);

        foreach (int num in nums) {
            Console.WriteLine(num);
        }
    }
}