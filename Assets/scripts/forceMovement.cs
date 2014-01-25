using UnityEngine;
using System.Collections;

public class forceMovement : MonoBehaviour {

	public Transform left;
	public Transform right;
	public Transform front;

	public float speed = 30f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = (front.position - transform.position).normalized;

		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			rigidbody.AddForceAtPosition(dir * speed, left.position);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			rigidbody.AddForceAtPosition(dir * speed, right.position);
		}
	}
}
