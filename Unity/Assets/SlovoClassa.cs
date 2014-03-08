using UnityEngine;
using System.Collections;
using System;

public class SlovoClassa : IEquatable<string>{

	string _slovo;
	bool _vidiSe;
	const string _prazno = " ";

	public SlovoClassa(char slovo,bool vidiSe)
	{
		_slovo = slovo.ToString();
		_slovo.ToUpper ();
		_vidiSe = vidiSe;
	}

	public SlovoClassa(char slovo)
	{
		_slovo = slovo.ToString();
		_slovo.ToUpper ();
		_vidiSe = false;
	}

	public string Slovo
	{
		get { return (_vidiSe ? _slovo:_prazno); }
	}

	public bool VidiSe
	{
		get { return _vidiSe; }
		set { _vidiSe = value; }
	}
	public bool Equals(string other) 
	{
		if (other == null) 
			return false;
		
		if (_slovo == other)
			return true;
		else 
			return false;
	}
}
