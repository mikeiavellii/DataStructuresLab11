
Console.Write("Enter a word to reverse: ");
string entry = Console.ReadLine().Trim();
Console.WriteLine($"Your word in reverse is: {Reverse(entry)}."); 


static string Reverse(string s)
{
  string final = "";
  Stack<char> stack = new Stack<char>();
  foreach (char p in s)
  {
    stack.Push(p);
  }
  for (int i = 1; i <= s.Length; i++)
  {
    final += stack.Pop();
  }
  return final;
}

