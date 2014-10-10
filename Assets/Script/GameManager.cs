using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int player_score = 0;
	public int enemy_score = 0;

	public int label_pos_y = 10;
	public int label_width = 120;
	public int label_height = 30;

	protected Ball ball;

	// init
	void Start () {
		ball = GameObject.Find ("ball").GetComponent<Ball>();
	}
	

	// rendering score label
	void OnGUI() {
		GUIStyle center_style = GUI.skin.GetStyle("Label");
		center_style.alignment = TextAnchor.UpperCenter;
		center_style.fontSize = 20;
		GUI.Label(new Rect((Screen.width - label_width) / 2, label_pos_y, label_width, label_height), player_score + ":" + enemy_score, center_style);
	}

	// reset the ball position
	public void ResetBall() {
	
		ball.gameObject.transform.localPosition = new Vector3(0, 0, 0);
		ball.SetVelocity(new Vector2(5, 5));
	}
	
	// getter/setter for adding scores
	public void AddPlayerScore(int score) {
		player_score += score;
	}

	public void AddEnemyScore(int score) {
		enemy_score += score;
	}

	public int GetPlayerScore() {
		return player_score;
	}

	public int GetEnemyScore() {
		return enemy_score;
	}
}