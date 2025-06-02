using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    /// <summary>
    /// Provides functionality to call HTTP APIs and return the response as formatted JSON.
    /// </summary>
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _client = new();

        /// <summary>
        /// Calls an API with the specified HTTP method.
        /// </summary>
        public async Task<string> CallApi(string url, bool formatOutput = true, HttpAction action = HttpAction.GET, string jsonPayload = null)
        {
            try
            {
                HttpResponseMessage response;

                switch (action)
                {
                    case HttpAction.GET:
                        response = await _client.GetAsync(url);
                        break;
                    case HttpAction.POST:
                        response = await _client.PostAsync(url, new StringContent(jsonPayload ?? "", Encoding.UTF8, "application/json"));
                        break;
                    case HttpAction.PUT:
                        response = await _client.PutAsync(url, new StringContent(jsonPayload ?? "", Encoding.UTF8, "application/json"));
                        break;
                    case HttpAction.DELETE:
                        response = await _client.DeleteAsync(url);
                        break;
                    default:
                        return "Unsupported HTTP action.";
                }

                if (!response.IsSuccessStatusCode)
                {
                    return $"Error: {(int)response.StatusCode} {response.ReasonPhrase}";
                }

                string rawContent = await response.Content.ReadAsStringAsync();

                if (!formatOutput)
                {
                    return rawContent;
                }

                try
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(rawContent);
                    return JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });
                }
                catch (JsonException)
                {
                    return rawContent; // Not a JSON response
                }
            }
            catch (HttpRequestException ex)
            {
                return $"Network Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected Error: {ex.Message}";
            }
        }

        /// <summary>
        /// Checks whether the provided URL is a valid HTTPS URL.
        /// </summary>
        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
                          uriOutput.Scheme == Uri.UriSchemeHttps;

            return output;
        }
    }
}
