using UnityEngine;
using System.Collections;
using System;

public class ResizeBackgroundImage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//guiTexture.pixelInset= new Rect (0,0,Math.Max(Screen.height,Screen.width),Math.Max(Screen.height,Screen.width));
	}
	void OnGUI()
	{
		guiTexture.pixelInset= new Rect (0,0,Math.Max(Screen.height,Screen.width),Math.Max(Screen.height,Screen.width));
	}
}
