using Microsoft.AspNetCore.Http;

namespace DatingApp_API.Helpers
{
    public static class Extensisons
    {
        public static void AddAppError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}