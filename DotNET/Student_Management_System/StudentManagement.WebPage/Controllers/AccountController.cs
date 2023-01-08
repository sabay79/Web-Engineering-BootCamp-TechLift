using StudentManagement.WebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace StudentManagement.WebPage.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

        //void connectionstring()
        //{
        //    connection.ConnectionString = "data source = CRIBV-DNET29; database = StudentManagementSystem; integrated security = SSPI";
        //}

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            connection.Open();
            command.Connection= connection;
            command.CommandText = "Select * from credentials where email ='"+account.email+"' and password ='"+account.password+"'";
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                ViewBag.Message = String.Format("LogIn Successful");
                return View(); 
            }
            else
            {
                connection.Close();
                ViewBag.Message = String.Format("LogIn Failed");
                return View();
            }
        }
    }
}