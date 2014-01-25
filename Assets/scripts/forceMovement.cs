using UnityEngine;
using System.Collections;

public class forceMovement : MonoBehaviour {

	public Transform left;
	public Transform right;
	public Transform front;

	public float speed = 30f;
	private float throttleSpeed ;


	// Use this for initialization
	void Start () {
		throttleSpeed = 0f;
		Throttle.OnValueChanged += HandleOnValueChanged;
	}

	void OnDisable() {
		Throttle.OnValueChanged -= HandleOnValueChanged;
	}

	void HandleOnValueChanged (float value)
	{
		throttleSpeed = value ;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = (front.position - transform.position).normalized;

		if (Input.GetKey(KeyCode.LeftArrow)) {

			rigidbody.AddForceAtPosition(dir * speed * throttleSpeed, left.position);
		}

		if (Input.GetKey(KeyCode.RightArrow)) {
			rigidbody.AddForceAtPosition(dir * speed * throttleSpeed, right.position);
		}
	}
}
