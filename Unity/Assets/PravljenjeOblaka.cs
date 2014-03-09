using UnityEngine;
using System.Collections;

public class PravljenjeOblaka : MonoBehaviour {

	public GameObject _camera;
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
		
		/*xmax = _camera.camera.ScreenToViewportPoint(new Vector3(0,0,0)).x;
		xmin = _camera.camera.ScreenToViewportPoint(new Vector3(Screen.width,0,0)).x;
		
		ymax = _camera.camera.ScreenToViewportPoint(new Vector3(0,0,0)).y;
		ymin = _camera.camera.ScreenToViewportPoint(new Vector3(0,Screen.height,0)).y;*/
		Debug.Log(Screen.height);
		Debug.Log(Screen.width);
		Debug.Log(_camera.camera.ScreenToWorldPoint(new Vector3(0,0,_camera.camera.nearClipPlane)));
		Debug.Log(_camera.camera.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,_camera.camera.nearClipPlane)));
		Debug.Log(transform.InverseTransformDirection(_camera.camera.ScreenToWorldPoint(new Vector3(0,0,_camera.camera.nearClipPlane))));
		Debug.Log(_camera.camera.ViewportToScreenPoint(new Vector3(0,0,0)));
		Debug.Log(_camera.camera.ViewportToScreenPoint(new Vector3(1,1,0)));
		Debug.Log(_camera.camera.ViewportPointToRay(new Vector3(0,0,0)));
		Debug.Log(_camera.camera.ViewportPointToRay(new Vector3(1,1,0)));
		
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
	}
}
