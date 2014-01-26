using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

	float timer = 0f;
	float endTime = 10f;

	int nextLevelNumber = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > endTime) {
			Application.LoadLevel(nextLevelNumber);
		}
	}
}
