using UnityEngine;
using System.Collections;

public class Speedometer : MonoBehaviour {


	public Transform init ;
	public float speed = 1f ;
	private Rigidbody tankki ;
	public float SpeedCoef = 1f ;

	// Use this for initialization
	void Start () {

		tankki = GameObject.Find("Tankki").rigidbody;
	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.Lerp(transform.rotation, init.rotation * Quaternion.Euler(0,0,Mathf.Abs(tankki.velocity.magnitude) *SpeedCoef),speed);
	}
}
