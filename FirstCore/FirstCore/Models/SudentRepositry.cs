using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class SudentRepositry : Istudentrepositry
    {
        public List<Student> StudentData()
        {
            return new List<Student>()
            {
                new Student()
                {
                    studentId=101,
                    Name="YAdagiri3",
                    Branch="CEC3",
                    Section="B3",
                    Gender="Male3"
                },
                //2  student

                    new Student()
                {
                    studentId=102,
                    Name="YAdagiri3",
                    Branch="CEC2",
                    Section="B2",
                    Gender="Male2"
                },
                    //3

                        new Student()
                {
                    studentId=103,
                    Name="YAdagiri3",
                    Branch="CEC1",
                    Section="B1",
                    Gender="Male1"
                },

            };



        }
        public Student GetStudentById(int Id)
        {
            return StudentData().FirstOrDefault(Student => Student.studentId == Id) ?? new Student();
        }
    }
}
