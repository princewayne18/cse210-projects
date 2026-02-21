public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        int pointsEarned = 0;

        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            pointsEarned += GetPoints();
            Console.WriteLine($"Progress: {_amountCompleted}/{_target} - Earned {GetPoints()} points.");

            if (_amountCompleted == _target)
            {
                pointsEarned += _bonus;
                Console.WriteLine($"Checklist goal completed! Bonus {_bonus} points awarded.");
            }
        }
        else
        {
            Console.WriteLine("Checklist goal already completed.");
        }

        return pointsEarned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} - {GetDescription()} ({GetPoints()} pts) Completed {_amountCompleted}/{_target} times";
    }
}