using System;
using System.Runtime.Serialization;

namespace Sheduler_Lib
{   
    [Serializable]
    public class UrgentTask: Task
    {
        [field: NonSerialized]
        protected internal override event TaskStateHandler Created;
        [field: NonSerialized]
        protected internal override event TaskStateHandler ChangedStatus;

        private DateTime _deadline;     // date and time of task deadline

        public DateTime DeadLine => _deadline;

        public UrgentTask(string name, string comment, DateTime deadline, Priority priority) : base(name, comment)
        {
            if (deadline != null)
            {
                if (deadline.CompareTo(DateTime.Now) > 0)
                    _deadline = deadline;       // set date and time of task deadline;
                else
                    throw new InvalidDateTimeException("Invalid date of deadline input:" + deadline.ToShortDateString());

                if (priority != Priority.Low)
                    _priority = priority;       // set priority of task
            }
            else
                throw new ArgumentNullException("The empty reference of Deadline date was passed.");
        }

        public void Overdue()
        {
            if (_deadline.CompareTo(DateTime.Now) <= 0 && (_status == Status.InQueue || _status == Status.Processing))
            {
                _status = Status.Overdue;
                ChangedStatus?.Invoke(this, new TaskEventArgs("The task " + _name + " is Overdue, in a such date and time:", _deadline));
            }
        }

        public void Defer(double days)
        {
            if (days > 0 && days < 365)
            { 
                _deadline = _deadline.AddDays(days);
                ChangedStatus?.Invoke(this, new TaskEventArgs("The task " + _name + " is Extended, to: " + _deadline.ToShortDateString()));
            }   
            else
                throw new InvalidDateTimeException("An incorrect number of days were introduced.");
        }

        public override void CompleteTask()
        {
            if (_deadline.CompareTo(DateTime.Now) >= 0 && _status == Status.Processing)
            {
                _status = Status.Done;
                ChangedStatus?.Invoke(this, new TaskEventArgs("The task " + _name + " is done on the time.", DateTime.Now));
            }

        }

        public override void OnCreated()
        {
            Created?.Invoke(this, new TaskEventArgs("The " + _priority.ToString() + " priority task " + _name + " is queued.", _deadline));
        }
    }

    
}
