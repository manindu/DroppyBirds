using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;

	[SerializeField]
	private Text scoreText;
	[SerializeField]
	private Text livesText;

	private int score;
	private int lives = 3;

	void Awake()
	{
		instance = this;
		livesText.text = lives.ToString ();
	}

	public void AddScore(int points)
	{
		score += points;
		scoreText.text = score.ToString ();
		AudioManager.instance.PlayClip (Clip.SCORE);
	}

	public void ReduceLife()
	{
		lives -= 1;
		livesText.text = lives.ToString ();
		if (lives <= 0)
		{
			// game over
			GameData.LastScore = score;
			if (score > GameData.BestScore)
			{
				GameData.BestScore = score;
			}
			SceneManager.LoadScene ("GameOver");
		}
	}
}
