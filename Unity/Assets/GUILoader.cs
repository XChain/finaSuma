using UnityEngine;
using System.Collections;

public class GUILoader : MonoBehaviour {

	public string rijec;

	void OnGUI () {
		// Make a background box
		//GUI.Box(new Rect(10,10,20,20), "M");
		//GUI.Box(new Rect(30,10,20,20), "M");
		//GUI.Box(new Rect(10,30,100,100), "A");
		UGUI ();
		
	}

	void UGUI()
	{
		for (int i = 0; i<rijec.Length; i++) 
		{
			GUI.Box (new Rect(10+20*i,10,20,20),rijec[i].ToString());		
		}
	}
}
