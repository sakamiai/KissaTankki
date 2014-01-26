using UnityEngine;
using System.Collections;

public class TankHealth : MonoBehaviour {

	public int health;

	public GameObject piippu;

	public delegate void HealthDicreseAction (int health);
	public static event HealthDicreseAction HealthDicrease;
	public delegate void DestroyedAction ();
	public static event DestroyedAction TankDestroyed ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool IsDestroyed() {
		return health <= 0;
	}

	public void Damage(int amount=1) {
		health -= amount;
		if(HealthDicrease != null)
			HealthDicrease(health);
		if (health <= 0) {
			if(TankDestroyed != null)
				TankDestroyed();
			audio.mute = true;
			piippu.GetComponent<TowerTurn>().enabled = false;
		}
	}
}
