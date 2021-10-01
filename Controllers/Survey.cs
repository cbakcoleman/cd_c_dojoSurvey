using Microsoft.AspNetCore.Mvc;

namespace cd_c_dojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Survey()
        {
            return View();
        } // END SURVEY ROUTE

        
    }

}