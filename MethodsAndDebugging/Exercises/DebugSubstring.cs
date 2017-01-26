using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char search = 'p';
        bool isAMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                isAMatch = true;

                int lenght = jump + 1;

                if (i + lenght > text.Length)
                {
                    lenght = text.Length - i;
                }

                string matchedString = text.Substring(i, lenght);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!isAMatch)
        {
            Console.WriteLine("no");
        }
    }
}
