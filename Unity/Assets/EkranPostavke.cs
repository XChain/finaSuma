using UnityEngine;
using System.Collections;

public class EkranPostavke : MonoBehaviour {

	void Start () 
	{
		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = true;
		Screen.autorotateToPortrait = true;
		Screen.autorotateToPortraitUpsideDown = true;
		Screen.orientation = ScreenOrientation.AutoRotation;
	}
	void Update () 
	{
		
	}
}
