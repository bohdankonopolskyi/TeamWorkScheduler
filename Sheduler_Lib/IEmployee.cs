using System;
namespace Sheduler_Lib
{
    public interface IEmployable
    {
        void AddMember(string name);
        Employee GetEmployee(uint id);
        Employee GetEmployee(string name);
        void RemoveEmployee(uint id);
    }
}
