namespace Attendance.Entity
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<DateTime> Traffic { get; set; }
        public Employee Employee { get; set; }
        // get in getout field must be ['getIn' , 'getOut']
        public string GetInGetOut { get ; set; }
        // ActivityType field must be ['normal' , 'HourlyLeave' , 'DailyLeave' , 'Delay' , 'Error']
        public string ActivityType { get ; set; }

    }
}
