using UnityEngine;
using System.Collections;

public class SpawnBackground : MonoBehaviour {
	public GameObject background;
	public float spawnTime = 6.0f;
	
	void Start() {  
		InvokeRepeating("addBackground", 3.0f, spawnTime);
	}
	
	void addBackground() {  
		var spawnPoint = new Vector2(0, transform.position.y);
		
		// Create an enemy at the 'spawnPoint' position
		Instantiate(background, spawnPoint, Quaternion.identity);
	}
}