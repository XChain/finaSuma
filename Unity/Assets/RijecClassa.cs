using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RijecClassa : MonoBehaviour
{
	List<SlovoClassa>_niz = new List<SlovoClassa>();

	public RijecClassa(string rijec, bool vidiSe)
	{
		for (int i=0; i<rijec.Length; i++) 
		{
			_niz.Add(new SlovoClassa(rijec[i],vidiSe));		
		}
	}

	public RijecClassa(string rijec)
	{
		for (int i=0; i<rijec.Length; i++) 
		{
			_niz.Add(new SlovoClassa(rijec[i]));		
		}
	}
	
	public SlovoClassa this[int index]
	{
		get { return _niz[index]; }
		set { _niz[index] = value;}
	}

	public int Duzina
	{
		get { return _niz.Count;}
	}

	public bool VidiSeSve
	{
		set { for(int i=0;i<_niz.Count;i++) _niz[i].VidiSe = value; }
	}

	public bool VidiSeSlovo(string a)
	{
		bool vidiSe = false;
		for (int i=0; i<_niz.Count; i++)
			if (_niz [i].Equals (a)) 
			{
				_niz [i].VidiSe = true;
				vidiSe = true;
			}
		return vidiSe;
	}

}
