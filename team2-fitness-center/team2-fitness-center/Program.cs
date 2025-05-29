namespace team2_fitness_center;

//A main class which takes input from the user:

// Asks a user if they want to select a club

// Added members should be given the option to select from at least 4
// fitness center locations or have the option to be a multi-club member.

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Fitness Center App!");
        // Prompt user for add, remove, or display member
        
        
        // make 4 clubs
        List<Club> clubs = new List<Club>
        {
           // new Club("LA Fitness", "2846 Woodward"),
           // new Club("Powerhouse", "736 Mack Blvd"),
           // new Club("Detroit Boxing Gym", "293 GrandCircus Blvd"),
           // new Club("Elevate Fitness", "3929 E Jefferson Blvd"),
        };
        
        List<Members> members = new List<Members>();
        //members.Add(new MultiClubMembers(1, false, "Brock", 52790));
        //members.Add(new SingleClubMembers(clubs[0], false, "Kyle", 25763));
        //members.Add(new SingleClubMembers(clubs[1], false, "Brad", 55532));

        Main main = new Main();
        
        Console.WriteLine("Would you like to add a member? (y/n): ");
        string isAddingMember = Console.ReadLine();
        // handle incorrect input
        isAddingMember = isAddingMember.ToLower().Replace(" ", "");
        bool isValid = false;
        do
        {
            if (isAddingMember == "y")
            {
                isValid = false;
                Console.WriteLine("Please enter your name: ");
                string newName = Console.ReadLine();
                
                Random rng = new Random();
                
                // Calling from main class
                Members addedMember = main.MultiOrSingleMember(newName, rng.Next(Int32.MaxValue), clubs);
                members.Add(addedMember);
                
                
               // Members newMember = new Members(rng.Next(Int32.MaxValue), newName);
            } else if (isAddingMember == "n")
            {
                isValid = false;
            }
            else
            {
                Console.WriteLine("Please enter either 'y' or 'n'!");
                isValid = true;
            }
        } while (isValid);
        
        // Would you like to display list of members?
        Console.WriteLine("Would you like to display our list of Members? (y/n): ");
        bool isValidDisplay = false;

        do
        {
            string wantsDisplay = Console.ReadLine();
            wantsDisplay = wantsDisplay.ToLower().Replace(" ", "");

            if (wantsDisplay == "y")
            {
                // if yes, display members
                isValidDisplay = false;
                main.DisplayMembers(members);
            }
            else if (wantsDisplay == "n")
            {
                // if no, move on
                isValidDisplay = false;
            }
            else
            {
                Console.WriteLine("Please enter either 'y' or 'n'!");
                isValidDisplay = true;
            }
        } while (isValidDisplay);


        
        
        
        
        
        // Would you like to remove a member from the list?
        Members removeMember = main.MemberToRemove(members);
        members.Remove(removeMember);
        
        
        // Would you like to check in a member at a particular club
        
        
        // Select a member to generate a bill of fees w Membershop points if MultiClub
    }
}