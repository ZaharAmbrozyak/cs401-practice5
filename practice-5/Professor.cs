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
}