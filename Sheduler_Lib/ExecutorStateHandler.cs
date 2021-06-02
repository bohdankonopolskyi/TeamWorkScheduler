using System;
namespace Sheduler_Lib
{
    [field: NonSerialized]
    public delegate void ExecutorStateHandler(object sender, ExecutorEventArgs e);
    
    
    public class ExecutorEventArgs
    {
        public string Message { get; }
        public Employee Executor { get; }
        public DevTeam devTeam { get; }

        public ExecutorEventArgs(string message)
        {
            Message = message;
        }
        public ExecutorEventArgs(string message, Employee employee)
        {
            Message = message;
            Executor = employee;
        }

        public ExecutorEventArgs(string message, DevTeam team)
        {
            Message = message;
            devTeam = team;
        }
    }
}
