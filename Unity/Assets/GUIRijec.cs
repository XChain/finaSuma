using UnityEngine;
using System.Collections;

public class GUIRijec : MonoBehaviour {

	public string _rijec;
	public int _paddingIvica = 50;
	public int _sirinaTastature = 10;
	public int _odnosNazivnikVisina = 15;
	public int _odnosBrojnikVisina = 4;
	
	private string[] _prikazSlova = null;
	
	void StrUNiz()
	{
		for(int i=0;i<_rijec.Length;i++)
			_prikazSlova[i] =" ";
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
	
	void Start()
	{
		//_slova = new string[_rijec.Length];
		_prikazSlova = new string[_rijec.Length];
		_rijec=_rijec.ToUpper();
		Debug.Log(_rijec);
	}
	
	void OnGUI()
	{
		int sT = 0;		
		sT = GUI.SelectionGrid(
			new Rect(_paddingIvica,
		         _odnosBrojnikVisina *Screen.height/_odnosNazivnikVisina -_paddingIvica,
		         Screen.width-2*_paddingIvica,
		         Screen.height/_odnosNazivnikVisina),sT,_prikazSlova,_sirinaTastature);
	}
}
