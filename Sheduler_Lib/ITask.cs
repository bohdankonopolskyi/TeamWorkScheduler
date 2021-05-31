using System;
namespace Sheduler_Lib
{
    public interface ITask
    {
        void OnCreated();
        void CompleteTask();
        void OnTaken(Employee employee);
    }
}
