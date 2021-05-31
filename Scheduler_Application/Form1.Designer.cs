
namespace Scheduler_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NewTskButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TaskIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadlineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GiveTskButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CompleteTskButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label_TaskTitle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OccuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 791);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.NewTskButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 753);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Task";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(646, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 451);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(241, 28);
            this.label16.TabIndex = 9;
            this.label16.Text = "Set deadline with calendar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 28);
            this.label14.TabIndex = 8;
            this.label14.Text = "Priority";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 34);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(119, 72);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 32);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standart";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(119, 114);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 32);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(119, 153);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 32);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "High";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(401, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 45);
            this.label13.TabIndex = 10;
            this.label13.Text = "Create new task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 279);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 296);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 31);
            this.textBox1.TabIndex = 3;
            // 
            // NewTskButton
            // 
            this.NewTskButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTskButton.Location = new System.Drawing.Point(417, 638);
            this.NewTskButton.Name = "NewTskButton";
            this.NewTskButton.Size = new System.Drawing.Size(231, 72);
            this.NewTskButton.TabIndex = 0;
            this.NewTskButton.Text = "Add task";
            this.NewTskButton.UseVisualStyleBackColor = true;
            this.NewTskButton.Click += new System.EventHandler(this.NewTskButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.label_TaskTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 753);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scheduler";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(935, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save and exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(447, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 165);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(172, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deadline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(172, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Creation time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(321, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "label10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(494, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "label12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(321, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Priority";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(494, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(28, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 31);
            this.label15.TabIndex = 20;
            this.label15.Text = "label15";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(741, 365);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 31);
            this.textBox3.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskIDColumn,
            this.TaskNameColumn,
            this.ExecutorColumn,
            this.CreationColumn,
            this.DeadlineColumn,
            this.PriorityColumn,
            this.StatusColumn});
            this.dataGridView2.Location = new System.Drawing.Point(19, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1048, 271);
            this.dataGridView2.TabIndex = 18;
            // 
            // TaskIDColumn
            // 
            this.TaskIDColumn.HeaderText = "ID";
            this.TaskIDColumn.MinimumWidth = 6;
            this.TaskIDColumn.Name = "TaskIDColumn";
            this.TaskIDColumn.ReadOnly = true;
            this.TaskIDColumn.Width = 60;
            // 
            // TaskNameColumn
            // 
            this.TaskNameColumn.HeaderText = "Name";
            this.TaskNameColumn.MinimumWidth = 6;
            this.TaskNameColumn.Name = "TaskNameColumn";
            this.TaskNameColumn.ReadOnly = true;
            this.TaskNameColumn.Width = 250;
            // 
            // ExecutorColumn
            // 
            this.ExecutorColumn.HeaderText = "Executor";
            this.ExecutorColumn.MinimumWidth = 6;
            this.ExecutorColumn.Name = "ExecutorColumn";
            this.ExecutorColumn.ReadOnly = true;
            this.ExecutorColumn.Width = 160;
            // 
            // CreationColumn
            // 
            this.CreationColumn.HeaderText = "Creation Date";
            this.CreationColumn.MinimumWidth = 6;
            this.CreationColumn.Name = "CreationColumn";
            this.CreationColumn.ReadOnly = true;
            this.CreationColumn.Width = 140;
            // 
            // DeadlineColumn
            // 
            this.DeadlineColumn.HeaderText = "Deadline";
            this.DeadlineColumn.MinimumWidth = 6;
            this.DeadlineColumn.Name = "DeadlineColumn";
            this.DeadlineColumn.ReadOnly = true;
            this.DeadlineColumn.Width = 140;
            // 
            // PriorityColumn
            // 
            this.PriorityColumn.HeaderText = "Priority";
            this.PriorityColumn.MinimumWidth = 6;
            this.PriorityColumn.Name = "PriorityColumn";
            this.PriorityColumn.ReadOnly = true;
            this.PriorityColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(958, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Executor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.GiveTskButton);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.CompleteTskButton);
            this.panel1.Location = new System.Drawing.Point(447, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 150);
            this.panel1.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 25);
            this.label19.TabIndex = 14;
            this.label19.Text = "Executor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(284, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 25);
            this.label18.TabIndex = 13;
            this.label18.Text = "Days";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(239, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(163, 31);
            this.numericUpDown1.TabIndex = 12;
            // 
            // GiveTskButton
            // 
            this.GiveTskButton.Location = new System.Drawing.Point(38, 99);
            this.GiveTskButton.Name = "GiveTskButton";
            this.GiveTskButton.Size = new System.Drawing.Size(113, 39);
            this.GiveTskButton.TabIndex = 9;
            this.GiveTskButton.Text = "Give";
            this.GiveTskButton.UseVisualStyleBackColor = true;
            this.GiveTskButton.Click += new System.EventHandler(this.GiveTskButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(251, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 39);
            this.button6.TabIndex = 10;
            this.button6.Text = "Postpone";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // CompleteTskButton
            // 
            this.CompleteTskButton.Location = new System.Drawing.Point(482, 99);
            this.CompleteTskButton.Name = "CompleteTskButton";
            this.CompleteTskButton.Size = new System.Drawing.Size(123, 39);
            this.CompleteTskButton.TabIndex = 6;
            this.CompleteTskButton.Text = "Complete";
            this.CompleteTskButton.UseVisualStyleBackColor = true;
            this.CompleteTskButton.Click += new System.EventHandler(this.CompleteTskButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(22, 436);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(397, 153);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label_TaskTitle
            // 
            this.label_TaskTitle.AutoSize = true;
            this.label_TaskTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TaskTitle.Location = new System.Drawing.Point(472, 13);
            this.label_TaskTitle.Name = "label_TaskTitle";
            this.label_TaskTitle.Size = new System.Drawing.Size(160, 38);
            this.label_TaskTitle.TabIndex = 0;
            this.label_TaskTitle.Text = "List of tasks";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1089, 753);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Team";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(443, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 28);
            this.label17.TabIndex = 8;
            this.label17.Text = "Enter name ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.OccuColumn});
            this.dataGridView1.Location = new System.Drawing.Point(186, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(629, 188);
            this.dataGridView1.TabIndex = 7;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 250;
            // 
            // OccuColumn
            // 
            this.OccuColumn.HeaderText = "Occupation";
            this.OccuColumn.MinimumWidth = 6;
            this.OccuColumn.Name = "OccuColumn";
            this.OccuColumn.ReadOnly = true;
            this.OccuColumn.Width = 200;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 31);
            this.textBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(638, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 69);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove worker";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(171, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add worker";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Development team";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 791);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button NewTskButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CompleteTskButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label_TaskTitle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GiveTskButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OccuColumn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
    }
}

