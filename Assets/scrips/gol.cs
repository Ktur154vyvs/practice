using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gol : MonoBehaviour {
	public GameObject guiTextLink1, guiTextLink2, guiTextLink3;
	static int i1,i2;
	static float timepl=120f;
	// Use this for initialization


			
	void Awake(){
		guiTextLink1.GetComponent<Text> ().text = i1.ToString ();
		guiTextLink2.GetComponent<Text> ().text = i2.ToString ();
		//timepl = 120f;
	}
	void Update(){
		if (timepl > 0f) {
			timepl -= Time.deltaTime;
			if (timepl > 60)
				guiTextLink3.GetComponent<Text> ().text = ((int)timepl / 60).ToString () + "." + ((int)timepl - ((int)timepl / 60) * 60).ToString ();
			else
				guiTextLink3.GetComponent<Text> ().text = "0." + ((int)timepl).ToString ();
		} else {
			if (i1 > i2)
				guiTextLink3.GetComponent<Text> ().text = "Выиграл комп";
			else if (i1 < i2)
				guiTextLink3.GetComponent<Text> ().text = "Выиграл Игрок";
			else
				guiTextLink3.GetComponent<Text> ().text = "Ничья";
			Application.LoadLevel ("main1");
		}
	}
	void OnTriggerEnter2D(Collider2D a) {
		
		if (a.name == "right") {
			i1++;
			guiTextLink1.GetComponent<Text> ().text = i1.ToString ();
			Application.LoadLevel (Application.loadedLevelName);
		}
		if (a.name == "left") {
			i2++;
			guiTextLink2.GetComponent<Text> ().text = i2.ToString ();
			Application.LoadLevel (Application.loadedLevelName);
		}
	}

}
