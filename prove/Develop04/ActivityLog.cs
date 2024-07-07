using System;
using System.Collections.Generic;
using System.IO;

namespace MindfulnessApp
{
    public class ActivityLog
    {
        private string _logFilePath = "activityLog.txt"; // Path to the log file
        private Dictionary<string, int> _activityCounts = new Dictionary<string, int>(); // Dictionary to keep track of activity counts

        // Method to load the log from a file
        public void LoadLog()
        {
            if (File.Exists(_logFilePath))
            {
                string[] lines = File.ReadAllLines(_logFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string activityName = parts[0].Trim();
                        int count = int.Parse(parts[1].Trim());
                        _activityCounts[activityName] = count;
                    }
                }
            }
        }

        // Method to save the log to a file
        public void SaveLog()
        {
            using (StreamWriter writer = new StreamWriter(_logFilePath))
            {
                foreach (var entry in _activityCounts)
                {
                    writer.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
        }

        // Method to record an activity
        public void RecordActivity(string activityName)
        {
            if (_activityCounts.ContainsKey(activityName))
            {
                _activityCounts[activityName]++;
            }
            else
            {
                _activityCounts[activityName] = 1;
            }
        }

        // Method to get the count of an activity
        public int GetActivityCount(string activityName)
        {
            return _activityCounts.ContainsKey(activityName) ? _activityCounts[activityName] : 0;
        }
    }
}
