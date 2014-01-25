using UnityEngine;
using System.Collections;

public class CannonScript : MonoBehaviour {

	public GameObject cannonball;
	public Transform shootPosition;
	public float power = 10000f;
	public bool canShoot = false ;

	// Use this for initialization
	void Start () {
		dragdropscript.ReloadDone += ShootAble ;
	}
	
	void OnDisable() {
		dragdropscript.ReloadDone -= ShootAble ;
	}

	public void ShootAble() {
		canShoot = true ;
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && canShoot) {
			canShoot = false ;
			audio.Play();
			GameObject ball = (GameObject)Instantiate(cannonball, shootPosition.position, Quaternion.identity);
			ball.rigidbody.AddForce(transform.up * power);

		}
	}
}
