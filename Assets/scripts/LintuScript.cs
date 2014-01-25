using UnityEngine;
using System.Collections;

public class LintuScript : MonoBehaviour {
	
	public float damping = 0.5f;
	public float speed = 2f;
	public bool dead = false;
	public float chaseDistance = 50f;

	public Transform target;
	public Transform tankki;

	public float altitude = 0f;

	// Use this for initialization
	void Start () {
		speed = Random.Range(4f, 8f);
		damping = Random.Range(0.3f, 0.4f);
		altitude = Random.Range(-6f, 6f);
		tankki = GameObject.Find("Tankki").transform;
	}

	// Update is called once per frame
	void Update () {
		if (target) {
			Vector3 flytarget = target.position;
			if (dead) {
				flytarget = transform.position;
				flytarget.y = 0f;
				damping = 0.99f;
				speed = 16f;

				RaycastHit hit;
				if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
					float distanceToGround = hit.distance;
					//Debug.Log(distanceToGround);
					if (distanceToGround < 1f) {
						Destroy(gameObject);
					}
				}
			}

			Vector3 directionToTank = tankki.position - transform.position;
			if (!dead && directionToTank.magnitude < chaseDistance) {
				flytarget = tankki.position;
			}

			//Vector3 direction = target.position - transform.position;

			Vector3 alt = new Vector3(0, altitude, 0);

			var rotation = Quaternion.LookRotation ((flytarget + alt) - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);

			//transform.LookAt(target);

			Vector3 move = transform.forward * speed * Time.deltaTime;
			transform.position += move;
		}
	}

	public void Die() {
		dead = true;
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log("asdasdasdasdas");
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		Debug.Log("asdasdsdadas");
	}
}
