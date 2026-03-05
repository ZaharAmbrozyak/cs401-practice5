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
        Console.WriteLine($"Conducted research about {topic}!");
    }

    public override void ShowStatistics()
    {
        Console.WriteLine($"Total count of topics of professor {name} = {actionLog.Count}");
    }

    public override void ModifyStatistics(UniversityStatistics statistics)
    {
        statistics.professorsActionsCount += actionLog.Count;
    }
}