using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreStreaming.Services
{
    public class VideoStreamService : IVideoStreamService
    {
        private HttpClient _cliente;
        public VideoStreamService()
        {
            _cliente = new HttpClient();
        }

        public async Task<Stream> GetVideoByName(string name)
        {
            var url = "https://www.dropbox.com/s/4x04onz4nwdppiv/pintinho.mp4?raw=1";

            return await _cliente.GetStreamAsync(url);
        }

        ~VideoStreamService()
        {
            if(_cliente != null)
            {
                _cliente.Dispose();
            }
        }
    }
}
