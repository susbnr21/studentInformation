//Sushil Bhandari L3C11 17031188

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace L3C11_Sushil_Bhandari_17031188
{
    public class Student
    {
        //getting the information from all the components into the data grid table
        private string _filePath = "student.json";
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Programme { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public void Add(Student info)
        {
            Random rand = new Random();
            info.Id = rand.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);
        }

        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }

        public void Edit(Student info)
        {
            List<Student> list = List(); //invoking the list method of the student class to get student list
            Student student = list.Where(x => x.Id == info.Id).FirstOrDefault(); //using linq to selelct student having the specified id
            list.Remove(student); // removing the student object that needs to be updated from the list
            list.Add(info); //adding the updated student object to the list
            string data = JsonConvert.SerializeObject(list, Formatting.None); //converting list of student to string
            Utility.WriteToTextFile(_filePath, data, false); // invoking method of utility class
        }

        public void Delete(int id)
        {
            List<Student> list = List(); //invking list method of the student class to get student list
            Student student = list.Where(x => x.Id == id).FirstOrDefault(); //using linq to selelct student having the specified id
            list.Remove(student); //removing the student object that needs to be updated from the list
            int count = list.Count; //converting the list of student to string
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, data, false, count); //invoking method of utility class
        }

        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }

        public List<Student> List()
        {
            string define = Utility.ReadFromTextFile(_filePath);
            if (define != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(define);
                return lst;
            }
            return null;
        }

        public List<Student> sortFNameAsc(List<Student> studentList)
        {
            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].Name.CompareTo(studentList[j].Name) > 0)
                        {

                            Student tempStudent = studentList[i];
                            studentList[i] = studentList[j];
                            studentList[j] = tempStudent;
                        }
                    }
                }
                return studentList;
            }
            return null;
        }
        public List<Student> sortFNameDesc(List<Student> studentList)
        {
            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].Name.CompareTo(studentList[j].Name) < 0)
                        {

                            Student tempStudent = studentList[i];
                            studentList[i] = studentList[j];
                            studentList[j] = tempStudent;
                            
                        }
                    }
                }
                return studentList;
            }
            return null;
        }

        public List<Student> sortRegDateAsc(List<Student> studentList)
        {
            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].RegistrationDate.CompareTo(studentList[j].RegistrationDate) > 0)
                        {

                            Student tempStudent = studentList[i];
                            studentList[i] = studentList[j];
                            studentList[j] = tempStudent;

                        }
                    }
                }
                return studentList;
            }
            return null;
        }

        public List<Student> sortRegDateDesc(List<Student> studentList)
        {
            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].RegistrationDate.CompareTo(studentList[j].RegistrationDate) < 0)
                        {

                            Student tempStudent = studentList[i];
                            studentList[i] = studentList[j];
                            studentList[j] = tempStudent;

                        }
                    }
                }
                return studentList;
            }
            return null;
        }
    }
}
