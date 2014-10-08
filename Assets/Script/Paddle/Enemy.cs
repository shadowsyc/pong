using UnityEngine;
using System.Collections;

public class Enemy : Paddle {

	private Ball ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("ball").GetComponent<Ball>();	
	}
	
	// Update is called once per frame
	void Update () {

		// enemy follows ball's y position
		if(ball) {
			Vector3 pos = transform.position;

			transform.position = new Vector3(pos.x, ball.gameObject.transform.position.y, pos.z);
		}
	}
}
