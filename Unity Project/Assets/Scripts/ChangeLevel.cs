using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
public class ChangeLevel : MonoBehaviour
{
    public string nextLevel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
=======
public class ChangeLevel : MonoBehaviour {
	public string nextLevel;

	//When the character (tagged as PLayer) touches the triggered box
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.CompareTag ("Player")) {
			SceneManager.LoadScene (nextLevel);
		}
	}
>>>>>>> d1f87b2275f33512aa1bc9b641a98cd71dd7ab96
}