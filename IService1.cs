using System;
using System.ServiceModel;
using StudentDemo.BO.Request;
using StudentDemo.BO.Response;
using System.Collections.Generic;


namespace StudentDemo
{
    
    [ServiceContract]
    public interface IService1
    {



        [OperationContract]
        StudentResponse AddStudent(StudentResponse student);

        [OperationContract]
        List<StudentRequest> GetAll(StudentResponse student);

       [OperationContract]
        StudentResponse GetById(int Id);

        [OperationContract]
        int UpdateStudent(StudentRequest student);

        [OperationContract]
        int DeleteStudent(int studentId);

      
    }
}

