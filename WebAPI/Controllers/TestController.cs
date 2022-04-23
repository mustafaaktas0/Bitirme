﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController :ControllerBase
    {
  

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            
                return Ok("deneme");
            
        }
    }
}
