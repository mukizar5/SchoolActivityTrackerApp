

namespace SchoolActivityTrackerApp.Helpers
{
    public static class Utils
    {
        public static List<Activity> CreateActivities()
        {
            List<Activity> activities = new()
            {
            new Activity { Name = "Math Class", Description = "Learn algebra concepts", IsCompleted = false },
            new Activity { Name = "Science Lab", Description = "Experiment with chemical reactions", IsCompleted = false },
            new Activity { Name = "History Lecture", Description = "Study ancient civilizations", IsCompleted = false },
            new Activity { Name = "Art Workshop", Description = "Create a masterpiece using different techniques", IsCompleted = false },
            new Activity { Name = "Physical Education", Description = "Participate in team sports", IsCompleted = true },
            new Activity { Name = "Music Ensemble", Description = "Practice playing musical instruments", IsCompleted = false },
            new Activity { Name = "Coding Club", Description = "Develop coding skills through projects", IsCompleted = true },
            new Activity { Name = "Literature Discussion", Description = "Analyze classic novels and poems", IsCompleted = false },
            new Activity { Name = "Debate Team", Description = "Engage in structured arguments on various topics", IsCompleted = true },
            new Activity { Name = "Community Service", Description = "Contribute to the local community through volunteering", IsCompleted = false }

            };
            return activities;
        }
        
        public static void DisplayIncompleteTasks(List<Activity> activities)
        {       
            foreach (var activity in activities)
            {
                if (!activity.IsCompleted)
                {
                    Console.WriteLine($"Task: {activity.Name} - Description: {activity.Description}");
                }
            }
        }

        public static void DisplayCompletedTasks(List<Activity> activities)
        {       
            foreach (var activity in activities)
            {
                if (activity.IsCompleted)
                {
                    Console.WriteLine($"Task: {activity.Name} - Description: {activity.Description}");
                }
            }
        }

    }

    


}

