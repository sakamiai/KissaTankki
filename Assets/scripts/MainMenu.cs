using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture2D bgTex;
	public Texture2D ukko;

	public float ukkoPos = 0f;
	public float ukkoTarget = 0f;
	public float ukkoSize = 400f;

	// Use this for initialization
	void Start () {
		ukkoSize = Screen.height / 3 * 2;
		ukkoTarget = Screen.height - ukkoSize;
		ukkoPos = Screen.height;
	}

	void Update() {
		ukkoPos += (ukkoTarget - ukkoPos) * 2f * Time.deltaTime;
	}
	
	// Update is called once per frame
	void OnGUI() {
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), bgTex, ScaleMode.StretchToFill);		
		GUI.DrawTexture (new Rect (Screen.width / 2, (int)ukkoPos, ukkoSize, ukkoSize), ukko, ScaleMode.ScaleToFit);

		if (GUI.Button (new Rect (50, 100, 300, 100), "START")) {
			//Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (50, 250, 300, 100), "HELP")) {
		}

		if (GUI.Button (new Rect (50, 400, 300, 100), "QUIT")) {
			Application.Quit();
		}
	}
}
