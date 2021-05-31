using System;

namespace Sheduler_Lib
{   
    [Serializable]
    public class Employee
    {
        
        private readonly string _name;  // name of employee
        private uint _id;
        private static uint counter = 0;
        private Employee_Load _occupation;      // is the task busy 

        //constructor of employee object
        public Employee(string name)
        {
            _name = name;
            _id = counter++;
            _occupation = Employee_Load.Free;       // default is free from tasks

        }

        public uint ID => _id;
        public string Name => _name;
        public Employee_Load Occupation
        {
            get
            {
                return _occupation;
            }

            set
            {
                _occupation = value;
            }
        }
       
    }

    
}
