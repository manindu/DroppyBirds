using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void GoToScene(string scene)
	{
		if (Time.timeScale == 0)
		{
			Time.timeScale = 1f;
		}
		SceneManager.LoadScene (scene);
	}
}
