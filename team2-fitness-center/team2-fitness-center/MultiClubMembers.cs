namespace team2_fitness_center;

public class MultiClubMembers : Members
{
    private int MembershipPoints;
    private bool IsCheckedIn;
    
    public MultiClubMembers(int membershipPoints, bool isCheckedIn, string name, int memberID) : base(membershipPoints, name)
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