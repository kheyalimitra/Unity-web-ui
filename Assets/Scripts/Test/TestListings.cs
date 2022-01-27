using System;
using UnityEngine;
using UnityEngine.Replay;
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
        }
        private string GetWebResult(string url)
        {
            try {
                WebRequest request = WebRequest.Create (url);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse ();
                Stream dataStream = response.GetResponseStream ();
                StreamReader reader = new StreamReader (dataStream);
                string responseFromServer = reader.ReadToEnd ();
                reader.Close ();
                dataStream.Close ();
                response.Close ();
                return responseFromServer;
            } catch (Exception e) {
                return "";
            }
        }
    }
}