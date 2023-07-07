// See https://aka.ms/new-console-template for more information

using System;

class Program {
 static void Main() {
        Console.WriteLine("Введите строки, разделенные запятыми:");
 string input = Console.ReadLine();
 string[] words = input.Split(',');
 string[] newWords = new string[words. Length];
 int count = 0;
 for (int i = 0; i < words.Length; i++) {
 if (words[i].Length <= 3) {
 newWords[count++] = words[i];
            }
        }
        Array.Resize(ref newWords, count);
        Console.WriteLine($"Result: {string.Join(",", newWords)}");
    }
}