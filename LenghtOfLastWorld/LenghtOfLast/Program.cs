public class Solution 
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "Hello World";
            Console.WriteLine(solution.LengthOfLastWord(s));
        }
    }
    public int LengthOfLastWord(string s) 
    {
        var words = s.TrimEnd().Split(' '); 
        return words[^1].Length;
    }
}