using System;
using System.Collections.Generic;
using System.IO;

public class EternalQuestProgram
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        _goals[index].RecordEvent();
        _totalScore += _goals[index]._value;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name} - { _goals[i].Progress()}");
        }
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal._name},{goal._value},{goal._isCompleted}");
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        _goals.Clear();
        _totalScore = 0;
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string typeName = parts[0];
                string name = parts[1];
                int value = int.Parse(parts[2]);
                bool isCompleted = bool.Parse(parts[3]);

                Goal goal;
                switch (typeName)
                {
                    case nameof(SimpleGoal):
                        goal = new SimpleGoal();
                        break;
                    case nameof(EternalGoal):
                        goal = new EternalGoal();
                        break;
                    case nameof(ChecklistGoal):
                        goal = new ChecklistGoal(0); // Target times will be set separately
                        break;
                    default:
                        throw new NotSupportedException($"Goal type {typeName} is not supported.");
                }

                goal._name = name;
                goal._value = value;
                goal._isCompleted = isCompleted;
                _goals.Add(goal);
                _totalScore += value;
            }
        }
    }
}