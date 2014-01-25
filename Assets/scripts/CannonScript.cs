using UnityEngine;
using System.Collections;

public class CannonScript : MonoBehaviour {

	public GameObject cannonball;
	public Transform shootPosition;
	public float power = 10000f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject ball = (GameObject)Instantiate(cannonball, shootPosition.position, Quaternion.identity);
			ball.rigidbody.AddForce(transform.up * power);

		}
	}
}
