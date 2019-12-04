using System;
using System.Collections.Generic;
using StudentDemo.BO.Response;
using StudentDemo.BO.Request;
using StudentDemo.BLL;
using StudentDemo.DAL;




namespace StudentDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        StudentBLL BLL = new StudentBLL();
        public StudentResponse AddStudent(StudentResponse student)
        {
            return BLL.AddStudent(student);
        }

        public List<StudentRequest> GetAll(StudentResponse student)
        {
            return BLL.GetAll(student);
        }

        public StudentResponse GetById(int studentId)
        {
            return BLL.GetById(studentId);
        }
        public int UpdateStudent(StudentRequest student)
        {
            return BLL.UpdateStudent(student);
        }
       
        public int DeleteStudent(int studentId)
        {
            return BLL.DeleteStudent(studentId);
        }
    }
}

