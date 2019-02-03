using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -0.2f;
	private float deadLine= -10f;
	private Rigidbody2D rigid2D;



	// Use this for initialization
	void Start () {

		this.rigid2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (this.speed, 0, 0);

		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
			
		
	}

	void OnCollisionEnter2D(Collision2D col){



		if(col.gameObject.tag == "CubeTag" || col.gameObject.tag == "GroundTag"){

			GetComponent<AudioSource> ().Play();

		}


	}

}
