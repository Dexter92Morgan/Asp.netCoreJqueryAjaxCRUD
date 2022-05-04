using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Models
{
    public class EmployeeDA
    {
        private readonly AjaxContext context;

        public EmployeeDA()
        {
        }

        public EmployeeDA(AjaxContext ajaxContext)
        {
            context = ajaxContext;

        }

        public List<TblEmployee> Getall()
        {
            return context.TblEmployee.ToList();
        }

        public List<TblDesgnation> GetallDesignation()
        {
            return context.TblDesgnation.ToList();
        }

        public TblEmployee GetbyCode(int code)
        {
            return context.TblEmployee.FirstOrDefault(o => o.Code == code);
        }
        public string Remove(int code)
        {
            string Result = string.Empty;
           var employee = context.TblEmployee.FirstOrDefault(o => o.Code == code);

            if(employee !=null)
            {
                context.TblEmployee.Remove(employee);
                context.SaveChanges();
                Result = "Pass";
            }
            return Result;
        }
        public string Save(TblEmployee tblEmployee)
         {
            string Result = string.Empty;
            try
            {
                var employee = context.TblEmployee.FirstOrDefault(o => o.Code == tblEmployee.Code);

                if (employee != null)
                {
                    employee.Name = tblEmployee.Name;
                    employee.Email = tblEmployee.Email;
                    employee.Phone = tblEmployee.Phone;
                    employee.Designation = tblEmployee.Designation;

                    context.SaveChanges();
                    Result = "Pass";
                }
                else
                {
                    TblEmployee tbl = new TblEmployee
                    {
                        Name = tblEmployee.Name,
                        Email = tblEmployee.Email,
                        Phone = tblEmployee.Phone,
                        Designation = tblEmployee.Designation

                    };
                    context.TblEmployee.Add(tbl);
                    context.SaveChanges();
                    Result = "Pass";
                }
            }
            catch (Exception ex)
            {
           
            }
            return Result;
        }


    }
}
