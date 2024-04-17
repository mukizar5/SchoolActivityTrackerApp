using SchoolActivityTrackerApp.Helpers;

var activities = Utils.CreateActivities();

Utils.DisplayIncompleteTasks(activities);

Utils.DisplayCompletedTasks(activities);
