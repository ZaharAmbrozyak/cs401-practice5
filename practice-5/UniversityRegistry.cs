namespace practice_5;

public class UniversityRegistry
{
    private List<UniversityMember> members = [];

    public void AddMember(UniversityMember member)
    {
        members.Add(member);
    }

    public void ExecuteAllDuties()
    {
        foreach (var member in members)
        {
            member.PerformDuties();
        }
    }

    public void GetMemberStatistics()
    { 

        foreach (var member in members)
        {
            member.ShowStatistics();
        }
    }
}