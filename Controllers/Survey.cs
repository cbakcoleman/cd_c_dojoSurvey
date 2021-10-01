using Microsoft.AspNetCore.Mvc;

namespace cd_c_dojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        
        [HttpGet("")]
        public ViewResult Survey()
        {
            return View();
        } // END SURVEY ROUTE

        
        [HttpPost("results")]
        public ViewResult Results(string name, string location, string language, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comments;
            return View();
        } // END RESULTS ROUTE
        
    } // END SURVEYCONTROLLER

}