namespace team2_fitness_center;

public class MultiClubMembers : Members
{
    private int MembershipPoints;
    private bool IsCheckedIn;
    
    public MultiClubMembers(int membershipPoints, bool isCheckedIn)
    {
        MembershipPoints = membershipPoints;
        IsCheckedIn = isCheckedIn;
    }

    public override CheckIn()
    {
        // add membership points
        // maybe just add one?
    }
    
    // need to add constructors
}