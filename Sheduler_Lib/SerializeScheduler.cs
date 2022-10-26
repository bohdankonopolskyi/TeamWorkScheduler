using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;

namespace Sheduler_Lib
{
    public class SerializeScheduler
    {
        public SerializeScheduler()
        {

        }

       
        public void ToFile(Scheduler<Task> scheduler)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Scheduler.dat", FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, scheduler);
            }
        }

        public Scheduler<Task> FromFile()
        {
            Scheduler<Task>  scheduler = new Scheduler<Task>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Scheduler.dat", FileMode.OpenOrCreate))
            {
                scheduler = (Scheduler<Task>)formatter.Deserialize(fs);
            }
            return scheduler;
        }
    }
}
