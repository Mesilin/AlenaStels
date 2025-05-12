
namespace AlenaStels.Data
{
    public class WorkLog
    {
        public int WorkLogId {get; set; }
        public int Year {get; set; }
        public int Month {get; set; }
        public int Day {get; set; }
        public int EmployeeId {get; set; }
        public virtual Employee Employee { get; set; } = null!;
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; } = null!;
        public int? Value { get; set; }
    }
}
