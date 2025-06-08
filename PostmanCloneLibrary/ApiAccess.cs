using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        public async Task<string> CallApi(string url, bool formatOutput = true, HttpAction action = HttpAction.GET, string? jsonPayload = null)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;

                switch (action)
                {
                    case HttpAction.GET:
                        response = await client.GetAsync(url);
                        break;

                    case HttpAction.POST:
                        response = await client.PostAsync(url, new StringContent(jsonPayload ?? "", Encoding.UTF8, "application/json"));
                        break;

                    case HttpAction.PUT:
                        response = await client.PutAsync(url, new StringContent(jsonPayload ?? "", Encoding.UTF8, "application/json"));
                        break;

                    case HttpAction.DELETE:
                        response = await client.DeleteAsync(url);
                        break;

                    default:
                        return "Error: Unsupported HTTP verb.";
                }

                string result = await response.Content.ReadAsStringAsync();

                if (formatOutput == true)
                {
                    return result; 
                }

                return result;
            }
        }

        public bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri? validatedUri) && validatedUri.Scheme == Uri.UriSchemeHttps;
        }
    }
}
