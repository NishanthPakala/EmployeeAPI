using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBusinessLayer
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAllEmplyees();
        List<EmployeeModel> GetAllMangers();
        List<EmployeeModel> GetAllNonMangers();
        EmployeeModel AddEmployee(EmployeeModel employeeModel);

        EmployeeModel EditEmployee(int Id, EmployeeModel employeeModel);
    }

    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeModel> lstEmp;

        public EmployeeService()
        {
            lstEmp = new List<EmployeeModel>();

            var rng = new Random();
            var bytes = new byte[20];
            rng.NextBytes(bytes);
            lstEmp = Enumerable.Range(1, 20).Select(index => new EmployeeModel
            {

                EmployeeId = index,
                EmployeeName = "test names " + rng.Next(100, 200).ToString()
            })
            .ToList();
        }

        public EmployeeModel AddEmployee(EmployeeModel employeeModel)
        {
            lstEmp.Add(employeeModel);

            return employeeModel;
        }

        public EmployeeModel EditEmployee(int Id, EmployeeModel employeeModel)
        {
            lstEmp.Add(employeeModel);

            return employeeModel;
        }

        public List<EmployeeModel> GetAllEmplyees()
        {
            return lstEmp;
        }

        public List<EmployeeModel> GetAllMangers()
        {
            return lstEmp;
        }

        public List<EmployeeModel> GetAllNonMangers()
        {
            return lstEmp;
        }
    }
}
