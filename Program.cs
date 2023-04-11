// using .NET 7 
using System;

public static class Kata523b4ff7adca849afe000035
{
    // Write a public static method "greet" that returns "hello world!"
    public static string greet()
    {
        char[] charArray = "!dlrow olleh".ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

public class Kata53dc23c68a0c93699800041d // joining words in an array
{
    public static string Smash(string[] words)
    {
        return string.Join(" ", words);
    }
}

public static class Kata55d24f55d7dd296eb9000030 // summing words from 0 to num
{
    public static int summation(int num)
    {
        int sum = 0;
        for (int i = 0; i < num + 1; i++)
        {
            sum += i;
        }
        return sum;
    }
}

public static class Kata52fba66badcd10859f00097e // replace vowels in a string
{
    public static string Disemvowel(string str)
    {
        string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
        foreach (var letter in vowels)
        {
            str = str.Replace(letter, "");
        }
        return str;
    }
}

class Program
{
    static void Main()
    {
        // string result = Kata523b4ff7adca849afe000035.greet();
        // string result = Kata53dc23c68a0c93699800041d.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" });
        // int result = Kata55d24f55d7dd296eb9000030.summation(8);
        string result = Kata52fba66badcd10859f00097e.Disemvowel("Hi this is Mate");
        Console.WriteLine(result);
    }
}
