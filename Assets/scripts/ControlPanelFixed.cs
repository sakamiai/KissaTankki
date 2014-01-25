using UnityEngine;
using System.Collections;

public class ControlPanelFixed : MonoBehaviour {

	public float Y ;


	// Use this for initialization
	void Start () {
		Y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,Y,transform.position.z) ;
	}
}
