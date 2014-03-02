using UnityEngine;
using System.Collections;

public class UnistiNakon : MonoBehaviour {

	public float vrijeme;

	public float Vrijeme
	{
		get
		{
			return vrijeme;
		}
		set
		{
			vrijeme=value;
		}

	}

	void Start () 
	{
		Destroy (gameObject, Vrijeme);
	}

	void OnDestory()
	{

	}
	// Update is called once per frame
	void Update () {
	
	}
}
