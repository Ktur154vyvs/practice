using UnityEngine;
using System.Collections;

public class goleft : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void  OnMouseDrag() {
		player.transform.position = player.transform.position - Vector3.right* Time.deltaTime;
	}
	


}
