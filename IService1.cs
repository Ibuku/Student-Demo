using System;
using System.ServiceModel;
using StudentDemo.BO.Request;
using StudentDemo.BO.Response;
using System.Collections.Generic;


namespace StudentDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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

        // TODO: Add your service operations here
    }
}

