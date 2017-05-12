using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetList.Models.DB;

namespace GetList.Controllers
{
    public class StudentController : ApiController
    {
        public readonly masterEntities _db = new masterEntities();


        // GET api/GetStudentList
        [HttpGet]
        [ActionName("GetStudentList")]
        public IEnumerable<interview_GetStudentList_Result> GetStudentList(string studentinstr)
        {
            var data = _db.interview_GetStudentList(studentinstr);
            return data;
        }

    }
}
