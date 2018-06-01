using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
	[SerializeField]
	private Text scoreText;
	[SerializeField]
	private Text bestScoreText;

	void Start()
	{
		scoreText.text = GameData.LastScore.ToString ();
		bestScoreText.text = GameData.BestScore.ToString ();
	}

}
