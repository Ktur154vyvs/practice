using UnityEngine;
using System.Collections;

public class bot : MonoBehaviour {
	public GameObject ball;
	private int k=1;
	private float ballx;
	void Update () {
		
		if (ballx > ball.transform.position.x)
			if (transform.position.x < ball.transform.position.x) {
				transform.position += new Vector3 (1f, 0f, 0f) * Time.deltaTime * 5;
			}
		else
			transform.position += new Vector3 (-1f, 0f, 0f) * Time.deltaTime * 5;
		else if (k==1)
			if (transform.position.x >= -5)
				transform.position += new Vector3 (-1f, 0f, 0f) * Time.deltaTime * 5;
			else {
				transform.position += new Vector3 (1f, 0f, 0f) * Time.deltaTime * 5;
				k = 0;
				}
			if (ball.transform.position.x <= transform.position.x + 3 && ball.transform.position.y > transform.position.y && transform.position.y <= -1.8f)
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, 25f), ForceMode2D.Impulse);
			ballx = ball.transform.position.x;	
		}

}
