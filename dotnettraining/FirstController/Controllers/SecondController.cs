using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApis.Controllers
{
    [Route("api/[controller]")]             //Pattern of uri
    [ApiController]
    public class SecondController : ControllerBase
    {
        [HttpGet]               //api/Second/tryroute
        [Route("tryroute")]    //Additional pattern
        public string[] Get()
        {
            return new string[] { "Eena", "Meena", "Deeka", "Cheeka" };
        }
        [HttpGet("/getplace/{place}")]     //https:.../api/second/getplace/pune      ('/'is before 'getplace' so directly type getplace after host - https://localhost:44383/getplace/pune)
        public string GetSinglePlace(string place)
        {
            return $"The selected place is: {place}";
        }
        [HttpGet("{s1}")]     //https:.../api/second/pune   
        public string getAnotherPlace(string s1)
        {
            return $"The other place you chose is: {s1}";
        }
        [HttpGet("getsingle/{placeId}/details")]     //=> RouteParam api/second/getsingle/pune/details?speciality=vadapav              (/details is not necessary,if not provided in route then url is api/second/getsingle/pune?speciality=vadapav )
        public string GetSinglePlace([FromRoute] string placeId, [FromQuery] string speciality)
        {
            return $"{placeId} is known for {speciality}";
        }

        private static List<Post> _posts = new List<Post>();

        [HttpPost("{msg}")]  //201 = created    //https://..../api/second/hello
        public IActionResult Post([FromBody] Post newPost, [FromRoute] string msg)                   //using frombody, give the values in raw in postman    
        {
            _posts.Add(newPost);
                            // https                                //localhost:<port>        +/api/second/valueforMsg
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/",
                                 newPost);
        }



        [HttpPost("fromform/{msg}")]  //201 = created    //https://..../api/second/hello
        public IActionResult PostForm([FromForm] Post newPost, [FromRoute] string msg)                     //using fromform, give the values in formdata in postman
        {
            if (ModelState.IsValid)                        //checks if input is acc to validation and only posts if it is
            {
                _posts.Add(newPost);
                // https                                //localhost:<port>        +/api/second/valueforMsg
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/",
                                     newPost);
            }
            else
            {
                return BadRequest(ModelState.ErrorCount);      //status code:400
            }

            
        }

        [HttpGet("getposts")]
        public List<Post> GetAllPosts() {
            return _posts;
        }

        [HttpPut("/update/{id}")]   //https://localhost:12345/update/1
        public IActionResult Update([FromRoute] int id, [FromForm] Post tobeupdated)
        {
            Post foundPost = _posts.Find((p) => p.id == id);           //Post foundpost is used to make return type as post and return the post
                                                                       //Make the updates
            foundPost.title = tobeupdated.title;
            foundPost.body = tobeupdated.body;
            foundPost.userid = tobeupdated.userid;

            return Ok(foundPost);
        }

        [HttpDelete("/delete/{id}")]   //https://localhost:12345/delete/1
        public IActionResult Delete([FromRoute] int id)
        {
            Post removePost = _posts.Find((p) => p.id == id);           //Post foundpost is used to make return type as post and return the post
            _posts.Remove(removePost);
            

            return Ok("Deleted Successfully");
        }
    }

}
