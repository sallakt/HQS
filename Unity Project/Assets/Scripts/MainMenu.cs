using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> ae0141dc51bc3ff6af970d89aced85fd2d8cf417
public class MainMenu : MonoBehaviour
{

    //Main menu "play" button
    public void Play()
    {
        SceneManager.LoadScene("Level1");
        //or in brackets: SceneManager.GetActiveScene().buildIndex + 1
        //^ if you always want the "next level"
    }
    //Main menu "quit" button
    public void Quit()
    {
        //to let us know it works (written in the console in Unity)
        Debug.Log("GAME HAS BEEN QUIT");
        Application.Quit();
    }
<<<<<<< HEAD
=======
=======
public class MainMenu : MonoBehaviour {

	//Main menu "play" button
	public void Play (){
		SceneManager.LoadScene("Level1");
		//or in brackets: SceneManager.GetActiveScene().buildIndex + 1
		//^ if you always want the "next level"
	}
	//Main menu "quit" button
	public void Quit (){
		//to let us know it works (written in the console in Unity)
		Debug.Log("GAME HAS BEEN QUIT");
		Application.Quit ();
	}
>>>>>>> d1f87b2275f33512aa1bc9b641a98cd71dd7ab96
>>>>>>> ae0141dc51bc3ff6af970d89aced85fd2d8cf417
}