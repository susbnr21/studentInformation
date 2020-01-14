//Sushil Bhandari L3C11 17031188

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace L3C11_Sushil_Bhandari_17031188
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent(); //Initializing the components of the form
            BindGrid();

            updateBtn.Visible = false; //making update only visible if any information needs to updated
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Making the components of the form pass to the data grid table after submit button is clicked
            if (CheckValue())
            {
                Student obj = new Student();
                string firstName = firstTxt.Text;
                string lastName = lastTxt.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = addressTxt.Text;
                obj.ContactNo = contactTxt.Text;
                obj.Email = emailTxt.Text;
                obj.BirthDate = DPdob.Value;
                obj.Gender = CBgender.SelectedItem.ToString();
                obj.Programme = CBprogramme.SelectedItem.ToString();
                obj.RegistrationDate = DPregister.Value;
                obj.Add(obj);
                BindGrid();
                Clear();
            }
        }

        private bool CheckValue()
        {
            if (firstTxt.Text == "" && lastTxt.Text == "" && addressTxt.Text == "" && contactTxt.Text == "" && emailTxt.Text == "")
            {
                MessageBox.Show("Fields are empty.", "Empty!");

                return false;
            }
            return true;
        }

        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listsStudents = obj.List();
            DataTable dta = Utility.ConvertToDataTable(listsStudents);
            dataGridstudent.DataSource = dta;
            BindChart(listsStudents);
        }


        //This function makes the text fields empty once the cancel button is clicked
        private void Clear()
        {
            firstTxt.Text = "";
            lastTxt.Text = "";
            addressTxt.Text = "";
            contactTxt.Text = "";
            emailTxt.Text = "";
            CBprogramme.SelectedItem = null;
            CBgender.SelectedItem = null;
            DPdob.Value = DateTime.Today;
            DPregister.Value = DateTime.Today;
        }

        private void GridRow_DbClick(object sender, DataGridViewRowEventArgs e)
        {
            int id = 0;
            string myValue = dataGridstudent[e.Row.Index, 0].Value.ToString();

            Student obj = new Student();
            List<Student> listStudents = obj.List();
            Student student = listStudents.Where(x => x.Id == id).FirstOrDefault(); 
        }

        //If any information is edited this function updates the table value
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                Student obj = new Student();
                obj.Id = int.Parse(idTxt.Text);
                string firstName = firstTxt.Text;
                string lastName = lastTxt.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = addressTxt.Text;
                obj.ContactNo = contactTxt.Text;
                obj.Email = emailTxt.Text;
                obj.Gender = CBgender.SelectedItem.ToString();
                obj.Programme = CBprogramme.SelectedItem.ToString();
                obj.BirthDate = DPdob.Value;
                obj.RegistrationDate = DPregister.Value;
                obj.Edit(obj);
                BindGrid();
                Clear();
                updateBtn.Visible = false;
                submitBtn.Visible = true;
            }
        }

        //Shows the number of student enrolled in programme as a bar graph
        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.Programme)
                    .Select(cl => new
                    {
                        Programme = cl.First().Programme,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                studentChart.DataSource = dt;
                studentChart.Name = "";
                studentChart.Series["Series1"].XValueMember = "Programme";
                studentChart.Series["Series1"].YValueMembers = "Count";
                this.studentChart.Titles.Remove(this.studentChart.Titles.FirstOrDefault());
                this.studentChart.Titles.Add("Weekly Enrollment Chart");
                studentChart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }

        //Clears all the field once the cancel button is clicked
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                //get the value of the clicked rows id coloumn
                string value = dataGridstudent[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("The data is invalid!");
                }
                else
                {
                    id = int.Parse(value);
                    Student student = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    idTxt.Text = student.Id.ToString();
                    firstTxt.Text = student.Name.Split(' ')[0];
                    lastTxt.Text = student.Name.Split(' ')[1];
                    addressTxt.Text = student.Address;
                    contactTxt.Text = student.ContactNo;
                    emailTxt.Text = student.Email;
                    DPdob.Value = student.BirthDate;
                    DPregister.Value = student.RegistrationDate;
                    CBprogramme.SelectedItem = student.Programme;
                    CBgender.SelectedItem = student.Gender;
                    submitBtn.Visible = false;
                    updateBtn.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string value = dataGridstudent[2, e.RowIndex].Value.ToString();
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("The data is invalid!");
                }
                else
                {
                    string message = "Do you want to remove this information?";
                    string title = "Deletion Confirmed";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        //get the value of the clicked rows id column
                        string Id = dataGridstudent[2, e.RowIndex].Value.ToString();
                        obj.Delete(int.Parse(Id));
                        BindGrid();
                        MessageBox.Show("The information has been deleted successfully.");
                    }
                }
            }
        }

        private void SortPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> studentList = student.List();
            if (SortPick.SelectedItem.ToString().Equals("Name (Ascending)"))
            {
                List<Student> list = student.sortFNameAsc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridstudent.DataSource = dt;
            }
            else if (SortPick.SelectedItem.ToString().Equals("Name (Descending)"))
            {
                List<Student> list = student.sortFNameDesc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridstudent.DataSource = dt;
            }
            else if (SortPick.SelectedItem.ToString().Equals("Registration Date (Ascending)"))
            {
                List<Student> list = student.sortRegDateAsc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridstudent.DataSource = dt;
            }
            else if (SortPick.SelectedItem.ToString().Equals("Registration Date (Descending)"))
            {
                List<Student> list = student.sortRegDateDesc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridstudent.DataSource = dt;
            }
        }

        private void weeklyReport_ValueChanged(object sender, EventArgs e)
        {
            DateTime selected = weeklyReport.Value;
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = selected.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            var first_day_week = selected.AddDays(-diff).Date;
            //startingDateLbl.Text = "Weekly Data shown starting with first day of week:" + first_day_week.ToString("dd/MM/yyyy");
            var last_day_week = selected.AddDays(7);
            stuWeekReport.Rows.Clear();
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            var convertStudents = listStudents.Where(s => s.RegistrationDate >= first_day_week && s.RegistrationDate < last_day_week);

            int computing = 0;
            int networking = 0;
            int multimedia = 0;


            foreach (Student stu in convertStudents)
            {
                if (stu.Programme == "Computing")
                {
                    computing += 1;
                }
                else if (stu.Programme == "Multimedia Technologies")
                {
                    multimedia += 1;
                }
                else if (stu.Programme == "Networking and IT Security")
                {
                    networking += 1;
                }
            }

            stuWeekReport.Rows.Add(new Object[] { "Computing", computing });
            stuWeekReport.Rows.Add(new Object[] { "Multimedia", multimedia });
            stuWeekReport.Rows.Add(new Object[] { "Networking", networking });
        }
    }
}
