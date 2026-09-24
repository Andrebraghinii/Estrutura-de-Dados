using System.Collections.Generic;

Stack<char> chars = new Stack<char>();

string text = string.Empty;
Console.WriteLine("Digite uma Palavra");
text = Console.ReadLine();

string reversedText = string.Empty;
foreach (char c in text)
{
    chars.Push(c);
}


while (chars.Count > 0)
{
    Console.Write(chars.Pop());
        reversedText += c;
}

string isPalindromo = 
Text == reversedText
    ? "É palíndromo"
    : "Não é palíndromo";

Console.WriteLine("");