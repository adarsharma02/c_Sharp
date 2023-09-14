using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.bl;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/adarsh")]
    [ApiController]
    public class stuController : ControllerBase
    {
        [HttpGet]

        public string Getstu()
        {
            string studentName;
            studentName = "adarshSharma";

            return studentName;
        }
        [HttpGet("{Id}")]
        public string Getstu(int id)
        {
            string studentName;
            stubl objStu = new stubl();
            studentName = objStu.getStudentbyId(id);


            return studentName;
        }
        [HttpGet("{num1}/{num2}")]
        public int summOf(int num1, int num2)
        {
           
            addtwoNum objSumm = new addtwoNum();
            int sum;
            sum = objSumm.addtwo(num1 ,num2);
            
            return  sum;
        }
      


    }
}
