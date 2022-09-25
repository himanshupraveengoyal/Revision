using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Revision.Models;

namespace Revision.Controllers
{
    public class RevisionController : Controller
    {
        RevisionMVCContext _dbContext;

        public RevisionController()
        {
            _dbContext = new RevisionMVCContext();
        }

        public IActionResult Index()
        {
            TblDepartment tblDepartment = new TblDepartment();
            //tblDepartment.Name = "BCA"; tblDepartment.Description = "Business Speciality People";
            //_dbContext.TblDepartments.Add(tblDepartment);
            SqlParameter sqlParameter = new SqlParameter("@name","abc");
            SqlParameter sqlParameter1 = new SqlParameter("@Department_ID",1);
            SqlParameter sqlParameter2 = new SqlParameter("@MobileNumber", "74821");
            var products = _dbContext.TblDepartments.FromSqlInterpolated($"exec AddStudentToTable @name={sqlParameter},@MobileNumber={sqlParameter2},@departmentID={sqlParameter1}");
            _dbContext.SaveChanges();
            
            return View();
        }
    }
}
