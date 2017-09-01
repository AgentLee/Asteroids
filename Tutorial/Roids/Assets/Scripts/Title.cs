using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour 
{
	private GUIStyle buttonStyle;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnGUI()
	{
		GUILayout.BeginArea (new Rect (10, Screen.height / 2 + 100, Screen.width - 10, 200));

		// Load main scene
		if (GUILayout.Button ("New Game")) {
			Application.LoadLevel ("GameplayScene");
		}

		if (GUILayout.Button ("High Score")) {
			Debug.Log ("LOL");
		}

		if (GUILayout.Button ("Exit")) {
			Application.Quit ();
		}

		GUILayout.EndArea ();
	}
}
