using UnityEngine;
using System.Collections;

public class ValoVipuScript : MonoBehaviour {

	public Light valo;
	public bool state = false;
	
	// Use this for initialization
	void Start () {
	}

	void Switch() {
		state = !state;
		if (state) {
			valo.enabled = true;
			transform.localRotation
		} else {
			valo.enabled = false;
		}
	}

	void OnMouseDown() {
		Switch();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
