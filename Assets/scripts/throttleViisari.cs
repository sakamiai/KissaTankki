using UnityEngine;
using System.Collections;

public class throttleViisari : MonoBehaviour {
	
	public float SpeedCoef = 1f ;
	


	// Use this for initialization
	void Start () {
		Throttle.OnValueChanged += HandleOnValueChanged;
		

	}
	
	void OnDisable() {
		Throttle.OnValueChanged -= HandleOnValueChanged;
	}
	
	void HandleOnValueChanged (float value)
	{
		transform.RotateAround(transform.position,transform.up, value * SpeedCoef);
	}
	
	// Update is called once per frame

}
