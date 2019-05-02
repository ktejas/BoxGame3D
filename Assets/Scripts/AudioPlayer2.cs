using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer2 : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
