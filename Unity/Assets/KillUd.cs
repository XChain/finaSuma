using UnityEngine;
using System.Collections;

public class KillUd : MonoBehaviour {

	public GameObject _partner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDestroy()
	{
		Debug.Log("OnDestroy");
		tag = "Untagged";
		_partner.tag = "Greska";
	}
	
	void OnDisable()
	{
		Debug.Log("OnDisable");
		tag = "Untagged";
		_partner.tag = "Greska";
	}
}
