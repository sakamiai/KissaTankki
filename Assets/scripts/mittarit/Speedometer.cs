using UnityEngine;
using System.Collections;

public class Speedometer : MonoBehaviour {

	private Rigidbody tankki ;
	public float SpeedCoef = 1f ;

	// Use this for initialization
	void Start () {
		tankki = GameObject.Find("Tankki").rigidbody;
	}
	
	// Update is called once per frame
	void Update () {
		float speed = tankki.velocity.magnitude;



		transform.rotation = Quaternion.Slerp(transform.rotation,  Quaternion.Euler(0,0,Mathf.Abs(speed) *SpeedCoef),10f);
	}
}
