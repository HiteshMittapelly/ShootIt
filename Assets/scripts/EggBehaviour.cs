using UnityEngine;
using System.Collections;

public class EggBehaviour : MonoBehaviour {
	private Rigidbody2D rb;
	public GameObject gob;
	 float xspeed = 300f;
	 float yspeed = 20f;
	private GameObject ef;
	public bool set = false;
	private int value = 0;
	public static int score = 0;
	public GameObject player;
	private bool setplayer= true;

	// Use this for initialization
	void Start () {
			
	}
	public void eject()
	{
		
	
		
		Debug.Log (" value is " + value);
		if (setplayer) {
			setplayer = false;
			Instantiate (player, player.transform.position, Quaternion.identity);
		}
		if (value==0) 
		{
			InvokeRepeating ("starteject", 2f, 5f);
		}

	}
	public void starteject()
	{
		value++;
		if (value > 5) {
			CancelInvoke ();
			LevelManager lm = GameObject.Find ("LevelManager").GetComponent<LevelManager> ();
			lm.LoadLevel("end");


		}
		ef = Instantiate (gob, new Vector3 (-10f, 1f, 1f), Quaternion.identity) as GameObject;
		xspeed += 50f;
		ef.GetComponent<Rigidbody2D>().velocity = new Vector2(xspeed*Time.deltaTime, yspeed*Time.deltaTime);

		/*Debug.Log (ef.transform.position);
		set = true;
		if (value>0)
			Invoke ("starteject", 6f);
		
		else 
		{
			//set = false;
			value = 0;
			CancelInvoke ();
		}*/
	}
	// Update is called once per frame
	void Update ()
	{
		/*Debug.Log (set);
		if (set)
		{ 
			ef.transform.position += new Vector3 (xspeed * Time.deltaTime, yspeed * Time.deltaTime);
			Debug.Log (ef.transform.position);
		}
		if (set == false) {
			
		//	Destroy (ef);

            
		}*/
	} 
	void OnTriggerEnter2D(Collider2D collider){
		Bullet fire = collider.gameObject.GetComponent<Bullet> ();
		if (fire) {
			score++;
			fire.Hit ();
			Die ();
		
		}
		Invoke ("starteject", 2f);
		CancelInvoke ();
		}
	public void Die(){
	
		Destroy (gameObject);
	}
	public void reset()
	{
		score = 0;
	}
	}

