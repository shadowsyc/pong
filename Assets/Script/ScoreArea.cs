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
				game_manager.AddPlayerScore(1);
				game_manager.ResetBall();
			} else {
				game_manager.AddEnemyScore(1);
				game_manager.ResetBall();
			}
		}
	}
}
