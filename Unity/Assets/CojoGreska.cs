using UnityEngine;
using System.Collections;

public class CojoGreska : MonoBehaviour {

	public GameObject[] _niz = null;
	
	void Start () 
	{
	
	}
	
	void Update () 
	{
		_niz = GameObject.FindGameObjectsWithTag("Greska");
	}
	
	public void GreskaSlovo()
	{
		Debug.Log("GreskaSlovo");
		if(_niz.Length==0)
		{}
		else
		{	
			int br = Random.Range(0,_niz.Length);
			Debug.Log(br);
			_niz[br].SetActive(false);
		}
	}
}
