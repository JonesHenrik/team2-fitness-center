namespace team2_fitness_center;

public class Main
{
    // Ignore Multi-Club Membership
    // Bullets want us to select a club
    // then give option to select a club or be Multi club
    
    
    // Add Members to list inside of Program class
    // Return a Member, pass in a name and a memberiD
    
    // will return a member either single or multi 
    // in main members.Add(AddMembers)
    
    public Members MultiOrSingleMember(string name, int memberID, List<Club> clubsList)
    {
        // yes to single return a single member
        
        bool isValid = false;
        
        do
        {
            Console.WriteLine("Would you like to be a Multi-Club Member? (y/n): ");
            var input = Console.ReadLine();
            input = input.ToLower().Replace(" ", "");
            
            if (input == "y")
            {
                // Adds a Multi Club
                isValid = false;
                Members multiClubMember = new MultiClubMembers(memberID, name);
                Console.WriteLine($"{name} has been added as a Multi-Club Member!");
                return multiClubMember;
                
            } else if (input == "n")
            {
                // Adds a Single Club
                // Display list of Clubs
                isValid = false;
                DisplayClubs(clubsList);
                // Ask a club
                Club selectedClub = SelectClub(clubsList);
                Members singleClubMember = new SingleClubMembers(memberID, name, selectedClub, false);
                Console.WriteLine($"{name} has been added as a Single-Club Member!");
                return singleClubMember;
            }
            else
            {
                Console.WriteLine("Please enter a valid input of 'y' or 'n'.");
                isValid = true;
            }
        } while (isValid);
        // no return a multiMember
        
        return null;
    }

    public void DisplayClubs(List<Club> clubs)
    {
        Console.WriteLine("Please select one of the following clubs:");
        foreach (var club in clubs)
        {
            Console.WriteLine(club.Name);
        }
    }
    
    // select a Club
    // return a Club
    public Club SelectClub(List<Club> clubs)
    {
        
        bool isValid = false;
        do
        {
            string clubName = Console.ReadLine();
            clubName = clubName.ToLower().Replace(" ", "");
            
            // Check if input is valid
            foreach (var club in clubs)
            {
                if (club.Name == clubName)
                {
                    isValid = false;
                    return club;
                }
            }
        } while (isValid);
        return null;
    }
    
    public Members MemberToRemove(List<Members> membersList)
    {
        // would you like to remove a member (user input)
        // if y DisplayMembers()
        Console.WriteLine("Would you like to remove a member? (y/n): ");
        bool isValid = false;
        do
        {
            string input = Console.ReadLine();
            input = input.ToLower().Replace(" ", "");
            if (input == "y")
            {
                if (membersList.Count > 0)
                {
                    DisplayMembers(membersList);

                    // find out which member to remove
                    Console.WriteLine("What member would you like to remove?");
                    bool correctMember = false;
                    do
                    {
                        string memberToRemove = Console.ReadLine();
                        memberToRemove.ToLower().Replace(" ", "");

                        foreach (var member in membersList)
                        {
                            if (member.Name == memberToRemove)
                            {
                                return member;
                            }
                        }

                    } while (correctMember);
                }
                else
                {
                    Console.WriteLine("Sorry, there are no members to remove.");
                }
                // remove a member from membersList
            }
            else if (input == "n")
            {
                isValid = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid input of 'y' or 'n'.");
                isValid = true;
            }
        } while (isValid);

        // if list contains members
        // if name is in the list 
        return null;
    }

    public void DisplayMembers(List<Members> membersList)
    {
        Console.WriteLine("We have the following members at our Fitness Center:");
        foreach (var member in membersList)
        {
            Console.WriteLine(member.Name);
        }
    }
}