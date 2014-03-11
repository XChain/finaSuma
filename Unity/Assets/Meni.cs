using UnityEngine;
using System.Collections;

public class Meni : MonoBehaviour {

	// Use this for initialization
	public string[] _meniOpcije = {"Start","Score","Settings"};
	public GameObject _Igra;
	public GameObject _tastatura;
	public int _relativeX = 18;
	public int _relativeY = 36;
	public GUIStyle _style;
	public GUISkin _skin;	
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
	}
	
	void _Meni()
	{
		GUILayoutOption[] opcije = 
		{GUILayout.ExpandHeight(true),};
		GUILayout.BeginArea(new Rect(3*Screen.width/_relativeX,
		                             (_relativeY-25)*Screen.height/_relativeY,
		                             12*Screen.width/_relativeX,
		                             16*Screen.height/_relativeY));
			GUILayout.BeginVertical();
				int _odabir = -1;
				_odabir = GUILayout.SelectionGrid(_odabir,_meniOpcije,1,opcije);
				if(GUI.changed)
				{
					if(_meniOpcije[_odabir]=="Start")
						StartOpcija();
					if(_meniOpcije[_odabir]=="Score")
						ScoreOpcija();
					if(_meniOpcije[_odabir]=="Settings")
						SettingsOpcija();
				}
			
			GUILayout.EndVertical();
		GUILayout.EndArea();
	}
	
	void OnGUI()
	{
		GUI.skin = _skin;
		_style = GUI.skin.GetStyle("button");
		_style.fontSize = (14/4)*Screen.height/_relativeY;
		_Meni();
	}
	
	void ScoreOpcija()
	{
		
	}
	
	void StartOpcija()
	{
		_Igra.SetActive(true);
		gameObject.SetActive(false);
		//GUIRijec b = (GUIRijec)(GameObject.Find (name).GetComponent("GUIRijec"));
		GUIControle a = (GUIControle) (_tastatura.gameObject.GetComponent("GUIControle"));
		a._pauza = false;
		a.pausa();
	}
	
	void SettingsOpcija()
	{
			
	
	}
	
}
