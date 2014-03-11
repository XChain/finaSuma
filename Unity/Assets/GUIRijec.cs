using UnityEngine;
using System.Collections;

public class GUIRijec : MonoBehaviour {

	public GUISkin _skin;
	public GUIStyle _style;
	public string _rijec;
	public int _paddingIvica = 50;
	public int _sirinaTastature = 10;
	public int _odnosNazivnikVisina = 15;
	public int _odnosBrojnikVisina = 4;
	public int _maxWordHeight = 50;
	
	public int _relativeX;
	public int _relativeY;
	
	public bool _pauza = false;
	
	private string[] _prikazSlova = null;
	private string[] _pauzaSLova = null;
	
	void StrUNiz()
	{
		for(int i=0;i<_rijec.Length;i++)
			_prikazSlova[i] =" ";
		_pauzaSLova = _prikazSlova;
	}
	
	public bool NadjiSlovo(string a)
	{
		Debug.Log(a);
		bool najdeno = false;
		
		for(int i=0;i<_rijec.Length;i++)
		{
			if(_rijec[i].ToString()==a.ToUpper())
			{
				najdeno = true;
				_prikazSlova[i]=_rijec[i].ToString();
			}
		}
		
		
		return najdeno;
	}
	
	int AutoLayout(int sT)
	{
		GUILayoutOption[] opcije={GUILayout.ExpandWidth(true),
			GUILayout.ExpandHeight(true),
			GUILayout.MaxWidth( Screen.width ),
			GUILayout.MaxHeight( _maxWordHeight*2 ),
			GUILayout.MinWidth( 4*_maxWordHeight/5 )
			/*GUILayout.MinHeight( _maxWordHeight ) */
			};
		GUILayout.BeginArea(new Rect(_paddingIvica,3*Screen.height/5,Screen.width-2*_paddingIvica, Screen.height ));
		
		GUILayout.BeginHorizontal();
		if(!_pauza)
		sT = GUILayout.SelectionGrid(sT,
								_prikazSlova,
								_sirinaTastature,_style,opcije);
		GUILayout.EndHorizontal();
		
		GUILayout.EndArea();
		return sT;
	}
	
	void OnApplicationPause(bool stanje)
	{
		_pauza = stanje;
	}
	
	void Start()
	{
		_pauza = false;
		//_slova = new string[_rijec.Length];
		_prikazSlova = new string[_rijec.Length];
		_pauzaSLova = new string[_rijec.Length]; 
		_rijec=_rijec.ToUpper();
		Debug.Log(_rijec);
		//Debug.Log(Screen.currentResolution.height+Screen.currentResolution.width);
		
	}
	
	void Layout918()
	{
		if(OdnosRezolucija()<1)
			_sirinaTastature = 9;
		else _sirinaTastature = 13;
		
		GUILayoutOption[] opcije = 
		{GUILayout.ExpandHeight(true),
		/*GUILayout.MinHeight(Screen.height/_relativeY),*/};
		
		GUILayout.BeginArea(new Rect(Screen.width/_relativeX,
		                             (_relativeY-18)*Screen.height/_relativeY,
		                             (16)*Screen.width/_relativeX,
		                             ( _rijec.Length>_sirinaTastature?4:2 )*Screen.height/_relativeY));
		GUILayout.BeginHorizontal();
			int odabit = -1;
		
			odabit = GUILayout.SelectionGrid(odabit,_prikazSlova,_sirinaTastature,_style,opcije);
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
	
	void OnGUI()
	{
		GUI.skin = _skin;
		_style = GUI.skin.GetStyle("box");
		_style.fontSize = Screen.height/_relativeY+2;
		if(!_pauza)
			Layout918();
	}
	
	float OdnosRezolucija()
	{
		return Screen.width/Screen.height;
	}	
}
