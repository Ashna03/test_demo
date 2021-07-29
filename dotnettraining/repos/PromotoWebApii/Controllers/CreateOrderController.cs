using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromotoWebApii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotoWebApii.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : ControllerBase
    {
        [HttpGet("/getproducts")]
        public IActionResult ProductsList() { 
            PromotoContext db = new PromotoContext();      //use the object of dbcontext for accessing tables
            return Ok(db.Products.ToList());              //Since the table name is product but we are accessing list of products 'Products' so convert to list    
        }

        [HttpPost("/placepincode")]
        public IActionResult PlacePincode(Pincode pinObj)        //Create an object 'pinObj' for Pincode class
        {
            PromotoContext db = new PromotoContext();
            db.Pincodes.Add(pinObj);                             //adding the object to The class
            db.SaveChanges();                                    //writes these values to db
            return Ok("The records have been saved successfully");

        
        }
    }
}
