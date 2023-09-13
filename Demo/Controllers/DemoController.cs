using Demo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("Demo")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Aman(string a)
        {
            return a;
        }

        [HttpGet ("GetAdhars")]
        public string NameOf(string adarsh) {
            return adarsh;
        }

        [HttpPost]
        public demoModel postStud(demoModel model)
        {
            demoModel obj = new demoModel();
            obj.Name = model.Name;
            obj.Id = model.Id;
            return obj;
        }
    }
}

