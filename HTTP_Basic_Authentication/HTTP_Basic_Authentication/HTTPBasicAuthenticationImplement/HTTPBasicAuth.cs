using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_Basic_Authentication.HTTPBasicAuthenticationImplement
{
    public class HTTPBasicAuth
    {
        public async Task<string> HTTPBasicAuthentication(string uri, string username, string password)
        {
            try
            {
                WebRequest request = WebRequest.Create(uri);
                request.Credentials = new NetworkCredential(username, password);

                WebResponse response = await request.GetResponseAsync();

                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);

                    return reader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetResponseString(string uri, string username, string password)
        {
            var returnString = HTTPBasicAuthentication(uri, username, password);

            return returnString.Result;
        }

    }
}
