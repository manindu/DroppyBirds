using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	[SerializeField]
	private Vector3[] spawnPositions;
	[SerializeField]
	private float minYForce;
	[SerializeField]
	private float maxYForce;
	[SerializeField]
	private float spawnInterval = 2.5f;

	void Start()
	{
		StartCoroutine (SpawnBirds());
	}

	IEnumerator SpawnBirds()
	{
		yield return new WaitForSeconds (1f);

		while(true)
		{
			GameObject bird = PoolManager.instance.GetObject ();
			bird.transform.position = spawnPositions[Random.Range(0, spawnPositions.Length)];
			float yForce = Random.Range (minYForce, maxYForce);
			bird.SetActive (true);
			bird.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, yForce));

			yield return new WaitForSeconds (spawnInterval);
		}
	}

	void Spawn()
	{
		GameObject bird = PoolManager.instance.GetObject ();
		bird.transform.position = spawnPositions[Random.Range(0, spawnPositions.Length)];
		float yForce = Random.Range (minYForce, maxYForce);
		bird.SetActive (true);
		bird.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, yForce));
	}
}
