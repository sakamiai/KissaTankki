using UnityEngine;
using System.Collections;

public class TankSoundManager : MonoBehaviour {

	public float CoefOfPitch = 0.1f ;
	public float speed ;


	// Use this for initialization
	void Start () {
		this.audio.pitch = 0;
	}
	
	// Update is called once per frame
	void Update () {
		this.audio.pitch = (int)rigidbody.velocity.magnitude * CoefOfPitch;
		speed = rigidbody.velocity.magnitude;
	}
}
