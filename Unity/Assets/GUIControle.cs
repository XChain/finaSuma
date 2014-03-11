using UnityEngine;
using System.Collections;

public class GUIControle : MonoBehaviour {

	public string[] _opcije = {"Pause","Next Word"};
	//public Animator.anim
	public GameObject _cojo;
	public GUIStyle _style;
	public string _test;
	public GUISkin _skin;
	public bool _pauza = false;
	public int _sirinaTastature = 10;
	
	public int _relativeX = 18;
	public int _relativeY = 36;
	
	public bool _hintIma = false;
	public string _hint = null;
	private bool _IzlazPitanje = false;
	
	void Start()
	{
		_pauza = false;
		_hint = "Vulkan";
		Time.timeScale = 1;
	}
	
	bool exitGame()
	{
		GUILayoutOption[] opcije = 
		{GUILayout.ExpandHeight(true),};
		GUILayout.BeginArea(new Rect(3*Screen.width/_relativeX,
		                             (_relativeY-25)*Screen.height/_relativeY,
		                             12*Screen.width/_relativeX,
		                             16*Screen.height/_relativeY));
		GUILayout.Box("");
		GUILayout.BeginVertical();
			GUILayout.Label ("izlaz?");
		GUILayout.EndVertical();
		GUILayout.EndArea();
		return true;
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{	
			Application.Quit();
			//if()
		}
	}
	
	void OpcijeControle()
	{
		GUILayoutOption[] opcije = 
		{GUILayout.ExpandHeight(true),};
		
		GUILayout.BeginArea( new Rect (Screen.width/_relativeX,
									Screen.height-3*(Screen.height/_relativeY),
									16*Screen.width/_relativeX,
									2*Screen.height/_relativeY
										));
			GUILayout.BeginHorizontal();
				int t=-1;
				t = GUILayout.SelectionGrid(t,_opcije,_opcije.Length,opcije);
				if(GUI.changed)
				{
					if(_opcije[t]=="Pause"||_opcije[t]=="Continue")
					{
						pausa();
					}else 
					if(_opcije[t]=="Hint")
					{
						_hintIma = !_hintIma;						
					}
				}
			GUILayout.EndHorizontal();
			
		GUILayout.EndArea();
	}
	
	void GUIHint()
	{
		GUILayoutOption[] opcije = 
		{GUILayout.ExpandHeight(true),
		GUILayout.ExpandWidth(true)};
		GUILayout.BeginArea(( new Rect (Screen.width/_relativeX,
		                                Screen.height/_relativeY,
		                                16*Screen.width/_relativeX,
		                                2*Screen.height/_relativeY
		                                )));
			GUILayout.BeginHorizontal();
				GUILayout.TextArea(_hint,opcije);
			GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
	
	public void pausa()
	{
		GUITastatura a = (GUITastatura)(GameObject.Find(name).GetComponent("GUITastatura"));
		GUIRijec b = (GUIRijec)(GameObject.Find (name).GetComponent("GUIRijec"));
		if(_pauza==true)
		{
			Time.timeScale = 1;
			_pauza = false;
		}
		else
		{
			Time.timeScale = 0;
			_pauza = true;
			//GUIRijec a = (GUIRijec)(GameObject.Find(name).GetComponent("GUIRijec"));
		}
		a._pauza = _pauza;
		b._pauza = _pauza;
	}
	void OnApplicationPause(bool stanje)
	{
		_pauza = stanje;
		pausa();
	}
	void OnGUI()
	{
		GUI.skin = _skin;
		_style = GUI.skin.GetStyle("button");
		_style.fontSize = Screen.height/_relativeY;
		if(!_pauza) 
			_opcije[0]="Pause";
		else _opcije[0]="Continue";
		if(_hintIma&!_pauza)
			GUIHint();
		OpcijeControle();
		//exitGame();
	}
}
