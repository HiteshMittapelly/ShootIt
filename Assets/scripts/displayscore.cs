using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text myText = GetComponent<Text>();
		myText.text = EggBehaviour.score.ToString();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
