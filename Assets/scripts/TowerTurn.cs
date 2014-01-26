using UnityEngine;
using System.Collections;

public class TowerTurn : MonoBehaviour {

	public float turnSpeed = 0.7f;


	//public float vertical = 0f;
	//public float horizontal = 0f;

	public float rotation;

	public float maxRotation = 45f;
	public float minRotation = -20f;
	public bool limits = false;

	public KeyCode positive;
	public KeyCode negative;

	public int horizontal = 0;
	public int vertical = 0;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetKey(left)) {
			//transform.Rotate(transform.position, transform.up, turnSpeed);
		//	vertical += turnSpeed;
		//}
		//if (Input.GetKey(right)) {
			//transform.RotateAround(transform.position, transform.up, -turnSpeed);
		//	vertical -= turnSpeed;
		//}

		if (Input.GetKey(positive) && (rotation < maxRotation || !limits)) {
			//transform.RotateAround(transform.position, transform.forward, turnSpeed);
			rotation += turnSpeed;
		}
		if (Input.GetKey(negative) && (rotation > minRotation || !limits)) {
			//transform.RotateAround(transform.position, transform.forward, -turnSpeed);
			rotation -= turnSpeed;
		}

		if(limits){
			if((transform.localRotation * Quaternion.Euler(new Vector3(0, 0, vertical * rotation))).eulerAngles.z > maxRotation)
			transform.localRotation = transform.localRotation * Quaternion.Euler(new Vector3(0, 0, vertical * rotation));
			rotation = 0 ;
		}
		else {
			transform.rotation = transform.parent.rotation * Quaternion.Euler(new Vector3(0, horizontal * rotation, 0));
		}
		//		transform.Rotate(Vector3.forward, horizontal);
//		transform.Rotate(Vector3.up, vertical);

		//transform.RotateAround(transform.position, Vector3.forward, horizontal);
		//transform.RotateAround(transform.position, Vector3.up, vertical);

	}
}
