using UnityEngine;
using System.Collections;

public class PozSameAs : MonoBehaviour {

	public Camera _main;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position=_main.transform.position;
	}
}
