using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Data;

namespace EmployeeLibrary
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        DataSet GetEmployees();

        [OperationContract]
        Employee GetEmployee(int id);

    }
}
