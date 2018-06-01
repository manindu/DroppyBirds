using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	void Update()
	{
		if (Input.GetMouseButtonDown (0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if (hit && hit.collider)
			{
				Bird bird = hit.transform.GetComponent<Bird> ();
				if (bird)
				{
					hit.transform.GetComponent<Bird> ().Flap();
					AudioManager.instance.PlayClip (Clip.FLAP);
				}
			}
		}
	}
}

