using System;
namespace Sheduler_Lib
{
    // enumeration of task statuses
    public enum Status
    {
        InQueue,
        Processing,
        Done,
        Overdue
    };

    // enumeration of task priorities
    public enum Priority
    {
        Low,
        Medium,
        High
    };

    public enum Employee_Load
    {
        Free,
        Occupied
    };
}
