
namespace SchoolActivityTrackerApp.Helpers
{
    public class BaseClass
    {
        public class BaseClass
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public DateTime DateCreated { get; set; } = DateTime.UtcNow;
            public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
            public bool IsDeleted { get; set; }
        }
    }
}
