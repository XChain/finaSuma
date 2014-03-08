using UnityEngine;
using System.Collections;

public class GUITastatura : MonoBehaviour 
{
	//public GameObject _scriptGUIRijec;
	
	public int _paddingIvica = 50;
	public int _sirinaTastature = 10;
	public int _odnosNazivnik = 5;
	public int _odnosBrojnik = 4;
	public string _abeceda="abcdefghijklmnopqrstuvyxyz";
	
	private string[] _tString = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","y","x","w","z"};
	
	private void UnosSlovo(int broj)
	{
		if(_tString[broj]!=" ")
		{
			Debug.Log(_tString[broj]);
			Debug.Log(name);
			
			GUIRijec a = (GUIRijec)(GameObject.Find(name).GetComponent("GUIRijec"));
			a.NadjiSlovo(_tString[broj]);
			_tString[broj]=" ";
		}
	}
	
	void OnGUI()
	{
		int sT = 0;		
		sT = GUI.SelectionGrid(
			new Rect(_paddingIvica,
			_odnosBrojnik *Screen.height/_odnosNazivnik -_paddingIvica,Screen.width-2*_paddingIvica,
			Screen.height/_odnosNazivnik),sT,_tString,_sirinaTastature);
		
		if(GUI.changed)
		{
			UnosSlovo(sT);
		}
		
	}
}
