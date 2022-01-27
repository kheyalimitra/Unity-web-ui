using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.Replay;
public class GamesListGenerator : MonoBehaviour {
 
    // private string url = "http://localhost:5000/games";
    // // public static UIBrowser uiObj;
    // void Start() {
    //     StartCoroutine (ReceiveResponse());
    // }
 
    // private void ReceiveResponse() {
    //     using ( UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(url) ) {
	// 		await uwr.SendWebRequest();
	// 		if ( uwr.result == UnityWebRequest.Result.ConnectionError) {
	// 			Debug.LogError(uwr.error);
	// 		}
	// 		else {
    //             var text = uwr.downloadHandler.text;
    //             return "{\"listings\":" + text + "}";
    //             // JSONNode itemsData = JSON.Parse(text);
    //             // Debug.Log(itemsData);
    //             // UIBrowser.instance.Init("{\"listings\":" + text + "}");
	// 		}
	// 	}
    // }
}