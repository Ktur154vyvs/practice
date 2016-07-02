using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	private float speed = 3;
	private 
		Vector3 target = new Vector3 (0, -1, 0);
		int maxtop=4;
		float f=-1,top=1;
	void Update () {
		if (top != -2) {
			transform.position = transform.position + target * Time.deltaTime * speed;
			if (transform.position.y >= top && target.y != -1)
				target.y = -1;
			else if (transform.position.y <= -2 && target.y != 1)
				target.y = 1;
			if (f != target.y && target.y == -1 && top != -2) {
				top = top - 0.3f;
				speed = speed - 0.3f;
			}
			f = target.y;
		}
		else if (transform.position.y > -2)
			transform.position = transform.position + target * Time.deltaTime * speed;
	}
}
