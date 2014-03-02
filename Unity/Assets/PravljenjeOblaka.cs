using UnityEngine;
using System.Collections;

public class PravljenjeOblaka : MonoBehaviour {

	int brOblaka;
	public float spawnRate;
	public int maxbrOblaka;
	public Rigidbody2D oblakPrefab;

	public float xmin;
	public float xmax;

	public float ymin;
	public float ymax;

	public float brzinaX;
	public float brzinaY;
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnOblak", 1, spawnRate);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void SpawnOblak()
	{
		float x = Random.Range (xmin,xmax);
		float y = Random.Range (ymin,ymax);
		Rigidbody2D oblak;
		oblak = Instantiate (oblakPrefab, new Vector3(x,y,0),Quaternion.identity) as Rigidbody2D;
		oblak.transform.localScale =new Vector3 (Random.Range (1f, 2f), Random.Range (1f, 2f),0);
		//oblak.AddForce (new Vector2 (brzinaX, brzinaY));
	}
}
