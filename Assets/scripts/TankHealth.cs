using UnityEngine;
using System.Collections;

public class TankHealth : MonoBehaviour {

	public int health;

	public GameObject piippu;

	// Use this for initialization
	void Start () {
		health = 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool IsDestroyed() {
		return health <= 0;
	}

	public void Damage(int amount=1) {
		health -= amount;

		if (health <= 0) {
			audio.mute = true;
			piippu.GetComponent<TowerTurn>().enabled = false;
		}
	}
}
