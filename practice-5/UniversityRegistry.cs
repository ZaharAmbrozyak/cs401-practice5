namespace practice_5;

public class UniversityRegistry
{
    private readonly List<UniversityMember> _members = [];

    public void AddMember(UniversityMember member)
    {
        _members.Add(member);
    }

    public void ExecuteAllDuties()
    {
        foreach (var member in _members)
        {
            member.PerformDuties();
        }
    }

    public void GetMemberStatistics()
    {
        var universityStatistics = new UniversityStatistics();
        
        foreach (var member in _members)
        {
            Console.WriteLine(member.ShowStatistics());
            member.ModifyStatistics(universityStatistics);
        }
        
        Console.WriteLine(universityStatistics.GetSummary());
        
    }
}