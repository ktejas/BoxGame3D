using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehaviour : MonoBehaviour
{
    public int starNum = 0;

	void Start ()
    {
		if(starNum <= GameManager.starsPicked)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
	}
	
	void Update ()
    {
		
	}
}
