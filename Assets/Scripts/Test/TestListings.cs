using System;
using UnityEngine;
using UnityEngine.Replay;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Unity.Metacast.Demo
{
    /// <summary>
    ///     Populate UIBrowser with test json data
    /// </summary>
    public class TestListings : MonoBehaviour
    {
        [SerializeField] private TextAsset m_TestJson;
        private string url = "http://localhost:5000/games";
        /// <summary>
        ///     Start is called on the frame when a script is enabled just
        ///     before any of the Update methods are called the first time.
        /// </summary>
        private void Start()
        {
            string webResult = GetWebResult(url);
            webResult = "{\"listings\":" + webResult + "}";
            //TODO Instead of a TextAsset pass JSON result from the web server.
            UIBrowser.instance.Init(webResult);
            // UIBrowser.instance.Init(m_TestJson.text);
        }

        private string GetWebResult(string url)
        {
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create (url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse ();
            // Display the status.
            Console.WriteLine (response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream ();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader (dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd ();
            // Display the content.
            
            reader.Close ();
            dataStream.Close ();
            response.Close ();

            return responseFromServer;
        }
    }
}