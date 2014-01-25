using UnityEngine;
using System.Collections;

public class ThrottleVipuRotate : MonoBehaviour {

	public float CoefOfRotation = 1f;

	// Use this for initialization
	void Start () {

		Throttle.OnValueAdded += HandleOnValueChangedPL;
		Throttle.OnValueDecreased += HandleOnValueChangedMI;	
	}
	
	void OnDisable() {
		Throttle.OnValueAdded -= HandleOnValueChangedPL;
		Throttle.OnValueDecreased -= HandleOnValueChangedMI;	
	}

	void HandleOnValueChangedPL ()
	{
		transform.Rotate(new Vector3(0,-CoefOfRotation,0)) ;
	}

	void HandleOnValueChangedMI ()
	{
		transform.Rotate(new Vector3(0,CoefOfRotation,0)) ;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
