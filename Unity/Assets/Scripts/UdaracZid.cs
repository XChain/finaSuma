using UnityEngine;
using System.Collections;

public class UdaracZid : MonoBehaviour {

	public Vector2 pozZida;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void LateUpdate()
	{
		transform.position = pozZida;
	}
}
//transform.position = new Vector3(0, 0, 0);
