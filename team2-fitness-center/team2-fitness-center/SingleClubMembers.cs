namespace team2_fitness_center;

public class SingleClubMembers : Members
{
    public SingleClubMembers(int memberId, string name, Club selectedClub, bool isCheckedIn)
    {
        throw new NotImplementedException();
    }

    public Club Club { get; set; }
    public bool IsCheckedIn { get; set; }
    
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