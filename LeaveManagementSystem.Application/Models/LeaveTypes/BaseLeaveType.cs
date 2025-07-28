namespace LeaveManagementSystem.Application.Models.LeaveTypes
{
    public abstract class BaseLeaveType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }

    }
}
