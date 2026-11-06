string[] party = { "Aaron", "Al", "Ade", "Billy" };

// Display all party members using a for loop
for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"Member {i+1}: {party[i]}");
}

// Change the third party member
party[3] = "Fakhri";
Console.WriteLine($"\nUpdate Member 2: {party[3]}");