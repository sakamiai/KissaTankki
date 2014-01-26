using UnityEngine;
using System.Collections;

public class AvainScript : MonoBehaviour {

	public bool motorOn = false;

	bool keyTurned = false;
	float motorState = 0f;
	
	Quaternion startRotation;
	
	// Use this for initialization
	void Start () {
		startRotation = transform.rotation;
	}
	
	void OnMouseDown() {
		if (!motorOn) {
			transform.rotation = startRotation * Quaternion.Euler (new Vector3 (0, 0, 150));
			audio.Play ();
			keyTurned = true;
		}
	}

	void OnMouseUp() {
		transform.rotation = startRotation;
		audio.Stop();
		keyTurned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (keyTurned) {
			motorState += Time.deltaTime;

			if (motorState > 10f) {
				motorOn = true;
				OnMouseUp();
			}
		}
	}
}
