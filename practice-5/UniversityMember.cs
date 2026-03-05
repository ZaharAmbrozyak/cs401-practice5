namespace practice_5;

public abstract class UniversityMember
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            name = value;
        }
    }

    private string memberId;

    public string MemberId
    {
        get => memberId;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("MemberId cannot be empty!");
            }

            memberId = value;
        }

    }

    protected List<string> actionLog = [];

    protected UniversityMember(string name, string memberId)
    {
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

    public abstract string ShowStatistics();

    public abstract void ModifyStatistics(UniversityStatistics statistics);
}