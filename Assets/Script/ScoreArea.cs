using UnityEngine;
using System.Collections;

public class ScoreArea : MonoBehaviour {

	public bool player_score_area = false;

	protected GameManager game_manager;

	// Use this for initialization
	void Start () {
		game_manager = GameObject.Find ("game_manager").GetComponent<GameManager>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// adding score to players
	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "ball") {
			if(player_score_area) {
				game_manager.addPlayerScore(1);
				game_manager.resetBall();
			} else {
				game_manager.addEnemyScore(1);
				game_manager.resetBall();
			}
		}
	}
}
