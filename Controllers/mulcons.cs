using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mulcons : ControllerBase
    {
        [HttpGet("{num3}/{num4}")]
        public int multioftwoNum(int num3, int num4)
        {
            // mltwonumber newobj = new mltwonumber();
            // int mulnums = newobj.multwo(num3, num4);
            int mulnums = num3 + num4;
            return mulnums;
        }


    }
            
        }
    