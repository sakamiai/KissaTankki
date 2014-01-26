using UnityEngine;
using System.Collections;

public class ValoVipuScript : MonoBehaviour {

	public Light valo;
	public bool state = false;

	Quaternion startRotation;
	
	// Use this for initialization
	void Start () {
		startRotation = transform.rotation;
	}

	void Switch() {
		state = !state;
		if (state) {
			valo.enabled = true;
			transform.rotation = startRotation * Quaternion.Euler(new Vector3(0, 0, 180));

		} else {
			valo.enabled = false;
			transform.rotation = startRotation;
		}
	}

	void OnMouseDown() {
		Switch();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
