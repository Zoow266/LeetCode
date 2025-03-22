public class Solution
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int x = 12231;
            Console.WriteLine(IsPalindrome(x));
        }
    }

    public static bool IsPalindrome(int x)
    {
        string original = x.ToString();
        string reversed = new string(x.ToString().Reverse().ToArray());

        if (original == reversed)
        {
            return true;
        }
        return false;
    }
}