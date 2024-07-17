using ApiCore;
using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {


        //Kökdizin/api/Home/GetMessages
        [HttpGet]
        [Route("GetMessagesObject")]
        public ActionResult<Response<List<string>>> GetMessagesObject()
        {
            List<string> datas = new List<string>
            {
                "Bektaş baykara","Sihamettin adıgüzel","Ömer kendigüzel","Nurullah şeytanıbol"
            };

            var response = new Response<List<string>>(true, "Listeleme Başarılı", datas, 200);


            return Ok(response);
        }


        [HttpGet]
        [Route("sign-in")]
        public ActionResult<Response<List<string>>> SignIn()
        {
            List<string> datas = new List<string>
            {
                "Bektaş baykara","Sihamettin adıgüzel","Ömer kendigüzel","Nurullah şeytanıbol"
            };

            var response = new Response<List<string>>(true, "Listeleme Başarılı", datas, 200);


            return Ok(response);
        }
    }
}

