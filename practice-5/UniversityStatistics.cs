namespace practice_5;

public class UniversityStatistics
{
    public int ProfessorsActionsCount { get; set; } = 0;
    public int UndergraduateActionsCount { get; set; } = 0;
    public int GraduateActionsCount { get; set; } = 0;
    public int TotalUniversityActions => ProfessorsActionsCount + GraduateActionsCount + UndergraduateActionsCount;
    public string GetSummary()
    {
        var professorsStatistics = $"Total count of professors actions = {ProfessorsActionsCount} \n";
        var undergraduatesStatistics = $"Total count of undergraduate students actions = {UndergraduateActionsCount} \n";
        var graduatesStatistics = $"Total count of graduate students actions = {GraduateActionsCount} \n";
        var universityStatistics = $"Total count of university actions = {TotalUniversityActions} ";
        
        return professorsStatistics + undergraduatesStatistics + graduatesStatistics + universityStatistics;
    }
}