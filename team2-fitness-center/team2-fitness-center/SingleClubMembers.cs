namespace team2_fitness_center;

// switch back to Members
public abstract class SingleClubMembers : MembersClone
{
    private Club Club;
    private bool IsCheckedIn;

    public SingleClubMembers(Club club, bool isCheckedIn)
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