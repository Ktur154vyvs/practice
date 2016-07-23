using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	public GameObject m_on, m_off;
	public Sprite layer_red, layer_blue;
	void Start(){
		if (PlayerPrefs.GetString ("Music") == "no"){
			m_on.SetActive (false);
			m_off.SetActive (true);
		} else {
			m_on.SetActive (true);
			m_off.SetActive (false);
		}
	}


    void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue; 
	}
	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUpAsButton () {
		if (PlayerPrefs.GetString ("Music") != "no")
			GameObject.Find ("ClickAudio").GetComponent<AudioSource> ().Play ();
		switch (gameObject.name) {
		case "play":
			Application.LoadLevel ("main");
			break;
		case "help":
			Application.LoadLevel ("help");
			break;
		case "close":
			Application.LoadLevel ("main1");
			break;
		case "Music":
			if (PlayerPrefs.GetString ("Music") != "no") {
				PlayerPrefs.SetString ("Music", "no");
				m_on.SetActive (false);
				m_off.SetActive (true);
			} else {
				PlayerPrefs.SetString ("Music", "yes");
				m_on.SetActive (true);
				m_off.SetActive (false);
			}
			break;
		}
	}
}

