namespace practice_5;

public abstract class UniversityMember
{

    public string Name
    {
        get => field;
        private init
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            field = value;
        }
    }

    public string MemberId
    {
        get => field;
        private init
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("MemberId cannot be empty!");
            }

            field = value;
        }

    }

    protected readonly List<string> ActionLog = [];

    protected UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count > 5)
        {
            throw new InvalidOperationException($"Member {Name} has reached a daily limit of 5 actions!");
        }
    }

    public abstract string ShowStatistics();

    public abstract void ModifyStatistics(UniversityStatistics statistics);
}