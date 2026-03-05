namespace practice_5;

public class UniversityMember
{
    public string Name { get; }
    public string MemberId { get; }

    protected List<string> actionLog = new List<string>();

    protected UniversityMember(string name, string memberId)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be empty!");
        }

        if (string.IsNullOrEmpty(memberId))
        {
            throw new ArgumentException("MemberId cannot be empty!");
        }

        Name = name;
        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        if (actionLog.Count > 5)
        {
            throw new Exception("Member has reached a daily limit of 5 actions!");
        }
    }
    
    
}