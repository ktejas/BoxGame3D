using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartToMenu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(StartMenu());
	}

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator StartMenu()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Menu");
    }
}
