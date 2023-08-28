using HubPro.Hub.API.DTOs.Request;
using HubPro.Hub.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HubPro.Hub.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ClienteRequest request)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(ClienteRequest request)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(ClienteRequest request)
        {  
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(ClienteRequest request)
        {
            return Ok();
        }


    }
}
