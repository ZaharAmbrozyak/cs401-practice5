namespace practice_5;

public class GraduateStudent(string name, string memberId) : UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add($"Graduate student {name}: Thesis research update");
    }

    public override string ShowStatistics()
    {
        return $"Total count of research updates of graduate student {name} = {ActionLog.Count}";
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.GraduateActionsCount += ActionLog.Count;
    }
}