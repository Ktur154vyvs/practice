using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class notreset : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	//	DontDestroyOnLoad (GetComponent<Text> ().text.gameObject);
	}
}
