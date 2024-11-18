using System.Net;
using System.Text;

namespace CameraQQQ.Services;

public class SendRequestToServer
{
    private static string serverApi = "http://192.168.6.225:5000/";

    /// <summary>
    /// Send Request to Server
    /// </summary>
    /// <param name="method">HttpMethod: GET, POST, PUT, PATCH, DELETE</param>
    /// <param name="path">Path to Server API</param>
    /// <returns></returns>
    public static (string Data, HttpStatusCode StatusCode) SendRequest(HttpMethod method, string path)
    {
        HttpStatusCode statusCode;
        string data = "";
        path = path[0] == '/' ? path.Remove(0, 1) : path;
        path = serverApi + path;

        HttpClient httpClient = new HttpClient();
        HttpRequestMessage request = new HttpRequestMessage(method, path);
        HttpResponseMessage response = httpClient.Send(request);

        statusCode = response.StatusCode;
        data = ReadData(response.Content.ReadAsStream());

        httpClient.Dispose();
        request.Dispose();
        response.Dispose();
        return (data, statusCode);
    }

    /// <summary>
    /// Send Request to Server
    /// </summary>
    /// <param name="method">HttpMethod: GET, POST, PUT, PATCH, DELETE</param>
    /// <param name="path">Path to Server API</param>
    /// <param name="jsonBody">jsonBody must convert to JSON</param>
    /// <returns></returns>
    public static (string Data, HttpStatusCode StatusCode) SendRequest(HttpMethod method, string path, string jsonBody)
    {
        HttpStatusCode statusCode;
        string data = "";
        path = path[0] == '/' ? path.Remove(0, 1) : path;
        path = serverApi + path;

        HttpClient httpClient = new HttpClient();
        HttpRequestMessage request = new HttpRequestMessage(method, path);
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        HttpResponseMessage response = httpClient.Send(request);

        statusCode = response.StatusCode;
        data = ReadData(response.Content.ReadAsStream());

        httpClient.Dispose();
        request.Dispose();
        response.Dispose();

        return (data, statusCode);
    }

    /// <summary>
    /// Read data from Stream
    /// </summary>
    /// <param name="stream">Stream from HttpMessageResponse</param>
    /// <returns>data from stream</returns>
    private static string ReadData(Stream stream)
    {
        string data = "";
        using (stream)
        {
            long bufferSize = stream.Length;
            byte[] buffer = new byte[bufferSize];
            stream.Read(buffer, 0, buffer.Length);
            data = Encoding.UTF8.GetString(buffer);
        }
        return data;
    }
}
