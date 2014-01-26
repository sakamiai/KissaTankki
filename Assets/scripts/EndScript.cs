using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {

	public Texture2D[] tarinaKuvat;
	public string[] tarinaTekstit;
	
	public int story = -1;
	public GUIStyle style;
	
	// Use this for initialization
	void Start () {
		story = 0;
		
		tarinaTekstit = new string[2];
		tarinaTekstit [0] = "Ja niin päättyy suurten seikkailijoiden Arpinaaman ja hänen\n\n\n uskollisen kumppaninsa Pikipöksyn hurja seikkailu.\n\n\nMutta uusi vaara on edessä!";
		tarinaTekstit [1] = "\"Lapset! Syömään!\"";
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return)) {
			story++;
		}
	}
	
	// Update is called once per frame
	void OnGUI() {
		if (story < tarinaKuvat.Length) {
			GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), tarinaKuvat[story], ScaleMode.StretchToFill);
			GUI.Label(new Rect(50, Screen.height - 150, Screen.width - 50, 150), tarinaTekstit[story], style);
		} else {
			Application.LoadLevel(0);
		}
	}
}
