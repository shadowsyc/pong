using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public int speed = 5;
	protected Vector3 position_offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
		if(position_offset != Vector3.zero) {
			Vector3 pos = transform.position;
			Vector3 nextPos = pos + position_offset;

			if(Physics.Raycast(pos, position_offset.normalized, transform.localScale.y / 2 + position_offset.magnitude)) {
				// hit the border
			} else {
				transform.position = nextPos;		
			}
		}
	}
}
