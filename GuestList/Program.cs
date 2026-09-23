using System.Data;

if (int.TryParse(Console.ReadLine(), out int numberOfCommands))
{
    string[] arrayOfCommands = new string[numberOfCommands];

    for(int i = 0; i < numberOfCommands; i++)
    {
        arrayOfCommands[i] = Console.ReadLine();
    }

    List<string> guestList = [];
    for(int i = 0; i < numberOfCommands; i++)
    {
        string firstCharacter = arrayOfCommands[i].Split()[0];
        switch (firstCharacter)
        {
            case "+":
                guestList.Add(arrayOfCommands[i].Split()[1]);
                break;

            case"-":
                guestList.Remove(arrayOfCommands[i].Split()[1]);
                break;

            case "?":
                if (guestList.Contains(arrayOfCommands[i].Split()[1]))
                {
                    Console.WriteLine("Jebb");
                } else
                {
                    Console.WriteLine("Neibb");
                }
                break;
        }
    }
}
