using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01593039ExampleProject.Controllers
{
    public class TestController : ApiController
    {
        //Get api/test -> "My first project"
       /* public string Get()
        {
            return "My first Controller!";

        }
        public int Get()
        {
            return 5;
        }*/
       // Get api/test/4 -> 4
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
