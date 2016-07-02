using UnityEngine;
using System.Collections;

public class jamp : MonoBehaviour {
	public GameObject player;
	private Vector3 target = new Vector3 (0, 1, 0); bool k= true;
	// Use this for initialization
	void OnMouseDown(){
		k = false;
	}
	void  OnMouseDrag() {
		player.transform.position = player.transform.position + target*Time.deltaTime*3;
		if (player.transform.position.y >= 1 && target.y != -1)
			target.y = -1;
		else if (player.transform.position.y <= -2 && target.y != 1)
			target.y = 1;
	}
	void  OnMouseUp(){
		//target.y = -1;
		k= true;
	}
	void Update() {
		if (player.transform.position.y >= -2 && k) {
			target.y = -1;
			player.transform.position = player.transform.position + target * Time.deltaTime * 3;
		}
	}

}
