﻿// using .NET 7 
using System;
using System.Linq;

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

public static class Kata546f922b54af40e1e90001da // getting the position of the letter in the alphabet - this works in .net 7, but not in the codewars enviroment
{
    public static string AlphabetPosition(string text)
    {
        string[] lowercaseLetters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string modifiedText = text.ToLower();
        string res = "";
        for (int i = 0; i < modifiedText.Count(); i++)
        {
            if (Array.IndexOf(lowercaseLetters, modifiedText[i].ToString()) > -1) // 
            {
                res += Array.IndexOf(lowercaseLetters, modifiedText[i].ToString()) + 1; // need +1 because of indext starting at 0 in arrays
                res += " ";
            }
        }
        return res.TrimEnd();
    }
}

public class Persist55bf01e5a717a0d57e0000ec //  takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.
{
    public static int Persistence(int n)
    {
        int counter = 0;
        while (n > 9)
        {
            int newN = 1;
            for (int i = 0; i < n.ToString().Count(); i++)
            {
                string strNum = $"{n.ToString()[i]}"; // convert the num to string this way, it gets problematic bc of c# tries to compile it to a char first - this works

                int intNum = Int32.Parse(strNum); ;

                newN = newN * intNum;

            }
            n = newN;
            counter += 1;
        }

        return counter;
    }
}

public static class Kata55fd2d567d94ac3bc9000064 // in progress
{


    public static long RowSumOddNumbers(long n)
    {
        //int counter = 0;
        // for (int i = 1; i <= n; i++)
        // {
        //     Console.WriteLine(i + "iteracio:");
        //     for (int j = 1; j <= n; j += 2 + 1)
        //     {
        //         Console.WriteLine(j);
        //     }
        // }
        return n;
    }
}

public class Kata5264d2b162488dc400000001 // give back the sentence, if a word in it is longer than 4 words, reverse it
{
    public static string SpinWords(string sentence)
    {
        string newSentence = "";
        string[] words = sentence.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 4)
            {
                char[] reversedWordArray = words[i].ToCharArray();
                Array.Reverse(reversedWordArray);
                words[i] = String.Join("", reversedWordArray);
            }
            // System.Console.WriteLine(words[i]);
        }
        newSentence = String.Join(" ", words);
        return newSentence;
    }
}

public class Kata526571aae218b8ee490006f4 // return the binary number'ss sum of 1-s of an integer
{
    public static int CountBits(int n)
    {
        int bits = 0;
        string binary = Convert.ToString(n, 2); // to base 2

        foreach (char num in binary) // counting the bits
        {
            System.Console.WriteLine(num);
            if (num == '1')
            {
                bits++;
            }
        }

        return bits;
    }
}

public class Kata576757b1df89ecf5bd00073b // Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] tower = new string[nFloors];
        string stars = "";

        for (int i = 0; i < nFloors * 2 - 1; i++) // create a string with the max number of stars
        {
            stars += "*";
        }

        for (int i = 0; i < nFloors; i++)
        {
            tower[i] = stars;

            char[] starArray = stars.ToCharArray(); // convert into charray, replace the characters with the right index with a space 
            starArray[0 + i] = ' ';

            Array.Reverse(starArray); // doing it in both ends of the charray
            starArray[0 + i] = ' ';

            stars = String.Join("", starArray);
        }

        Array.Reverse(tower);
        return tower;
    }
}

class Program
{
    static void Main()
    {
        // string result = Kata523b4ff7adca849afe000035.greet();
        // string result = Kata53dc23c68a0c93699800041d.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" });
        // int result = Kata55d24f55d7dd296eb9000030.summation(8);
        // string result = Kata52fba66badcd10859f00097e.Disemvowel("Hi this is Mate");
        // string result = Kata546f922b54af40e1e90001da.AlphabetPosition("The sunset sets at twelve o' clock.");
        // int result = Persist55bf01e5a717a0d57e0000ec.Persistence(999);
        // long result = Kata55fd2d567d94ac3bc9000064.RowSumOddNumbers(10);
        // string result = Kata5264d2b162488dc400000001.SpinWords("asd 12345");
        // int result = Kata526571aae218b8ee490006f4.CountBits(1234);
        string[] result = Kata576757b1df89ecf5bd00073b.TowerBuilder(19);
        foreach (var item in result) System.Console.WriteLine(item);
    }
}

