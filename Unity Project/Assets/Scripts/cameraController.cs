using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraController : MonoBehaviour {

	public Camera playCamera;
	public Camera mapCamera;
	private bool playing = true;

	// Use this for initialization
	void Start () {
		playCamera.gameObject.SetActive (true);
		mapCamera.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C) && playing) {
			toggleCamera (ref playing);
		} else if (Input.GetKeyDown (KeyCode.C) && !playing) {
			toggleCamera (ref playing);
		}
	}

	private void toggleCamera(ref bool playing) {
		if (playing) {
			playCamera.gameObject.SetActive (false);
			mapCamera.gameObject.SetActive (true);
		} else {
			playCamera.gameObject.SetActive (true);
			mapCamera.gameObject.SetActive (false);
		}
		playing = !playing;
	}
}
