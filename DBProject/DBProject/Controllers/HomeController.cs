using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DBProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Signup(string email, string password, string gender, string bDate)
        {
            SqlParameter param = new SqlParameter("@return", System.Data.SqlDbType.Int);
            param.Direction = System.Data.ParameterDirection.Output;
            using (SqlConnection con = new SqlConnection("Data Source=HUSSAIN-PC\\SQLSVR;Initial Catalog=TVTDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand cmd = new SqlCommand("Signup", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = email;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 20).Value = password;
                cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar, 10).Value = gender;

                cmd.Parameters.Add("@bdate", System.Data.SqlDbType.Date).Value = bDate;
                cmd.Parameters.Add(param);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!Convert.IsDBNull(param.Value))
            {
                return Content("Signed Up");
            }

            return Content("Not Signed Up");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            SqlParameter param = new SqlParameter("@return", System.Data.SqlDbType.Int);
            param.Direction = System.Data.ParameterDirection.Output;
            using (SqlConnection con = new SqlConnection("Data Source=HUSSAIN-PC\\SQLSVR;Initial Catalog=TVTDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand cmd = new SqlCommand("Login", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = email;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 20).Value = password;
                cmd.Parameters.Add(param);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            if (!Convert.IsDBNull(param.Value))
            {
                return Content("Logged In");
            }

            return Content("Not Logged In");
        }
      
    }
}