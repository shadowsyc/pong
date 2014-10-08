using UnityEngine;
using System.Collections;

public class Player : Paddle {

	// Update is called once per frame
	public override void Update () {

		Vector3 pos = transform.position;
	
		if(Input.GetKey("up")) {
			this.position_offset = new Vector3(0, speed, 0);
		} else if (Input.GetKey("down")) {
			this.position_offset = new Vector3(0, -speed, 0);
		} else {
			this.position_offset = Vector3.zero;
		}

		base.Update();
	}

}
