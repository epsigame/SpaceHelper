using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	
	public int speed = -3;
	
	void Start () {  
		var yPos = this.rigidbody2D.velocity.y;
		yPos = speed;
		this.rigidbody2D.velocity = new Vector2 (0, yPos);
		
		Destroy (gameObject, 10.0f);
	}
}
