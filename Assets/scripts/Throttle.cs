using UnityEngine;
using System.Collections;

public class Throttle : MonoBehaviour {

	public float throttle = 0 ;
	public float interval = 0.01f ;
	public float max = 1f;

	// Use this for initialization
	void Start () {
	
	}

	public delegate void ThrottleChangeAction (float value);
	public delegate void ThrottleChangeA ();
	public static event ThrottleChangeAction OnValueChanged ;
	public static event ThrottleChangeA OnValueAdded ;
	public static event ThrottleChangeA OnValueDecreased ;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			if( (throttle + interval) <= max)
			{
				throttle += interval ;
				if(OnValueChanged != null)
				OnValueChanged(throttle);
				if(OnValueAdded != null)
					OnValueAdded();
			}
		}
		
		if (Input.GetKey(KeyCode.DownArrow)) {
			if((throttle + interval) >= -max)
			{
				throttle-=interval;
				if(OnValueChanged != null)
				OnValueChanged(throttle);
				if(OnValueDecreased!= null)
					OnValueDecreased();
			}
		}
	}
}
