using System.Net.Http;
using System.Threading.Tasks;

namespace RetailDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task Authenticate(string username, string password);
    }
}