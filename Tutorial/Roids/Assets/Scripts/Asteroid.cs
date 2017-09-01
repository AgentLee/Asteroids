using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour 
{
	public int pointValue;
	public AudioClip deathKnell;

	// Use this for initialization
	void Start () 
	{
		pointValue = 10;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public GameObject deathExplosion;

	public void Die()
	{
		AudioSource.PlayClipAtPoint (deathKnell, gameObject.transform.position);

		Instantiate(deathExplosion, gameObject.transform.position,
			Quaternion.AngleAxis(-90, Vector3.right) );

		GameObject obj = GameObject.Find ("GlobalObject");
		Global g = obj.GetComponent<Global> ();
		g.score += pointValue;

		Debug.Log ("Score: " + g.score);

		// Removes gameObject from the scene 
		// and marks it for garbage collection
		Destroy (gameObject);
	}
}
