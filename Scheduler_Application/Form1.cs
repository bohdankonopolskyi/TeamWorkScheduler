using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Sheduler_Lib;
using Task = Sheduler_Lib.Task;

namespace Scheduler_Application
{
    public partial class Form1 : Form
    {
        Scheduler<Task> scheduler;
        SerializeScheduler serializator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scheduler = new Scheduler<Task>();
            serializator = new SerializeScheduler();
            
            FillActiveTaskList();
            scheduler.EstimateTime();
            FillEmployeeList();
            SetTab1();
            SetTab2();
            SetTab3();
            try
            {
                scheduler = serializator.FromFile();
            }
            catch(System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("File doesn`t exists or is empty. Fill in the data and restart the program.", "Data download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // event Click on button Create New Task
        private void NewTskButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewTask(scheduler);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidDateTimeException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Invalid date of deadline", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Empty value was input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetTab1();
            
        }

        
        private void NewTask(Scheduler<Task> scheduler)
        {
            string name = textBox1.Text;
            string description = richTextBox1.Text;
            DateTime deadline = dateTimePicker1.Value.Date;
            
            Priority priority = Priority.Low;

            if (radioButton1.Checked)
                priority = Priority.Low;

            if (radioButton2.Checked)
                priority = Priority.Medium;

            if (radioButton3.Checked)
                priority = Priority.High;

            scheduler.Create(name, description, deadline, priority, CreateTaskHandler, TakeToWorkHandler, ChangeStatusHandler);
        }
        // method that notifies about creating new task
        private static void CreateTaskHandler(object sender, TaskEventArgs e)
        {
            MessageBox.Show(e.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // event Click on button Give Task
        private void GiveTskButton_Click(object sender, EventArgs e)
        {
            try
            {
                uint task_id = Convert.ToUInt32(dataGridView2.CurrentCell.Value);
                string executor = Convert.ToString(comboBox2.SelectedItem);
                scheduler.Give(task_id, executor);
                MessageBox.Show("Taken for execution by the employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NonExistentEmployeeException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Doesn`t exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "The wrong cell was selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // mathod that notifies that task taken to work
        private static void TakeToWorkHandler(object sender, ExecutorEventArgs e)
        {
            MessageBox.Show(e.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void CompleteTskButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                uint id = Convert.ToUInt32(dataGridView2.CurrentCell.Value);
                scheduler.Complete(id);
                MessageBox.Show("Task is completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NonExistentTaskException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "The wrong cell was selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void ChangeStatusHandler(object sender, TaskEventArgs e)
        {
            MessageBox.Show(e.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                uint id = Convert.ToUInt32(dataGridView2.CurrentCell.Value);
                int days = Convert.ToInt32(numericUpDown1.Value);
                scheduler.DeferTask(id, days);
            }
            catch(NonExistentTaskException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(InvalidDateTimeException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "The wrong cell was selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            uint id;
            Task task;

            try
            {
                SetTab2();
                if (textBox3.Text != "")
                {
                    name = textBox3.Text;
                    task = scheduler.GetTask(name);
                }
                else
                {
                    id = Convert.ToUInt32(dataGridView2.CurrentCell.Value);
                    task = scheduler.GetTask(id);
                }

                label_TaskTitle.Text = task.Name;
                richTextBox2.Text = task.Description;
                if (task.Executor != null)
                    comboBox2.Text = task.Executor.Name;
                else
                    comboBox2.Text = "Executor is not set.";
                label8.Text = task.CreationDate.ToShortDateString();
                label10.Text = task.GetPriority.ToString();
                label12.Text = task.GetStatus.ToString();


                if (task is UrgentTask)
                {
                    UrgentTask urgentTask = task as UrgentTask;
                    label4.Visible = true;
                    label5.Visible = true;
                    label5.Text = urgentTask.DeadLine.ToShortDateString();
                }
                else
                {
                    label4.Visible = false;
                    label5.Visible = false;
                    label5.Text = " ";
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "The wrong cell was selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillActiveTaskList()
        {
            string id, name, executor, creation, deadline, priority, status;

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            try {
                if (scheduler.Tasks != null)
                {
                    for (int i = 0; i < scheduler.Tasks.Length; i++)
                    {
                        if (scheduler.Tasks[i] is UrgentTask)
                        {
                            UrgentTask urgentTask = scheduler.Tasks[i] as UrgentTask;
                            id = urgentTask.Id.ToString();
                            name = urgentTask.Name;
                            if (urgentTask.Executor != null)
                                executor = urgentTask.Executor.Name;
                            else
                                executor = "Is not set";
                            creation = urgentTask.CreationDate.Date.ToShortDateString();
                            deadline = urgentTask.DeadLine.Date.ToShortDateString();
                            priority = urgentTask.GetPriority.ToString();
                            status = urgentTask.GetStatus.ToString();

                            dataGridView2.Rows.Add(id, name, executor, creation, deadline, priority, status);
                        }

                        if (scheduler.Tasks[i] is StandartTask)
                        {
                            StandartTask standartTask = scheduler.Tasks[i] as StandartTask;
                            id = standartTask.Id.ToString();
                            name = standartTask.Name;
                            if (standartTask.Executor != null)
                                executor = standartTask.Executor.Name;
                            else
                                executor = "Is not set";
                            creation = standartTask.CreationDate.Date.ToShortDateString();
                            deadline = "N/A";
                            priority = standartTask.GetPriority.ToString();
                            status = standartTask.GetStatus.ToString();

                            dataGridView2.Rows.Add(id, name, executor, creation, deadline, priority, status);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Couldn`t load the task description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            // combobox
            //datagrid view of dev team
        }

        private void FillDisabledTaskList()
        {
            string id, name, executor, creation, deadline, priority, status;

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            try
            {
                if (scheduler.DisabledTasks != null)
                {
                    for (int i = 0; i < scheduler.DisabledTasks.Count; i++)
                    {
                        if (scheduler.DisabledTasks[i] is UrgentTask)
                        {
                            UrgentTask urgentTask = scheduler.DisabledTasks[i] as UrgentTask;
                            id = urgentTask.Id.ToString();
                            name = urgentTask.Name;
                            if (urgentTask.Executor != null)
                                executor = urgentTask.Executor.Name;
                            else
                                executor = "Is not set";
                            creation = urgentTask.CreationDate.Date.ToShortDateString();
                            deadline = urgentTask.DeadLine.Date.ToShortDateString();
                            priority = urgentTask.GetPriority.ToString();
                            status = urgentTask.GetStatus.ToString();

                            dataGridView2.Rows.Add(id, name, executor, creation, deadline, priority, status);
                        }

                        if (scheduler.DisabledTasks[i] is StandartTask)
                        {
                            StandartTask standartTask = scheduler.DisabledTasks[i] as StandartTask;
                            id = standartTask.Id.ToString();
                            name = standartTask.Name;
                            if (standartTask.Executor != null)
                                executor = standartTask.Executor.Name;
                            else
                                executor = "Is not set";
                            creation = standartTask.CreationDate.Date.ToShortDateString();
                            deadline = "N/A";
                            priority = standartTask.GetPriority.ToString();
                            status = standartTask.GetStatus.ToString();

                            dataGridView2.Rows.Add(id, name, executor, creation, deadline, priority, status);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Couldn`t load the task description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;
                scheduler.Team.AddMember(name);
                textBox2.Text = "";
                FillEmployeeList();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // remove employee
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                uint id = Convert.ToUInt16(dataGridView1.CurrentCell.Value);
                DialogResult dialogResult = MessageBox.Show("Do you want to remove Employee?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    scheduler.Team.RemoveEmployee(id);
                }
                
            }
            catch(NonExistentEmployeeException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Doesn`t exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "The wrong cell was selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillEmployeeList();
        }


        private void FillEmployeeList()
        {
            uint id;
            string name, occupation;
            List<string> executors = new List<string>();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            for (int i = 0; i < scheduler.Team.Employees.Count; i++)
            {
                executors.Add(scheduler.Team.Employees[i].Name);

                id = scheduler.Team.Employees[i].ID;
                name = scheduler.Team.Employees[i].Name;
                occupation = scheduler.Team.Employees[i].Occupation.ToString();
                //datagrid view of dev team
                dataGridView1.Rows.Add(id, name, occupation);
            }

            // fill  combobox with executors
            comboBox2.DataSource = executors;
           
        }

        

        private void SetTab1()
        {
            textBox1.Clear();
            richTextBox1.Clear();
            radioButton1.Checked = true;
        }

        private void SetTab2()
        {
            label15.Text = "Task";
            label8.Text=" ";
            label5.Text = " ";
            label10.Text = " ";
            label12.Text = " ";

        }
        void SetTab3()
        {
            FillEmployeeList();
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            SetTab1();
            
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            FillEmployeeList();
            FillActiveTaskList();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            SetTab3();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true)
                FillActiveTaskList();
            if (radioButton5.Checked == true)
                FillDisabledTaskList();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            serializator.ToFile(scheduler);
            DialogResult dialogResult =  MessageBox.Show("The data was saved successefully. Do you want to Exit?" , "Save all and exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
