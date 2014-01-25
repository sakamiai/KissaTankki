using UnityEngine;
using System.Collections;

public class UfoScript : MonoBehaviour {

	public Transform tankki;
	public float speed = 2f;
	public bool dead = false;

	public bool chase = false;
	public float chaseRange = 10f;

	public GameObject burst;

	CharacterController control;
	Animator anim;

	// Use this for initialization
	void Start () {
		control = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
		tankki = GameObject.Find("Tankki").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = tankki.position - transform.position;
		if (direction.magnitude < chaseRange || chase) {
			chase = true;
			control.Move (direction.normalized * speed * Time.deltaTime);
			anim.SetFloat("Speed", 1f);
		} else {
			anim.SetFloat("Speed", 0f);
		}

		control.Move(Vector3.down * 2f * Time.deltaTime);
		transform.LookAt (tankki);
	}

	public void Explode() {
		if (!dead) {
			dead = true;
			GameObject b = (GameObject)Instantiate (burst, transform.position, Quaternion.identity);
			b.transform.LookAt (b.transform.position + Vector3.up);
			Destroy (gameObject);
		}
	}

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.gameObject.tag == "Tank") {
			Explode();
		}
	}
}
