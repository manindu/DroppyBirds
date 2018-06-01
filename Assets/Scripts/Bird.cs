using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	[SerializeField]
	private float yForce;
	[SerializeField]
	private int points = 1;

	private Rigidbody2D rb2d;


	void OnEnable()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	public void Flap()
	{
		rb2d.velocity = Vector2.zero;
		rb2d.AddForce (Vector2.up * yForce);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.CompareTag("House"))
		{
			Deactivate ();
			ScoreManager.instance.AddScore (points);
		}
		else if (col.CompareTag("DeactivationTrigger"))
		{
			Deactivate ();
			ScoreManager.instance.ReduceLife ();
		}
	}

	void Deactivate()
	{
		gameObject.SetActive (false);
	}
}
