﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinZoneScript : MonoBehaviour {

	// Reference to WinText game object
	public Text winText;

	public string nameOfPuzzle, escapeRoomGameScene;

	// Use this for initialization
	void Start () {
		// Turn "You Win!" sign at the start
		winText.gameObject.SetActive ( false );
	}

	// If target car (red one) exits the playground
	void OnTriggerEnter2D (Collider2D col)
	{
		// then "You Win!" sign is turned on
		winText.gameObject.SetActive ( true );

		PlayerPrefs.SetInt( "Score", PlayerPrefs.GetInt( "Score" ) + 1 );

		PlayerPrefs.SetString( nameOfPuzzle, "Complete" );

		PlayerPrefs.Save();

		SceneManager.LoadScene( escapeRoomGameScene );  


	}
}
