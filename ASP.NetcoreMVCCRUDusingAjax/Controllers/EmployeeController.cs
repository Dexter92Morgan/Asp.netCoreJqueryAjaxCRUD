using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetcoreMVCCRUDusingAjax.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AjaxContext context;

        public EmployeeController(AjaxContext ajaxContext)
        {
            context = ajaxContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Getall()
        {
            List<TblEmployee> _list = new EmployeeDA(context).Getall();
            return Json(_list);
        }

        public JsonResult GetallDesignation()
        {
            List<TblDesgnation> _list = new EmployeeDA(context).GetallDesignation();
            return Json(_list);
        }


        public JsonResult GetBycode( string code)
        {
            TblEmployee _list = new EmployeeDA(context).GetbyCode(Convert.ToInt32(code));
            return Json(_list);
        }

        public JsonResult Remove(string code)
        {
            string _list = new EmployeeDA(context).Remove(Convert.ToInt32(code));
            return Json(_list);
        }

        public JsonResult Save(TblEmployee tblEmployee)
        {
            string _list = new EmployeeDA(context).Save(tblEmployee);
            return Json(_list);
        }
    }
}
