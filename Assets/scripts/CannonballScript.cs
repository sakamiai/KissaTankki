using UnityEngine;
using System.Collections;

public class CannonballScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		UfoScript ufo = collision.gameObject.GetComponent<UfoScript>();
		if (ufo)
			ufo.Explode();

		LintuScript lintu = collision.gameObject.GetComponent<LintuScript>();
		if (lintu)
			lintu.Die ();
	}
}
