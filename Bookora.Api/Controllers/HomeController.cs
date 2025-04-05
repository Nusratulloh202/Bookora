//==================================================
// Copyright (c) Bookora Project
// Powered by The Standard by Hassan Habib
// Manage Your Library Smarter
//==================================================
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RESTFulSense.Controllers;

namespace Bookora.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
           Ok("Hello Nusratulloh, project Bookora active.");
    }
}
