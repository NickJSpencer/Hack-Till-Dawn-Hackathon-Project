using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackTillDawnProject.Controllers
{
    public class StreamController : Controller
    {
        public async Task Index()
        {
            var response = HttpContext.Response;
            response.Headers.Add("Content-Type", "video/abst");

            for (var i = 0; true; ++i)
            {
                await response
                    .WriteAsync($"data: Controller {i} at {DateTime.Now}\r\r");

                response.Body.Flush();
                await Task.Delay(5 * 1000);
            }
        }
    }
}
