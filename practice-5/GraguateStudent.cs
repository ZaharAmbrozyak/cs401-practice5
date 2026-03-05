namespace practice_5;

public class GraduateStudent(string name, string memberId) : UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        actionLog.Add($"Graduate student {name}: Thesis research update");
    }
}