using System;
namespace Sheduler_Lib
{
    public delegate void TaskStateHandler(object sender, TaskEventArgs e);


    public class TaskEventArgs
    {

        public string Message { get; }
        public DateTime TaskDateTime { get; }
        public Employee Executor { get; }

        public TaskEventArgs(string message) => Message = message;

        public TaskEventArgs(string message, DateTime dateTime)
        {
            Message = message;
            TaskDateTime = dateTime;

        }

        public TaskEventArgs(string message, Employee employee)
        {
            Message = message;
            Executor = employee;
        }
    }
}
