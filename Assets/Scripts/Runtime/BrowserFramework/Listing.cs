using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace UnityEngine.Replay
{    
    /// <summary>
    /// container for multiple listings
    /// </summary>
    [Serializable]
    public class ListingsContainer
    {
        public List<Listing> listings;
    }

    /// <summary>
    ///     Represents an individual browser listing
    /// </summary>
    [Serializable]
    public class Listing
    {
        [Serializable]
        public struct ImageObject
        {
            public string id;
            public string url;
            public Texture2D texture;
            public ImageType type;
            public bool isLoaded;
        }

        public string category;
        public string title;
        public string subtitle;
        public string description;
        public ImageObject[] images;
        public List<Texture2D> pImage = new List<Texture2D>();

        /// <summary>
        ///     Gets a text string of a given TextType
        /// </summary>
        /// <param name="textType">The TextType requested</param>
        /// <returns>A string that matches the requested TextType</returns>
        public string GetText(TextType textType)
        {
            switch (textType)
            {
                case TextType.Title:
                    return title;
                case TextType.Subtitle:
                    return subtitle;
                case TextType.Description:
                    return description;
            }

            return "";
        }

        private IEnumerator DownloadImage(string MediaUrl, int index)
        {   

                   
            using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(MediaUrl)) {
                await uwr.SendWebRequest();
                Debug.Log(uwr.result);
                if (uwr.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(uwr.error);
                }
                else
                {
                    // Get downloaded asset bundle
                    return DownloadHandlerTexture.GetContent(uwr);
                    
                    // Debug.Log(texture);
                    // images[index].texture = texture;
                    
                    // yield imageTexture;
                }
            }

        } 
        /// <summary>
        ///     Gets an image of a given ImageType
        /// </summary>
        /// <param name="imageType">The ImageType requested</param>
        /// <returns>An image that matches the requested ImageType</returns>
        public Texture2D GetImage(ImageType imageType)
        {

            for(var i = 0; i< images.Length; i++) {
                // if (imageObject.isLoaded && imageObject.type == imageType)
                if (images[i].type == imageType)
                {
                    
                    return DownloadImage(images[i].url, i).MoveNext();
                    
                    // Debug.Log(images[i].texture);
                    // return images[i].texture;
                }
            }
                
            
            return new Texture2D(0, 0);
        }
    }
}
