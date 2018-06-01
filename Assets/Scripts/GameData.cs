using UnityEngine;
using System.Collections;

public static class GameData
{
	public static int mLastScore = 0;

	private static string bestScoreKey = "BestScore";

	public static int LastScore
	{
		get
		{ 
			return mLastScore;
		}
		set
		{ 
			mLastScore = value;
		}
	}

	public static int BestScore
	{
		get
		{ 
			if (!PlayerPrefs.HasKey (bestScoreKey))
			{
				PlayerPrefs.SetInt (bestScoreKey, 0);
			}
			return PlayerPrefs.GetInt (bestScoreKey);
		}
		set
		{ 
			PlayerPrefs.SetInt (bestScoreKey, value);
		}
	}
}

