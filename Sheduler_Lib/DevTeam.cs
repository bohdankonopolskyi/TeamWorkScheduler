using System;
using System.Collections.Generic;
namespace Sheduler_Lib
{   
    [Serializable]
    public class DevTeam : IEmployable
    {
        [field: NonSerialized]
        internal event ExecutorStateHandler Added;
        [field: NonSerialized]
        internal event ExecutorStateHandler Removed;

        private readonly string _teamName;
        private  List<Employee> _employees;

        public List<Employee> Employees => _employees;

        public Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public DevTeam()
        {
           _employees = new List<Employee>();
        }

        public DevTeam(string name)
        {
            _employees = new List<Employee>();

            if (name != null)
            {
                _teamName = name;
            }
            else
                throw new ArgumentNullException("Empty name of Team was passed.");

        }

        public void AddMember(string name)
        {
            Employee employee = new Employee(name);

            if (employee != null)
            {
                _employees.Add(employee);
                Added?.Invoke(this, new ExecutorEventArgs("A new member has been added to the team.", employee));
            }
            else
                throw new NullReferenceException("An employee with this name does not exists.");
        }

        public void RemoveEmployee(uint id)
        {
            int index = GetEmployeeIndex(id);

            if (index > -1)
            {
                _employees.RemoveAt(index);
                Removed?.Invoke(this, new ExecutorEventArgs("Employee was removed."));
            }
            else
                throw new NonExistentEmployeeException("An employee with this name does not exists.");
        }

        public Employee GetEmployee(uint id)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].ID == id)
                    return _employees[i];
            }
            return null;
        }

        public  Employee GetEmployee(string name)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Name == name)
                    return _employees[i];
            }
            return null;
        }

        private int GetEmployeeIndex(uint id)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].ID == id)
                    return i;
            }
            return -1;
        }

        

        public override bool Equals(object obj)
        {
            return obj is DevTeam team &&
                   _teamName == team._teamName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_teamName);
        }

    }
}
