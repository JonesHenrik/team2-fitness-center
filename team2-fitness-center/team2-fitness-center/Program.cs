namespace team2_fitness_center;

//A main class which takes input from the user:

// Asks a user if they want to select a club

// Added members should be given the option to select from at least 4
// fitness center locations or have the option to be a multi-club member.

class Program
{
    static void Main()
    {
        // make 4 clubs
        List<Club> clubs = new List<Club>
        {
            new Club("LA Fitness", "2846 Woodward"),
            new Club("Powerhouse", "736 Mack Blvd"),
            new Club("Detroit Boxing Gym", "293 GrandCircus Blvd"),
            new Club("Elevate Fitness", "3929 E Jefferson Blvd"),
        };

        // ask for name and if multi/single club member
        Console.Write("Enter member name: ");
        string name = Console.ReadLine();
        
        Console.Write("Is this a multi-club member? (y/n): ");
        string response = Console.ReadLine().ToLower();

        
        
        
        if (response == "y")
        {
            MultiClubMembers multiMember = new MultiClubMembers(1, false);
            Console.WriteLine($"Added Multi-Club Member: {name}");
        }
        else
        {
            // give club choices then choose the club
            
            Console.WriteLine("Choose a club:");
            for (int i = 0; i < clubs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clubs[i]}");
            }
            
            int clubChoice = int.Parse(Console.ReadLine());
            Club selectedClub = clubs[clubChoice - 1];
            
            SingleClubMembers singleMember = new SingleClubMembers(selectedClub, false);
            Console.WriteLine($"Added Single-Club Member: {name} at {selectedClub}");
        }
    }
}