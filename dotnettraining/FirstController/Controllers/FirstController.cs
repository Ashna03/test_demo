using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApis.Controllers
{
    [Route("api/[controller]/[action]")]    //Pattern matching expression for the url
    [ApiController]           //Marking it as a Web class
    public class FirstController : ControllerBase      //You can access this web class via URI on the browser
    {
        //http://..../api/First/Greet?yourname=Meena
        [HttpGet]
        public string Greet(string yourName) {
            return $"Welcome to Webapis, {yourName}";
        }
        //http://.../api/First
        [HttpGet]
        public string SayNamaste()
        {
            return "Namaste";
        }
        //https://.../api/First/fname=Meena&lname=Narayan
        [HttpGet]
        public string FullName(string fname, string lname) {
            return $"You full name is: {fname} {lname}";                           //give url as- https://localhost:44383/api/First/FullName?fname=Meena&lname=Narayan //

        }

        [HttpGet]
        public Post GetDefaultPost(int i)
        {
            return new Post() { id = 1, 
                                userid = 1,
                                title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                                body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum"
                              };
        }
    }
}

