using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamelaPicture : MonoBehaviour
{
	public GameObject cube;
	// Use this for initialization
	void Start ()
	{
		WebCamDevice[] devices = WebCamTexture.devices;
		if (devices.Length > 0) {
			WebCamTexture mWebCameTexture = new WebCamTexture (devices [0].name);
			cube.GetComponent<Renderer> ().material.mainTexture = mWebCameTexture;
			mWebCameTexture.Play ();
		} else {
			Debug.LogError ("Webカメラ認識不可");
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
