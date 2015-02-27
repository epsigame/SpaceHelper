using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	public Constante s;
	
	// Use this for initialization
	void Start () {
		s = GameObject.FindObjectOfType<Constante> ();
		var desiredScale = Random.Range(0.5F, 1.5F);
		
		transform.localScale = new Vector3( desiredScale, desiredScale, desiredScale);
		var yPos = this.rigidbody2D.velocity.y;
		yPos = s.speedEnemy;
		this.rigidbody2D.velocity = new Vector2 (0, yPos);
		this.rigidbody2D.angularVelocity = Random.Range(-200, 200);

		Destroy (gameObject, 3.0f);
	}

	void OnTriggerEnter2D(Collider2D obj) {  
		var name = obj.gameObject.name;
		var obj2 = (GameObject) obj.gameObject;

		if (name == "spaceship") {
			Space sp = obj2.GetComponent<Space>();
			sp.LoseLife();
			Destroy(gameObject);
		}
	}
}
