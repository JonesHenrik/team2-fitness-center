namespace team2_fitness_center;

public class SingleClubMembers : Members
{
    private Club Club;
    private bool IsCheckedIn;

    public SingleClubMembers(Club club, bool isCheckedIn)
    {
        Club = club;
        IsCheckedIn = isCheckedIn;
    }
    public override CheckIn()
    {
        // throw exception if it is not their club
    }
    
    // need to add constructors
}