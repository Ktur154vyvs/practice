using UnityEngine;
using System.Collections;
using CnControls;

public class touch : MonoBehaviour {
	Vector3 position;
	void Update () 
	{	   
		if (transform.position.x <= 6 && transform.position.x >= -6) {
			position = new Vector3 (CnInputManager.GetAxis ("Horizontal"), 0f, 0f);
			transform.position += position * Time.deltaTime * 5;
		}
		else if (transform.position.x<0)
			transform.position += new Vector3(1f,0f,0f) * Time.deltaTime*5;
			else transform.position += new Vector3(-1f,0f,0f) * Time.deltaTime*5;
		if (CnInputManager.GetButton ("Jump")) {
			if (transform.position.y <= -2)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, 25f), ForceMode2D.Impulse);
		}

		if (Application.platform == RuntimePlatform.Android)
					if (Input.GetKey(KeyCode.Escape))
						{
						Application.LoadLevel ("main1");
						
						//return;
						}

	}

}

