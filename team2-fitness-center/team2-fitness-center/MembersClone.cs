using System.Collections;

namespace team2_fitness_center;

public abstract class MembersClone : IEnumerable
{
    private int Id;
    private string Name;
    public List<MembersClone> members;
    
    public abstract void CheckIn(Club club);

    public MembersClone(int id, string name)
    {
        Id = id;
        Name = name;
        members = new List<MembersClone>();
    }

    public void AddMember(MembersClone member)
    {
        members.Add(member);
    }

    public void RemoveMember(MembersClone member)
    {
        members.Remove(member);
    }

    public void DisplayMemberInformation(MembersClone member)
    {
        // pass in the list of members
        for (int i = 0; i < members.Count; i++)
        {
            if (member == members[i])
            {
                Console.WriteLine($"------ View Member Information Below ------");
                Console.WriteLine($"Name: {member.Name}");
                Console.WriteLine($"Id: {member.Id}");
            }
        }
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}