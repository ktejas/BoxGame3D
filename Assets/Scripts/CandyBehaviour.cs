using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyBehaviour : MonoBehaviour
{
    public GameObject nextLevelObject;
    public GameObject box1;
    public GameObject box2;

    void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        if(otherCollision.gameObject.tag == "MainBox")
        {
            Instantiate(nextLevelObject, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            GameManager.paused = true;
            Destroy(otherCollision.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("MainBox2"));
            Destroy(GameObject.FindGameObjectWithTag("timer"));
        }

    }
}
