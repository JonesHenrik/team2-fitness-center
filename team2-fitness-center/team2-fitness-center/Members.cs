namespace team2_fitness_center;

public abstract class Members
{
    public int MemberID { get; set; }
    public string Name { get; set; }

    public abstract void CheckIn(Club club);
}




