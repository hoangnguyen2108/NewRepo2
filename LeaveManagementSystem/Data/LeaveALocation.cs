﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Data
{
    public class LeaveALocation
    {
        [Key]
        public int LeaveALocationId { get; set; }
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        [ForeignKey("EmployeeId")]
        public ApplicationUser Employee { get; set; }
        public string EmployeeId { get; set; }

        public Period Period { get; set; }
        public int PeriodId { get; set; }
        public int Days { get; set; }
    }
}
