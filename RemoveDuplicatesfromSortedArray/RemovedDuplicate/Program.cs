public class Solution 
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[]{ 1, 1, 2 , 3, 8, 10};
            Console.WriteLine(solution.RemoveDuplicates(nums));
        }
    }

    public int RemoveDuplicates(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return 0;

        int unic = 0;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[unic])
            {
                unic++;
                nums[i] = nums[unic];
            }
        }

        return unic + 1;   
    }
}