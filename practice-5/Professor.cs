namespace practice_5;

public class Professor(string name, string memberId): UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        actionLog.Add($"Professor {name}: Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        actionLog.Add($"Conducted research about {topic}");
    }

    public override string ShowStatistics()
    {
        return $"Total count of actions of professor {name} = {actionLog.Count}";
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.ProfessorsActionsCount += actionLog.Count;
    }
}