using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppsTraining.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        //public string Index()
        //{
            
            //return "This is my default action..";
        //}

        // GET: /HelloWorld/Welcome/
        // this public class for welcome with param 
        // public string Welcome(string name, int numTimes = 1)

        //public string Welcome(string name, int ID = 1)
        //{
            // return "This is my default action..";
            // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numTimes}");

           // return HtmlEncoder.Default.Encode($"Hello {name}, ID : {ID}");
        //}

        // this is controller for view test
        public IActionResult index()
        {
            return View();
        }

    }
}
