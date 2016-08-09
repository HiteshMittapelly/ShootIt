using UnityEngine;
using System.Collections;

public class playergun : MonoBehaviour {
	public GameObject player;
	public float speed = 5f;
	public GameObject shot;
	public float bulletspeed;
	private int count = 5;
	private float xmin;
	private float xmax;
	public int getcount(){
	
		return count;
	
	}

	// Use this for initialization
	void Start () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
		xmin = leftmost.x; 
		xmax = rightmost.x;
	}
	void Fire(){
		GameObject beam = Instantiate(shot, player.transform.position, Quaternion.identity) as GameObject;
		beam.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletspeed);

	}
	
	// Update is called once per frame
	void Update ()

	{
		if(Input.GetKeyDown(KeyCode.Space)){
			count--;
			if (count >= 0)
				Fire ();
			
				//EggBehaviour egb = GameObject.Find ("EggBehaviour").GetComponent<EggBehaviour> ();
				//egb.set = false;
		
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			player.transform.position += Vector3.left * speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			player.transform.position += Vector3.right * speed * Time.deltaTime; 
		}

		// restrict the player to the gamespace
		float newX = Mathf.Clamp (player.transform.position.x, xmin, xmax);
		player.transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}

	}

