using UnityEngine;
using System.Collections;

public enum Clip
{
	FLAP,
	SCORE
}

public class AudioManager : MonoBehaviour
{

	[SerializeField]
	private AudioClip flap;
	[SerializeField]
	private AudioClip score;

	public static AudioManager instance;

	private AudioSource source;

	void Awake()
	{
		instance = this;
		source = GetComponent<AudioSource> ();
	}

	public void PlayClip(Clip clip)
	{
		switch (clip)
		{
		case Clip.FLAP:
			source.PlayOneShot (flap);
			break;
		case Clip.SCORE:
			source.PlayOneShot (score);
			break;
		}
	}
}

