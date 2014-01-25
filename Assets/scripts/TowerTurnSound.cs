using UnityEngine;
using System.Collections;

public class TowerTurnSound : MonoBehaviour {

	private Quaternion oldRotation ;
	public float toPitch = 1f ;

	// Use this for initialization
	void Start () {
		oldRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if(! oldRotation.Equals(transform.rotation))
		{
			oldRotation = transform.rotation ;
			audio.pitch = toPitch ;
		}
		else {

			audio.pitch = 0  ;
		}
	}
}
