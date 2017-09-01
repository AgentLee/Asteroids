using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	public Vector3 thrust;
	public Quaternion heading;

	// Use this for initialization
	void Start () 
	{
		// Travel straight in x-axis
		thrust.x = 400.0f;

		// No passive deceleration
		GetComponent<Rigidbody>().drag = 0;

		// Set travel direction
		GetComponent<Rigidbody>().MoveRotation(heading);

		// Apply thrust once
		GetComponent<Rigidbody>().AddRelativeForce(thrust);
	}

	// Update is called once per frame
	void Update () 
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		Collider collider = collision.collider;

		if (collider.CompareTag ("Asteroid")) {
			Asteroid roid = collider.gameObject.GetComponent<Asteroid> ();

			// Let Asteroid handle its own death
			roid.Die ();

			// Destroy the bullet
			Destroy (gameObject);
		}
		else {
			// Print to console if the bullet hits something else
			Debug.Log("Collided with " + collider.tag);
		}
	}
}
