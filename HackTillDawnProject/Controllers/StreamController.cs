using HackTillDawnProject.Models;
using HackTillDawnProject.Services;
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
        private IFootageStorageService _FootageStorageService { get; }
        public StreamController(IFootageStorageService ifss)
        {
            _FootageStorageService = ifss;
        }
        public IActionResult Index()
        { return View(); }
        public async Task<FileStreamResult> StreamMe(string footage_id)
        {
            try
            {
                Guid footage_guid;
                if (Guid.TryParse(footage_id, out footage_guid))
                {
                    FootageStorage Footage = _FootageStorageService.Get(footage_guid);
                    byte[] stream = await System.IO.File.ReadAllBytesAsync(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Videos", Footage.FileName + ".mp4"));
                    MemoryStream result = new MemoryStream(stream);

                    return new FileStreamResult(result, "video/mp4");
                }
                else
                {
                    byte[] stream = await System.IO.File.ReadAllBytesAsync(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Videos", "not_found.mp4"));
                    MemoryStream result = new MemoryStream(stream);

                    return new FileStreamResult(result, "video/mp4");
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            
            
        }
    }
}
