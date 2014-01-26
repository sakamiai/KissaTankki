using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	public float speed = 1f;
	public bool activated = false ;
	// Use this for initialization
	void Start () {
		GetComponent<Light>().enabled = false ;
		TankHealth.TankDestroyed += Activated ;
	}
	
	void OnDisable() {
		TankHealth.TankDestroyed -= Activated ;
	}

	void Activated() {
		activated = true ;
	}


	// Update is called once per frame
	void Update () {
		if(activated)
		{
			GetComponent<Light>().enabled = true ;
			transform.Rotate(Vector3.up, speed * Time.deltaTime);
		}
	}
}
