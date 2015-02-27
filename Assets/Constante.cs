using UnityEngine;
using System.Collections;

public class Constante : MonoBehaviour {
	
	public float spawnTimeEnemy = 0.6f;
	public int levelTime = 6;
	public int speedSpaceShip = 10;
	public int speedEnemy = -5;
	public float increasingDifficulty = 6 / 10.0f;
	
	private static Constante _instance;

	public static Constante instance
	{
		get
		{
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<Constante>();
			return _instance;
		}
	}
	
	public void Play()
	{
		//
	}
}
