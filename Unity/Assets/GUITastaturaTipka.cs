using UnityEngine;
using System.Collections;

public class GUITastaturaTipka : MonoBehaviour {

	SlovoClassa _slovo = null;
	Rect _kocka;
	bool _isButton;

	public void GUIButton ()
	{
		GUI.Button (_kocka, _slovo.Slovo);
	}
	public void GUIBox ()
	{
		GUI.Box (_kocka,_slovo.Slovo);
	}

	public GUITastaturaTipka(char slovo,Rect kocka,bool isButton)
	{
		_slovo = new SlovoClassa (slovo);
		_kocka = kocka;
		_isButton = isButton;
	}
	void OnGui()
	{
		if (_isButton) 
		{
			
		}
	}
}
