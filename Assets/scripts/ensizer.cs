using UnityEngine;
using System.Collections;

public class ensizer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.Log ("ensizer at "+coll.transform.position);
		coll.transform.localScale = new Vector3 (3f, 3f, 1f);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
