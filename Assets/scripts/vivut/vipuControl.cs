using UnityEngine;
using System.Collections;

public class vipuControl : MonoBehaviour {

	public Transform InitialRotation ;
	private Quaternion EndRotation ;
	public Transform EndRotationTransform;
	public KeyCode keycode ;
	public float speed  = 100f;

	// Use this for initialization
	void Start () {

		EndRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(keycode)) {
			EndRotation = EndRotationTransform.rotation ;

		}
		else EndRotation = InitialRotation.rotation ;


		transform.rotation = Quaternion.Slerp(transform.rotation,EndRotation,speed * Time.deltaTime);
	}
}
