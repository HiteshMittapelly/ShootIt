using UnityEngine;
using System.Collections;

public class desizer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void OnTriggerEnter2D(Collider2D coll)
	{
		coll.transform.localScale = new Vector3 (1f, 1f, 1f);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
