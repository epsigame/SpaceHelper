using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject enemy;
	public Constante s;
	private float _spawnTime;
	
	void Start () {
		s = GameObject.FindObjectOfType<Constante> ();
		_spawnTime = s.spawnTimeEnemy;
		InvokeRepeating("addEnemy", s.spawnTimeEnemy, s.spawnTimeEnemy);
		InvokeRepeating("increaseLevel", s.levelTime, s.levelTime);
	}

	void addEnemy() {  
		var x1 = transform.position.x - renderer.bounds.size.x/2;
		var x2 = transform.position.x + renderer.bounds.size.x/2;

		var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
		
		// Create an enemy at the 'spawnPoint' position
		Instantiate(enemy, spawnPoint, Quaternion.identity);
	}

	void increaseLevel() {
		_spawnTime = _spawnTime * s.increasingDifficulty;
	}
}