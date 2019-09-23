using Day9.Interfaces;
using Day9.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;

namespace Day9.Controllers
{
    public class AssignmentController : ApiController
    {
        private IScore _score;
        public AssignmentController()
        {
            _score = new Score();
        }
        public AssignmentController(IScore score)
        {
            _score = score;
        }

        [HttpPost]
        [Route("Assignment/Day9")]
        public Assignment Day9()
        {
            HttpFileCollection files = HttpContext.Current.Request.Files;
            string input = string.Empty;
            string resMessage = string.Empty;
            int score = 0;
            bool state = false;
            HttpStatusCode status = HttpStatusCode.OK;
            try
            {
                if (files.Count > 0)
                {
                    HttpPostedFile file = files[0];
                    using (StreamReader sr = new StreamReader(file.InputStream))
                    {
                        input = sr.ReadToEnd();
                        score = _score.CountTotalScore(input);
                    }
                    if(score == 0)
                        resMessage = "Data not computated";
                    else
                    {
                        state = true;
                        resMessage = "Data computated successfully!";
                    }
                }
                else
                    resMessage = "File stream not found";
            }
            catch (Exception ex)
            {
                status = HttpStatusCode.BadRequest;
                resMessage = ex.Message;
            }
            return new Assignment { GroupScore = score, State = state, Message = resMessage, Status = status };
        }
    }
}
