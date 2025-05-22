namespace team2_fitness_center;

public class SingleClubMembers : Members
{
    private Club Club;
    private bool IsCheckedIn;

    public SingleClubMembers(Club club, bool isCheckedIn, string name, int memberID) : base(memberID, name)
    {
        Club = club;
        IsCheckedIn = isCheckedIn;
    }
    public override void CheckIn(Club club)
    {
        // throws an exception if it is not their club
        try
        {
            Club = club;
            IsCheckedIn = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("You are not a member of this club");
        }
    }
}