using System.IO;
using System.Threading.Tasks;

namespace DotNetCoreStreaming.Services
{
    public interface IVideoStreamService
    {
        Task<Stream> GetVideoByName(string name);
    }
}
