using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

	public static PoolManager instance;

	[SerializeField]
	private GameObject[] prefabs;
	[SerializeField]
	private int amount;

	private List<GameObject> pooledObjects;

	void Awake()
	{
		instance = this;

		pooledObjects = new List<GameObject> ();

		CreatePool ();
	}

	void CreatePool()
	{
		for(int i=0; i < amount; i++)
		{
			GameObject gameObject = Instantiate (prefabs [Random.Range (0, prefabs.Length)]) as GameObject;
			gameObject.SetActive (false);
			pooledObjects.Add (gameObject);
		}
	}

	public GameObject GetObject()
	{
		for(int i=0; i < pooledObjects.Count; i++)
		{
			if (!pooledObjects [i].activeInHierarchy)
			{
				pooledObjects [i].SetActive (true);
				return pooledObjects [i];
			}
		}
		GameObject newObject = Instantiate (prefabs [Random.Range (0, prefabs.Length)]) as GameObject;
		pooledObjects.Add (newObject);
		return newObject;
	}
}
