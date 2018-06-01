using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : MonoBehaviour 
{
	[SerializeField]
	private GameObject pausePanel;
	[SerializeField]
	private GameObject pauseButton;

	private bool isPaused;

	public void TogglePause()
	{
		if (Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			pausePanel.SetActive (false);
			pauseButton.SetActive (true);
		}
		else
		{
			Time.timeScale = 0f;
			pausePanel.SetActive (true);
			pauseButton.SetActive (false);
		}
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			TogglePause ();
		}
	}

}
