namespace practice_5;

public class Professor(string name, string memberId): UniversityMember(name, memberId)
{
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add($"Professor {Name}: Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        ActionLog.Add($"Conducted research about {topic}");
    }

    public override string ShowStatistics()
    {
        return $"Total count of actions of professor {Name} = {ActionLog.Count}";
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.ProfessorsActionsCount += ActionLog.Count;
    }
}