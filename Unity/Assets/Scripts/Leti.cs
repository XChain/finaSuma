using UnityEngine;
using System.Collections;

public class Leti : MonoBehaviour {

	void Update () 
	{
		transform.Translate (new Vector2 (1, 0) * Time.deltaTime);
	}
}
