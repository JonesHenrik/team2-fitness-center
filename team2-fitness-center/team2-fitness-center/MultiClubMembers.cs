namespace team2_fitness_center;

// Switch back to Members
public class MultiClubMembers : MembersClone
{
    private int MembershipPoints;
    private bool IsCheckedIn;
    
    public MultiClubMembers(int membershipPoints, bool isCheckedIn)
    {
        MembershipPoints = membershipPoints;
        IsCheckedIn = isCheckedIn;
    }

    public override void CheckIn(Club club)
    {
        // throw new NotImplementedException();
        MembershipPoints += 1;
        IsCheckedIn = true;
    }
}