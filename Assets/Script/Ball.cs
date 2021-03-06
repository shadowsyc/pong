﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	

	public Vector2 velocity = new Vector2(5, 5);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;
		RaycastHit hit;

		float x = velocity.x;
		float y = velocity.y;
		/*
		if(Physics.Raycast(pos, (new Vector3(0, y, 0)).normalized, out hit, transform.localScale.x / 2)) {
			if(hit.collider.tag != "score_area") {
				y = -y;
				velocity = new Vector2(x, y);
			}
		} else if (Physics.Raycast(pos, (new Vector3(x, 0, 0)).normalized, out hit, transform.localScale.x / 2)) {
			if(hit.collider.tag != "score_area") {
				x = -x;
				velocity = new Vector2(x, y);
			}
		} */

		if(Physics.Raycast(pos, (new Vector3(0, y, 0)).normalized, out hit, transform.localScale.x / 2)) {
			if(hit.collider.tag != "score_area") {
				y = -y;
				velocity = new Vector2(x, y);
			}
		} else if (Physics.Raycast(pos, (new Vector3(x, 0, 0)).normalized, out hit, transform.localScale.x / 2)) {
			if(hit.collider.tag != "score_area") {
				x = -x;

				if(hit.collider.tag == "paddle") {
					Paddle paddle = hit.collider.gameObject.GetComponent<Paddle>();
					Vector3 speed = paddle.getPositionOffset();
					// if the paddle is moving, adding ball speed
					if(speed != Vector3.zero) {
						x = x * 1.1f;
						y = y * 1.1f;
					}
				}


				velocity = new Vector2(x, y);
			}
		} 



		transform.position = transform.position + new Vector3(velocity.x, velocity.y, 0);
	}

	public void SetVelocity(Vector2 velocity) {
		this.velocity = velocity;
	}
}
