using System;
using Microsoft.AspNetCore.Mvc;

namespace project1.Controllers
{
    [Route("api/[controller]")]
    public class CodeCampController : ControllerBase
    {
        //public object Get()
        //{
        //    return new { Name = "Gouda", Job = "Developer" };
        //}

        public IActionResult Get()
        {
            if (false)
            {
            }

            return Ok( new { Name = "Gouda", Job = "Developer" });
        }
    }
}
