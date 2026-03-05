namespace practice_5;

public class UndergraduateStudent(string name, string memberId) : UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        actionLog.Add($"Undergraduate student {name}: Lab work completed");
    }
    
}