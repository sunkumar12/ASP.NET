using MynewASPWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Mvc.Razor;

namespace MynewASPWEBAPI.Controllers
{
    public class NewAPIController : ApiController
    {
        empEntities1 db = new empEntities1();

        [System.Web.Http.HttpGet]
        public IHttpActionResult Index()
        {
            List<employee_tab1> obj = db.employee_tab1.ToList();
            return Ok(obj);
;        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Index(int id)
        {
            var obj = db.employee_tab1.Where(model1=>model1.Empid == id).FirstOrDefault();
            return Ok(obj);
            
        }
    }
}
