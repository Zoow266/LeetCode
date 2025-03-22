public class Solution
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Solution solution = new Solution();
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            int result = solution.RemoveElement(nums, val);

            Console.WriteLine(result);
        }
    }

    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        foreach (int i in nums) 
        {
            if(i != val) 
            {
                nums[k] = i;
                k++;
            }
        }

        return k;
    }
}