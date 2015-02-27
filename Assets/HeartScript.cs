using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

	public int life = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hide(Space sp) {
		switch (life) {
		case 1:
			heart1.renderer.enabled = false;
			break;
		case 2:
			heart2.renderer.enabled = false;
			break;
		case 3:
			heart3.renderer.enabled = false;
			break;
		default:
			this.StartCoroutine(sp.EndGame());
			break;
		}
		sp.Destruct(life);
		life --;
	}
}
