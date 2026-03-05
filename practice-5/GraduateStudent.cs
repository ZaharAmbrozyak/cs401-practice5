namespace practice_5;

public class GraduateStudent(string name, string memberId) : UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add($"Graduate student {Name}: Thesis research update");
    }

    public override string ShowStatistics()
    {
        return $"Total count of research updates of graduate student {Name} = {ActionLog.Count}";
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.GraduateActionsCount += ActionLog.Count;
    }
}