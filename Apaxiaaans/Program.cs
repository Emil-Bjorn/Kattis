string? name = Console.ReadLine();
if (name != null)
{
    char[] nameChars = name.ToCharArray();
    List<char> shortenedChars = new List<char>();
    for (int i = 0; i < nameChars.Length; i++)
    {
        if (i == 0)
        {
            shortenedChars.Add(nameChars[i]);
        } else
        {
            if (nameChars[i] != nameChars[i-1])
            {
                shortenedChars.Add(nameChars[i]);
            }
        }
    }
    string shortenedName = string.Concat(shortenedChars);
    Console.WriteLine(shortenedName);
}