using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture2D bgTex;
	public Texture2D ukko;
	public Texture2D ukko2;

	public Texture2D startTex;
	public Texture2D helpTex;
	public Texture2D exitTex;
	
	public Texture2D[] tarinaKuvat;
	public string[] tarinaTekstit;

	public int story = -1;
	public GUIStyle style;
	
	public float ukkoPos = 0f;
	public float ukkoPos2 = 0f;
	public float ukkoTarget = 0f;
	public float ukkoSize = 400f;

	// Use this for initialization
	void Start () {
		story = -1;
		ukkoSize = Screen.height / 3 * 2;
		ukkoTarget = Screen.height - ukkoSize;
		ukkoPos = Screen.height;
		ukkoPos2 = Screen.height;

		tarinaTekstit = new string[6];
		tarinaTekstit [0] = "On vuosi 5001. Suuri soturi Arpinaama ja hänen uskollinen kumppaninsa\n\n\n Pikipöksy ovat lähdössä hurjalle seikkailulle kauas Kuuhun ja sen ohi.";
		tarinaTekstit [1] = "Heillä on edessään pitkä ja vaarallinen matka, mutta uskollisella\n\n\n avaruusaluksellaan he pääsevät mihin vain!";
		tarinaTekstit [2] = "Lopulta Arpinaama ja Pikipöksy jättävät taakseen Maan ja suuntaavat\n\n\n nokkansa kohti avaruutta.";
		tarinaTekstit [3] = "Heidän uskollinen aluksensa vie heidät aina Kuun luokse ja vielä siitäkin\n\n\n eteenpäin.";
		tarinaTekstit [4] = "Niin kauas he kulkevat, että he näkevät punaisen Marsin ja sen valtavat\n\n\n vuoret, jotka puhkovat pilviä avaruuteen asti.";
		tarinaTekstit [5] = "Marsin pinnalle laskeutuvat he, suuret seikkailijat Arpinaama ja Pikipöksy,\n\n\n uljaalla kulkuneuvollaan.";
	}

	void Update() {
		ukkoPos += (ukkoTarget - ukkoPos) * 2f * Time.deltaTime;
		ukkoPos2 += (ukkoTarget - ukkoPos2) * 1.5f * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return)) {
			story++;
		}
	}
	
	// Update is called once per frame
	void OnGUI() {
		if (story == -1) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), bgTex, ScaleMode.StretchToFill);
			GUI.DrawTexture (new Rect (Screen.width / 2 - Screen.width / 4, (int)ukkoPos + Screen.height / 10, ukkoSize, ukkoSize), ukko, ScaleMode.ScaleToFit);
			GUI.DrawTexture (new Rect (Screen.width / 2, (int)ukkoPos2, ukkoSize, ukkoSize), ukko2, ScaleMode.ScaleToFit);

			if (GUI.Button (new Rect (50, 100, 300, 100), startTex)) {
				story++;
			}

			if (GUI.Button (new Rect (50, 250, 300, 100), helpTex)) {
			}

			if (GUI.Button (new Rect (50, 400, 300, 100), exitTex)) {
				Application.Quit();
			}
		} else if (story < tarinaKuvat.Length) {
			GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), tarinaKuvat[story], ScaleMode.StretchToFill);
			GUI.Label(new Rect(50, Screen.height - 150, Screen.width - 50, 150), tarinaTekstit[story], style);
		} else {
			//Application.LoadLevel(1);
		}
	}
}
