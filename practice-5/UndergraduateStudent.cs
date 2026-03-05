namespace practice_5;

public class UndergraduateStudent(string name, string memberId) : UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        actionLog.Add($"Undergraduate student {name}: Lab work completed");
    }

    public override string ShowStatistics()
    {
        return $"Total count of lab works of undergraduate student {name} = {actionLog.Count}";
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.UndergraduateActionsCount += actionLog.Count;
    }
}