using UnityEngine;
using System.Collections;

public class Leti : MonoBehaviour {

	public Vector3 granica;
	public GameObject temp;

	void Start()
	{

	}

	void LateUpdate () 
	{
		temp.guiText.text = transform.position.ToString ();

		if (transform.position.Equals(granica))
			transform.Translate(-granica*2);
		else
			transform.Translate (new Vector2 (1, 0) * Time.deltaTime);
	}
}
