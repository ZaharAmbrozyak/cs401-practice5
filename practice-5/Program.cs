namespace practice_5;

internal static class Program
{
    private static void Main()
    {
        var registry = new UniversityRegistry();

        var professor1 = new Professor("Chopyuk", "1");
        var gradStudent1 = new GraduateStudent("Zakhar", "2");
        var undergradStudent1 = new UndergraduateStudent("Ivan", "3");
        var undergradStudent2 = new UndergraduateStudent("Nazar", "4");
        
        registry.AddMember(professor1);
        registry.AddMember(gradStudent1);
        registry.AddMember(undergradStudent1);
        registry.AddMember(undergradStudent2);
        
        registry.ExecuteAllDuties();
        registry.ExecuteAllDuties();
        
        undergradStudent1.PerformDuties();
        professor1.ConductResearch("Smart math topic");
        
        registry.GetMemberStatistics();
    }
}