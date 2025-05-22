namespace team2_fitness_center;

public abstract class Members
{
    private int memberID;
    private string name;
    public int MemberID { get => memberID; set => memberID = value; }
    public string Name { get => name; set => name = value; }

    public abstract void CheckIn(Club club);

    public Members(int memberID, string name)
    {
        MemberID = memberID; 
        Name = name;
    }
}




