using Student_Records.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Records.DataOperations
{
    public class StudentRepository
    {
        public static int id = 1;
        public static List<Student> studentList = new List<Student>();

        public static void AddStudent(Student studentModel)
        {
            studentModel.Id = id++;
            studentList.Add(studentModel);
        }

        public static Student GetStudent(int id)
        {
            return studentList.FirstOrDefault(x => x.Id == id);
        }

        public static bool UpdateStudent(int id, Student studentModel)
        {
            var student = studentList.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                student.Name = studentModel.Name;
                student.RollNumber = studentModel.RollNumber;
                student.Age = studentModel.Age;
                student.Gender = studentModel.Gender;
                return true;
            }
            return false;
        }

        public static void DeleteStudent(int id)
        {
            Student student = studentList.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                studentList.Remove(student);
            }
        }
    }
}