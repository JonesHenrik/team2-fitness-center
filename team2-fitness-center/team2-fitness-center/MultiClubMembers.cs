namespace team2_fitness_center;

public class MultiClubMembers(int memberId, string name) : Members
{
    public int MembershipPoints { get; set; }
    public bool IsCheckedIn { get; set; }

    public override void CheckIn(Club club)
    {
        // throw new NotImplementedException();
        MembershipPoints += 1;
        IsCheckedIn = true;
    }
}