using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {
	public string nextLevel;

	//When the character (tagged as PLayer) touches the triggered box
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.CompareTag ("Player")) {
			SceneManager.LoadScene (nextLevel);
		}
	}
}