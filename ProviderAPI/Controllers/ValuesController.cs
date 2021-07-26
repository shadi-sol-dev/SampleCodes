using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Controllers
{
  
        [Route("api/[controller]")]
        [ApiController]
        public class ValuesController : ControllerBase
        {
            // GET api/values
            [HttpGet]
            public ActionResult<IEnumerable<string>> Get()
            {

            String timeStamp = GetTimestamp(DateTime.Now);
            if(ulong.Parse(timeStamp)/2==0)
            return new string[] { "one", "two", "three" };
            else
                throw new Exception("Error");
            }
        private static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
    
}
