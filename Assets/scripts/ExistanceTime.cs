using UnityEngine;
using System.Collections;

public class ExistanceTime : MonoBehaviour {
	private float lifeTime = 0f ;
	public float maxLifeTime = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime += Time.deltaTime ;
		if(lifeTime >= maxLifeTime)
			Destroy(gameObject);
	}
}
