namespace practice_5;

public abstract class UniversityMember
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            _name = value;
        }
    }

    private string _memberId;

    public string MemberId
    {
        get => _memberId;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("MemberId cannot be empty!");
            }

            _memberId = value;
        }

    }

    protected List<string> ActionLog = [];

    protected UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count > 5)
        {
            throw new InvalidOperationException("Member has reached a daily limit of 5 actions!");
        }
    }

    public abstract string ShowStatistics();

    public abstract void ModifyStatistics(UniversityStatistics statistics);
}