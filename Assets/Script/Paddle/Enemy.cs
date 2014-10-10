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
			float height = transform.localScale.y * 0.8f;       //affecting how responsive enemy to the ball position
			Vector3 pos_ball = ball.gameObject.transform.position;
		
			if(pos_ball.y > (pos.y + height / 2) ) {
				this.position_offset = new Vector3(0, speed, 0);
			} else if(pos_ball.y < (pos.y - height / 2)) {
				this.position_offset = new Vector3(0, -speed, 0);
			} else {
				this.position_offset = Vector3.zero;
			}

			base.Update();
		}
	}
}
