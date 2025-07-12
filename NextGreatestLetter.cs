public class Program
{
    public static char NextGreatestLetter(char[] letters, char target)
    {
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] > target)
            {
                return letters[i];
            }
        }
        return letters[0];
    }
    public static void Main(string[] args)
    {
        char[] letters = ['x', 'x', 'y', 'y'];
        char target = 'z';

        Console.Write(NextGreatestLetter(letters, target));
    }
}