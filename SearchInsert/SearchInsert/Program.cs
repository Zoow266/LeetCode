public class Solution 
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var nums = new int[] {1, 3, 5, 6};
            int target = 0;

            int result = SearchInsert(nums, target);
            Console.WriteLine(result);
        }
    }
    public static int SearchInsert(int[] nums, int target) 
    {
        int check = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) return i;
            if(target < nums[i])
            {
                return i;
            }
            if(i == nums.Length - 1 && check == 0)
            {
                check = i + 1;
            }
        }
        return check;
    }
}