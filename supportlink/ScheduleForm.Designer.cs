
namespace supportlink
{
    partial class ScheduleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox taskGroupBox; // Add missing field declaration
        private System.Windows.Forms.RadioButton radioShutdown;
        private System.Windows.Forms.RadioButton radioRestart;
        private System.Windows.Forms.RadioButton radioLogoff;
        private System.Windows.Forms.RadioButton radioSleep;
        private System.Windows.Forms.RadioButton radioLock;
        private System.Windows.Forms.RadioButton radioCloseApps;

        private System.Windows.Forms.GroupBox scheduleGroupBox; // Add missing field declaration
        private System.Windows.Forms.RadioButton radioNow;
        private System.Windows.Forms.RadioButton radioAfter;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.RadioButton radioRepeat;
        private System.Windows.Forms.ComboBox comboRepeat;
        private System.Windows.Forms.DateTimePicker timePicker;

        private System.Windows.Forms.Label labelStatus; // Add missing field declaration
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnCancelTask;

        private System.Windows.Forms.Timer taskTimer; // Add missing field declaration

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            taskGroupBox = new GroupBox();
            radioShutdown = new RadioButton();
            radioRestart = new RadioButton();
            radioLogoff = new RadioButton();
            radioSleep = new RadioButton();
            radioLock = new RadioButton();
            radioCloseApps = new RadioButton();
            scheduleGroupBox = new GroupBox();
            radioNow = new RadioButton();
            radioAfter = new RadioButton();
            radioRepeat = new RadioButton();
            numHour = new NumericUpDown();
            numMinute = new NumericUpDown();
            labelHour = new Label();
            labelMinute = new Label();
            comboRepeat = new ComboBox();
            timePicker = new DateTimePicker();
            labelStatus = new Label();
            btnStartTask = new Button();
            btnCancelTask = new Button();
            taskTimer = new System.Windows.Forms.Timer(components);
            taskGroupBox.SuspendLayout();
            scheduleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).BeginInit();
            SuspendLayout();
            // 
            // taskGroupBox
            // 
            taskGroupBox.Controls.Add(radioShutdown);
            taskGroupBox.Controls.Add(radioRestart);
            taskGroupBox.Controls.Add(radioLogoff);
            taskGroupBox.Controls.Add(radioSleep);
            taskGroupBox.Controls.Add(radioLock);
            taskGroupBox.Controls.Add(radioCloseApps);
            taskGroupBox.Location = new Point(20, 20);
            taskGroupBox.Name = "taskGroupBox";
            taskGroupBox.Size = new Size(300, 150);
            taskGroupBox.TabIndex = 0;
            taskGroupBox.TabStop = false;
            taskGroupBox.Text = "Select Task";
            // 
            // radioShutdown
            // 
            radioShutdown.Location = new Point(0, 0);
            radioShutdown.Name = "radioShutdown";
            radioShutdown.Size = new Size(104, 24);
            radioShutdown.TabIndex = 0;
            radioShutdown.Text = "Shutdown";
            // 
            // radioRestart
            // 
            radioRestart.Location = new Point(0, 0);
            radioRestart.Name = "radioRestart";
            radioRestart.Size = new Size(104, 24);
            radioRestart.TabIndex = 1;
            radioRestart.Text = "Restart";
            // 
            // radioLogoff
            // 
            radioLogoff.Location = new Point(0, 0);
            radioLogoff.Name = "radioLogoff";
            radioLogoff.Size = new Size(104, 24);
            radioLogoff.TabIndex = 2;
            radioLogoff.Text = "Log off";
            // 
            // radioSleep
            // 
            radioSleep.Location = new Point(0, 0);
            radioSleep.Name = "radioSleep";
            radioSleep.Size = new Size(104, 24);
            radioSleep.TabIndex = 3;
            radioSleep.Text = "Sleep";
            // 
            // radioLock
            // 
            radioLock.Location = new Point(0, 0);
            radioLock.Name = "radioLock";
            radioLock.Size = new Size(104, 24);
            radioLock.TabIndex = 4;
            radioLock.Text = "Lock screen";
            // 
            // radioCloseApps
            // 
            radioCloseApps.Location = new Point(0, 0);
            radioCloseApps.Name = "radioCloseApps";
            radioCloseApps.Size = new Size(104, 24);
            radioCloseApps.TabIndex = 5;
            radioCloseApps.Text = "Close applications";
            // 
            // scheduleGroupBox
            // 
            scheduleGroupBox.Controls.Add(radioNow);
            scheduleGroupBox.Controls.Add(radioAfter);
            scheduleGroupBox.Controls.Add(radioRepeat);
            scheduleGroupBox.Controls.Add(numHour);
            scheduleGroupBox.Controls.Add(numMinute);
            scheduleGroupBox.Controls.Add(labelHour);
            scheduleGroupBox.Controls.Add(labelMinute);
            scheduleGroupBox.Controls.Add(comboRepeat);
            scheduleGroupBox.Controls.Add(timePicker);
            scheduleGroupBox.Location = new Point(350, 20);
            scheduleGroupBox.Name = "scheduleGroupBox";
            scheduleGroupBox.Size = new Size(491, 150);
            scheduleGroupBox.TabIndex = 1;
            scheduleGroupBox.TabStop = false;
            scheduleGroupBox.Text = "Schedule Time";
            // 
            // radioNow
            // 
            radioNow.Location = new Point(10, 20);
            radioNow.Name = "radioNow";
            radioNow.Size = new Size(104, 24);
            radioNow.TabIndex = 0;
            radioNow.Text = "Now";
            // 
            // radioAfter
            // 
            radioAfter.Location = new Point(10, 45);
            radioAfter.Name = "radioAfter";
            radioAfter.Size = new Size(104, 24);
            radioAfter.TabIndex = 1;
            radioAfter.Text = "From now";
            // 
            // radioRepeat
            // 
            radioRepeat.Location = new Point(10, 75);
            radioRepeat.Name = "radioRepeat";
            radioRepeat.Size = new Size(104, 24);
            radioRepeat.TabIndex = 2;
            radioRepeat.Text = "Repeat";
            // 
            // numHour
            // 
            numHour.Location = new Point(194, 45);
            numHour.Name = "numHour";
            numHour.Size = new Size(64, 27);
            numHour.TabIndex = 3;
            // 
            // numMinute
            // 
            numMinute.Location = new Point(343, 45);
            numMinute.Name = "numMinute";
            numMinute.Size = new Size(54, 27);
            numMinute.TabIndex = 4;
            // 
            // labelHour
            // 
            labelHour.Location = new Point(130, 49);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(58, 23);
            labelHour.TabIndex = 5;
            labelHour.Text = "Hour(s)";
            // 
            // labelMinute
            // 
            labelMinute.Location = new Point(264, 47);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(73, 23);
            labelMinute.TabIndex = 6;
            labelMinute.Text = "Minute(s)";
            // 
            // comboRepeat
            // 
            comboRepeat.Location = new Point(130, 75);
            comboRepeat.Name = "comboRepeat";
            comboRepeat.Size = new Size(100, 28);
            comboRepeat.TabIndex = 7;
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(250, 75);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(200, 27);
            timePicker.TabIndex = 8;
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatus.Location = new Point(20, 190);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(600, 23);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Waiting for task selection...";
            // 
            // btnStartTask
            // 
            btnStartTask.Location = new Point(20, 230);
            btnStartTask.Name = "btnStartTask";
            btnStartTask.Size = new Size(75, 37);
            btnStartTask.TabIndex = 3;
            btnStartTask.Text = "Start Task";
            btnStartTask.Click += BtnStartTask_Click;
            // 
            // btnCancelTask
            // 
            btnCancelTask.Location = new Point(130, 230);
            btnCancelTask.Name = "btnCancelTask";
            btnCancelTask.Size = new Size(75, 37);
            btnCancelTask.TabIndex = 4;
            btnCancelTask.Text = "Cancel Task";
            btnCancelTask.Click += BtnCancelTask_Click;
            // 
            // ScheduleForm
            // 
            ClientSize = new Size(915, 300);
            Controls.Add(taskGroupBox);
            Controls.Add(scheduleGroupBox);
            Controls.Add(labelStatus);
            Controls.Add(btnStartTask);
            Controls.Add(btnCancelTask);
            Name = "ScheduleForm";
            Text = "Schedule Windows Task";
            taskGroupBox.ResumeLayout(false);
            scheduleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).EndInit();
            ResumeLayout(false);

        }

        #endregion
    }
}