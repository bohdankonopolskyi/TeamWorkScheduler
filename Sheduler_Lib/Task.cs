using System;
using System.Diagnostics;

namespace Sheduler_Lib
{
    [Serializable]
    public abstract class Task : ITask
    {   
        [field: NonSerialized]
        protected internal virtual event TaskStateHandler Created;
        [field: NonSerialized]
        protected internal virtual event ExecutorStateHandler TakenToWork;
        [field: NonSerialized]
        protected internal virtual event TaskStateHandler ChangedStatus;
     
        protected  uint _id;   // identifier of task
        static uint counter = 0;

        protected string _name;   // task name
        protected string _comment;     // short description of task
        protected DateTime _creationTime;     // date and time of task creation
        
        protected Priority _priority;     // priority of executing

        protected Employee _executor;     // employee - executor of task
        protected Status _status;     // status of executing


        public Task(string name, string comment) 
        {
            //setting ididntifier of task object
            _id = counter++;

            // is name of task and description isn`t have null reference
            if (name != "")
            {
                _name = name;       // initialize task naming
                _comment = comment; // initialize task description
            }
            else
                throw new ArgumentNullException(" Empty task name or description input");

           _creationTime = DateTime.Now;   // set start of task as current time, when creates object
            _executor = null;       // when task creates executer isn`t defined for it
            _status = Status.InQueue;   // when task creates default status is in queue
        }

        // class properties
        public uint Id => _id;
        public string Name => _name;
        public string Description => _comment;
        public DateTime CreationDate => _creationTime;
        public Priority GetPriority => _priority;
        public Employee Executor => _executor;
        public Status GetStatus => _status;

        public abstract void OnCreated();
        public abstract void CompleteTask();



        public void OnTaken(Employee employee)
        {
            if (employee != null)
            {
                if (_executor == null)
                {
                    if (employee.Occupation == Employee_Load.Free)
                    {
                        _executor = employee;
                        _status = Status.Processing;
                        TakenToWork?.Invoke(this, new ExecutorEventArgs("Taken for execution by the employee: ", _executor));
                    }
                }
                else
                {
                    if (employee.Occupation == Employee_Load.Free)
                    {
                        _executor = employee;
                        TakenToWork?.Invoke(this, new ExecutorEventArgs("Current performer was replaced by: ", _executor));
                    }
                }
                
            }
            else
            {
                throw new NullReferenceException("The empty reference of Executor was passed.");
            }
        }

    }
}
