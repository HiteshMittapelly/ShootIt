using UnityEngine;
using System.Collections;

public class border : MonoBehaviour {
	

	public void OnTriggerEnter2D(Collider2D coll)
	{
		

		Destroy (coll.gameObject);

		/*gbb = GameObject.FindGameObjectWithTag ("egg");
        Debug.Log ("entered at border " + coll.transform.position);

		eb = gbb.GetComponent<EggBehaviour>();
		eb.set = false;
		Destroy (gbb);*/
	}
}
