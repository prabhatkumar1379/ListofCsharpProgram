// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Try programiz.pro");
        string res = GetUniqueCharacter("hello there");
        Console.WriteLine("------------");
        Countcharacter(res);
        Console.WriteLine("------------");
        Countcharacter("hello there");

    }
    public static string GetUniqueCharacter(string str)
    {
        string result = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (!result.Contains(str[i]))
            {
                result = result + str[i];
            }
        }
        Console.Write(result);
        return result;
    }
    internal static void Countcharacter(string str)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        foreach (var character in str)
        {
            if (character != ' ')
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

        }
        foreach (var character in characterCount)
        {
            Console.WriteLine("{0} - {1}", character.Key, character.Value);
        }
    }

}