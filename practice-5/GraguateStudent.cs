namespace practice_5;

public class GraduateStudent(string name, string memberId) : UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        actionLog.Add($"Graduate student {name}: Thesis research update");
    }

    public override string ShowStatistics()
    {
        return $"Total count of research updates of graduate student {name} = {actionLog.Count}";
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.GraduateActionsCount += actionLog.Count;
    }
}