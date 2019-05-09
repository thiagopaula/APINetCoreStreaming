using DotNetCoreStreaming.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DotNetCoreStreaming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        public IVideoStreamService _videoStreamService { get; set; }

        public ClienteController(IVideoStreamService videoStreamService)
        {
            _videoStreamService = videoStreamService;
        }

        public async Task<FileStreamResult> Get(string name)
        {
            try
            {
                var stream = await _videoStreamService.GetVideoByName(name);
                return new FileStreamResult(stream, new MediaTypeHeaderValue("video/mp4").MediaType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}