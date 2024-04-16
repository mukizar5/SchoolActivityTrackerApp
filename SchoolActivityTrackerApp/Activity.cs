

using SchoolActivityTrackerApp.Helpers;

namespace SchoolActivityTrackerApp
{
    public class Activity:BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
