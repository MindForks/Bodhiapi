﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bodhi_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatePlanController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Plan1", "Plan2", "Plan3" };
        }
    }
}