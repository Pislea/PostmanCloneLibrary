using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApi(string url, bool formatOutput = true, HttpAction action = HttpAction.GET, string jsonPayload = null);
        bool IsValidUrl(string url);
    }
}
