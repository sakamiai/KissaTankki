using UnityEngine;
using System.Collections;

public class BulletAnimation : MonoBehaviour {

	public bool animate = false;
	public float animationSpeed = 50f;
	public float state = 0f;
	public float endState = -40f;
	public float startState = -30f;

	// Use this for initialization
	void Start () {
		state = startState;
		dragdropscript.ReloadDone += Animate ;
	}

	void OnDisable() {
		dragdropscript.ReloadDone -= Animate ;
	}
	
	// Update is called once per frame
	void Update () {
		if (animate) {
			state -= Time.deltaTime * animationSpeed;
			if (state <= endState) {
				state = startState;
				animate = false;
			}
		}

		transform.rotation = transform.parent.rotation;
		transform.RotateAround(transform.position, transform.forward, state);
	}

	public void Animate() {
		animate = true;
		state = startState;
		audio.Play();
	}
}
