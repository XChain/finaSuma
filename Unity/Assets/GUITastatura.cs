using UnityEngine;
using System.Collections;

public class GUITastatura : MonoBehaviour 
{
	//public GameObject _scriptGUIRijec;
	public GUIStyle _style;
	public string _test;
	public GUISkin _skin;
	public int _sirinaTastature = 10;
	
	public int _relativeX;
	public int _relativeY;
	
	public bool _pauza = false;
	
	private string[] _tString = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","y","x","w","z"};
	
	void Start()
	{
		_pauza = false;
	}
	
	private void UnosSlovo(int broj)
	{
		if(!_pauza && _tString[broj]!=" ")
		{
			Debug.Log(_tString[broj]);
			Debug.Log(name);
			
			GUIRijec a = (GUIRijec)(GameObject.Find(name).GetComponent("GUIRijec"));
			if(a.NadjiSlovo(_tString[broj]))
				_tString[broj]=" ";
			else
			{
				CojoGreska b = (CojoGreska)(GameObject.Find("Cojo").GetComponent("CojoGreska"));
				b.GreskaSlovo();
				_tString[broj]=" ";
			}
			
		}
	}

	void Layout918()
	{
		if(OdnosRezolucija()<1)
			_sirinaTastature = 9;
		else _sirinaTastature = 13;
		
		GUILayoutOption[] opcije = 
			{GUILayout.ExpandHeight(true),};
		GUILayout.BeginArea(new Rect(Screen.width/_relativeX,
		                             (_relativeY-12)*Screen.height/_relativeY,
									(16)*Screen.width/_relativeX,
									(8)*Screen.height/_relativeY));
			GUILayout.BeginHorizontal();
				int odabit = -1;
				odabit = GUILayout.SelectionGrid(odabit,_tString,_sirinaTastature,opcije);
				if(GUI.changed)
					UnosSlovo(odabit);
			GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
	void OnGUI()
	{
		GUI.skin = _skin;
		_style = GUI.skin.GetStyle("button");
		_style.fontSize = Screen.height/_relativeY+2;
		if(!_pauza) 
			Layout918();		
	}
	void OnApplicationPause(bool stanje)
	{
		_pauza = stanje;
		//pausa();
	}
	float OdnosRezolucija()
	{
		return Screen.width/Screen.height;
	}	
}
