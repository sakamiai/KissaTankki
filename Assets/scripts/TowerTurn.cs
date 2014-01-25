using UnityEngine;
using System.Collections;

public class TowerTurn : MonoBehaviour {

	public float turnSpeed = 0.7f;

	public float vertical = 0f;
	public float horizontal = 0f;

	public float maxHorizontal = 45f;
	public float minHorizontal = -20f;

	public TankHealth condition;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.PageUp)) {
			//transform.RotateAround(transform.position, transform.up, turnSpeed);
			vertical += turnSpeed;
		}
		if (Input.GetKey(KeyCode.PageDown)) {
			//transform.RotateAround(transform.position, transform.up, -turnSpeed);
			vertical -= turnSpeed;
		}

		if (Input.GetKey(KeyCode.Home) && horizontal < maxHorizontal) {
			//transform.RotateAround(transform.position, transform.forward, turnSpeed);
			horizontal += turnSpeed;
		}
		if (Input.GetKey(KeyCode.End) && horizontal > minHorizontal) {
			//transform.RotateAround(transform.position, transform.forward, -turnSpeed);
			horizontal -= turnSpeed;
		}

		transform.rotation = transform.parent.rotation;
		transform.RotateAround(transform.position, Vector3.forward, horizontal);
		transform.RotateAround(transform.position, Vector3.up, vertical);

	}
}
