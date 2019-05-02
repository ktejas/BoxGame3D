using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpStarBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        if (otherCollision.gameObject.tag == "MainBox" || otherCollision.gameObject.tag == "MainBox2")
        {
            //TODO: Play SOUND through Box not star because star will get destroyed.
            GameManager.starsPicked++;
            Destroy(gameObject);
        }

    }
}
