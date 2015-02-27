using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour {

	public HeartScript life;
	public GameObject explosion;
	public Constante s;

	// Use this for initialization
	void Start () {
		s = GameObject.FindObjectOfType<Constante> ();
	}

	
	// Update is called once per frame
	void Update () {
		if (life.life > -1) {
			var vector = this.rigidbody2D.velocity;
			vector.x = Input.GetAxis ("Horizontal") * s.speedSpaceShip;
			vector.y = Input.GetAxis ("Vertical") * s.speedSpaceShip;
			this.rigidbody2D.velocity = vector;
		}
	}

	public void LoseLife() {
		life.hide (this);
	}

	public void Destruct(int i) {
		if (i > -1) {
			var spawnPoint = new Vector2(this.transform.position.x, this.transform.position.y);
			Instantiate(explosion, spawnPoint, Quaternion.identity);
		}
	}

	public IEnumerator EndGame() {
		this.renderer.enabled = false;
		yield return new WaitForSeconds(3);
		Time.timeScale = 0;
	}
}
