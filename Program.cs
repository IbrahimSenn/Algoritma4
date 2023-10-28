// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class program
{
    static void Main()
    {
        Console.WriteLine("Metin giriniz :");
        string inputs = Console.ReadLine();

        string result = SwapLetter(inputs);


        Console.WriteLine($"sonuç : {result}");
    }

    static string SwapLetter(string text )
    {
        string[] words = text.Split(' ');
        string nw = "";

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars= words[i].ToCharArray();

            if (chars.Length > 1)
            {
                char term = chars[0];
                chars[0] = chars[chars.Length - 1];
                chars[chars.Length - 1] = term;

            }

            nw += new string(chars) + " ";

        }


        return nw ;
    }
}