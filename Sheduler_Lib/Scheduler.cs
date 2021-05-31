using System;
using System.Collections.Generic;
using System.Timers;

namespace Sheduler_Lib
{   
    [Serializable]
    public class Scheduler<T> where T : Task
    {
        private static Timer timer;
        private DevTeam _team;
        T[] tasks;

        
        public DevTeam Team => _team;
        public T[] Tasks => tasks;

        public Scheduler()
        {
            _team = new DevTeam();
        }
        

        public void Create(string name, string descript, DateTime deadline, Priority priority, TaskStateHandler createHandler, ExecutorStateHandler takeToWorkHandler, TaskStateHandler changeStatushandler)
        {
            T newTask = null;

            switch (priority)
            {
                case Priority.Low:
                    newTask = new StandartTask(name, descript) as T;
                    break;

                case Priority.Medium:
                    newTask = new UrgentTask(name, descript, deadline, Priority.Medium) as T;
                    break;

                case Priority.High:
                    newTask = new UrgentTask(name, descript, deadline, Priority.High) as T;
                    break;

            }

            if (newTask == null)
                throw new NullReferenceException("Couldn't create a new task");

            if (tasks == null)
                tasks = new T[] { newTask };
            else
            {
                T[] temp = new T[tasks.Length + 1];
                for (int i = 0; i < tasks.Length; i++)
                    temp[i] = tasks[i];
                temp[temp.Length - 1] = newTask;
                tasks = temp;
            }

        
            newTask.Created += createHandler;
            newTask.TakenToWork += takeToWorkHandler;
            newTask.ChangedStatus += changeStatushandler;

            newTask.OnCreated();
        }

        public void Give(uint task_id, string e_name)
        {
            int index = GetTaskIndex(task_id);
            if (index > -1)
            {
                Employee executor = _team.GetEmployee(e_name);

                if (tasks[index] != null || executor != null)
                    tasks[index].OnTaken(executor);
                
            }
            else
                throw new NonExistentEmployeeException("An employee with this ID does not exists.");
        }

        public void EstimateTime()
        {
            timer = new Timer();
            timer.Interval = 6 * Math.Pow(10, 4);
            timer.AutoReset = true;
            timer.Elapsed += OnTimedOverdue;
            timer.Enabled = true;
        }

        
        public void OnTimedOverdue(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                if( tasks[i] is UrgentTask)
                {
                    UrgentTask urgentTask = tasks[i] as UrgentTask;
                    urgentTask.Overdue();

                    tasks[i] = urgentTask as T;
                }
            }
        }

        public void DeferTask(uint id, double days)
        {
            int index = GetTaskIndex(id);
            if (index > -1)
            {
                if (tasks[index] is UrgentTask)
                {
                    UrgentTask urgentTask = tasks[index] as UrgentTask;
                    urgentTask.Defer(days);

                    tasks[index] = urgentTask as T;
                }
            }
            else
                throw new NonExistentTaskException("An Task with this ID does not exists.");
        }
        public void Complete(uint id)
        {
            int index = GetTaskIndex(id);
            if (index > -1)
            {
                if (tasks[index] != null)
                    tasks[index].CompleteTask();

                else
                    throw new NullReferenceException("An empty task object was passed as ArgumentNullException argument");
            }
            else
                throw new NonExistentTaskException("An Task with this ID does not exists.");
        }


        public T GetTask(uint id)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Id == id)
                    return tasks[i];
            }

            return null;
        }

        private int GetTaskIndex(uint id)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Id == id)
                    return i;
            }

            return -1;
        }

        public T GetTask(string name)
        {
            int i = 0;

            while (i < tasks.Length)
                if (tasks[i].Name == name)
                {
                    return tasks[i];
                }
                    
            return null;
        }

        
    }
}
