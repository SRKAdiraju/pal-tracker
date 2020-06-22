using System;
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        public WelcomeController()
        {
            
        }
        [HttpGet]
        public string SayHello() => "hello";
    }
}
