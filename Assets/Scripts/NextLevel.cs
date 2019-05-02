using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    void Start ()
    {

        switch (GameManager.starsPicked)
        {
            case 0:
                break;
            case 1:
                //GameManager.star0.GetComponent<SpriteRenderer>().enabled = true;
                break;
            case 2:
                //GameManager.star0.GetComponent<SpriteRenderer>().enabled = true;
                //GameManager.star1.GetComponent<SpriteRenderer>().enabled = true;
                break;
            case 3:
                //GameManager.star0.GetComponent<SpriteRenderer>().enabled = true;
                //GameManager.star1.GetComponent<SpriteRenderer>().enabled = true;
                //GameManager.star2.GetComponent<SpriteRenderer>().enabled = true;
                break;
            default:
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
