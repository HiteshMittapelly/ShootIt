using UnityEngine;
using System.Collections;

public class bulletborder : MonoBehaviour {
	

	public void OnTriggerEnter2D(Collider2D collider)
	{
		Destroy (collider.gameObject);
	}
}
