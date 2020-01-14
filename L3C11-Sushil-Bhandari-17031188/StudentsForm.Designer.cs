namespace L3C11_Sushil_Bhandari_17031188
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.stuWeekReport = new System.Windows.Forms.DataGridView();
            this.LblRegister = new System.Windows.Forms.Label();
            this.LblDob = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblProgramme = new System.Windows.Forms.Label();
            this.CBgender = new System.Windows.Forms.ComboBox();
            this.CBprogramme = new System.Windows.Forms.ComboBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblContact = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblLast = new System.Windows.Forms.Label();
            this.LblFirst = new System.Windows.Forms.Label();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DPdob = new System.Windows.Forms.DateTimePicker();
            this.DPregister = new System.Windows.Forms.DateTimePicker();
            this.dataGridstudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SortPick = new System.Windows.Forms.ComboBox();
            this.weeklyReport = new System.Windows.Forms.DateTimePicker();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stuWeekReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(816, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Student Programme Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Students Data Table";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(559, 322);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 50;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(232, 322);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 49;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(54, 322);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 48;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // stuWeekReport
            // 
            this.stuWeekReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuWeekReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programme,
            this.count});
            this.stuWeekReport.Location = new System.Drawing.Point(864, 390);
            this.stuWeekReport.Name = "stuWeekReport";
            this.stuWeekReport.Size = new System.Drawing.Size(329, 285);
            this.stuWeekReport.TabIndex = 53;
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Location = new System.Drawing.Point(335, 225);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(92, 13);
            this.LblRegister.TabIndex = 46;
            this.LblRegister.Text = "Registration Date:";
            // 
            // LblDob
            // 
            this.LblDob.AutoSize = true;
            this.LblDob.Location = new System.Drawing.Point(344, 172);
            this.LblDob.Name = "LblDob";
            this.LblDob.Size = new System.Drawing.Size(71, 13);
            this.LblDob.TabIndex = 45;
            this.LblDob.Text = "Date Of Birth:";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(356, 119);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(45, 13);
            this.LblGender.TabIndex = 44;
            this.LblGender.Text = "Gender:";
            // 
            // LblProgramme
            // 
            this.LblProgramme.AutoSize = true;
            this.LblProgramme.Location = new System.Drawing.Point(51, 275);
            this.LblProgramme.Name = "LblProgramme";
            this.LblProgramme.Size = new System.Drawing.Size(63, 13);
            this.LblProgramme.TabIndex = 43;
            this.LblProgramme.Text = "Programme:";
            // 
            // CBgender
            // 
            this.CBgender.FormattingEnabled = true;
            this.CBgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CBgender.Location = new System.Drawing.Point(434, 116);
            this.CBgender.Name = "CBgender";
            this.CBgender.Size = new System.Drawing.Size(200, 21);
            this.CBgender.TabIndex = 40;
            this.CBgender.Text = "Male";
            // 
            // CBprogramme
            // 
            this.CBprogramme.FormattingEnabled = true;
            this.CBprogramme.Items.AddRange(new object[] {
            "Computing",
            "Multimedia Technologies",
            "Networking and IT Security"});
            this.CBprogramme.Location = new System.Drawing.Point(125, 272);
            this.CBprogramme.Name = "CBprogramme";
            this.CBprogramme.Size = new System.Drawing.Size(182, 21);
            this.CBprogramme.TabIndex = 39;
            this.CBprogramme.Text = "Computing";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(353, 69);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(48, 13);
            this.LblAddress.TabIndex = 38;
            this.LblAddress.Text = "Address:";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.Location = new System.Drawing.Point(51, 225);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(64, 13);
            this.LblContact.TabIndex = 37;
            this.LblContact.Text = "Contact No:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(51, 188);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 36;
            this.LblEmail.Text = "Email:";
            // 
            // LblLast
            // 
            this.LblLast.AutoSize = true;
            this.LblLast.Location = new System.Drawing.Point(50, 149);
            this.LblLast.Name = "LblLast";
            this.LblLast.Size = new System.Drawing.Size(61, 13);
            this.LblLast.TabIndex = 35;
            this.LblLast.Text = "Last Name:";
            // 
            // LblFirst
            // 
            this.LblFirst.AutoSize = true;
            this.LblFirst.Location = new System.Drawing.Point(50, 111);
            this.LblFirst.Name = "LblFirst";
            this.LblFirst.Size = new System.Drawing.Size(60, 13);
            this.LblFirst.TabIndex = 34;
            this.LblFirst.Text = "First Name:";
            // 
            // lastTxt
            // 
            this.lastTxt.Location = new System.Drawing.Point(125, 146);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(182, 20);
            this.lastTxt.TabIndex = 33;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(125, 185);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(182, 20);
            this.emailTxt.TabIndex = 32;
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(125, 225);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(182, 20);
            this.contactTxt.TabIndex = 31;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(434, 66);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(200, 20);
            this.addressTxt.TabIndex = 30;
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(125, 108);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(182, 20);
            this.firstTxt.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Student Information Form";
            // 
            // studentChart
            // 
            chartArea5.Name = "ChartArea1";
            this.studentChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.studentChart.Legends.Add(legend5);
            this.studentChart.Location = new System.Drawing.Point(654, 66);
            this.studentChart.Name = "studentChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.studentChart.Series.Add(series5);
            this.studentChart.Size = new System.Drawing.Size(539, 291);
            this.studentChart.TabIndex = 55;
            this.studentChart.Text = "chart1";
            // 
            // DPdob
            // 
            this.DPdob.Location = new System.Drawing.Point(434, 166);
            this.DPdob.Name = "DPdob";
            this.DPdob.Size = new System.Drawing.Size(200, 20);
            this.DPdob.TabIndex = 56;
            // 
            // DPregister
            // 
            this.DPregister.Location = new System.Drawing.Point(434, 222);
            this.DPregister.Name = "DPregister";
            this.DPregister.Size = new System.Drawing.Size(200, 20);
            this.DPregister.TabIndex = 57;
            // 
            // dataGridstudent
            // 
            this.dataGridstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridstudent.Location = new System.Drawing.Point(12, 390);
            this.dataGridstudent.Name = "dataGridstudent";
            this.dataGridstudent.ReadOnly = true;
            this.dataGridstudent.Size = new System.Drawing.Size(846, 285);
            this.dataGridstudent.TabIndex = 58;
            this.dataGridstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridstudent_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            // 
            // SortPick
            // 
            this.SortPick.FormattingEnabled = true;
            this.SortPick.Items.AddRange(new object[] {
            "Name (Ascending)",
            "Name (Descending)",
            "Registration Date (Ascending)",
            "Registration Date (Descending)"});
            this.SortPick.Location = new System.Drawing.Point(701, 363);
            this.SortPick.Name = "SortPick";
            this.SortPick.Size = new System.Drawing.Size(157, 21);
            this.SortPick.TabIndex = 59;
            this.SortPick.SelectedIndexChanged += new System.EventHandler(this.SortPick_SelectedIndexChanged);
            // 
            // weeklyReport
            // 
            this.weeklyReport.Location = new System.Drawing.Point(993, 364);
            this.weeklyReport.Name = "weeklyReport";
            this.weeklyReport.Size = new System.Drawing.Size(200, 20);
            this.weeklyReport.TabIndex = 60;
            this.weeklyReport.ValueChanged += new System.EventHandler(this.weeklyReport_ValueChanged);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(125, 66);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(88, 20);
            this.idTxt.TabIndex = 61;
            this.idTxt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 62;
            // 
            // programme
            // 
            this.programme.HeaderText = "Programme";
            this.programme.Name = "programme";
            // 
            // count
            // 
            this.count.HeaderText = "Count";
            this.count.Name = "count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(639, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Sort By:";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1205, 683);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.weeklyReport);
            this.Controls.Add(this.SortPick);
            this.Controls.Add(this.dataGridstudent);
            this.Controls.Add(this.DPregister);
            this.Controls.Add(this.DPdob);
            this.Controls.Add(this.studentChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.stuWeekReport);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.LblDob);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblProgramme);
            this.Controls.Add(this.CBgender);
            this.Controls.Add(this.CBprogramme);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblContact);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblLast);
            this.Controls.Add(this.LblFirst);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.contactTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "StudentsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stuWeekReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DataGridView stuWeekReport;
        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label LblDob;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblProgramme;
        private System.Windows.Forms.ComboBox CBgender;
        private System.Windows.Forms.ComboBox CBprogramme;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblLast;
        private System.Windows.Forms.Label LblFirst;
        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart studentChart;
        private System.Windows.Forms.DateTimePicker DPdob;
        private System.Windows.Forms.DateTimePicker DPregister;
        private System.Windows.Forms.DataGridView dataGridstudent;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox SortPick;
        private System.Windows.Forms.DateTimePicker weeklyReport;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

