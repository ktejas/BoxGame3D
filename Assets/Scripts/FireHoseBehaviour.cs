using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHoseBehaviour : MonoBehaviour
{

    private bool bIsOn = true;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidBody;

	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody = GetComponent<Rigidbody2D>();
        StartCoroutine(TurnFireOn());
	}
	
	void Update ()
    {
		
	}

    IEnumerator TurnFireOn()
    {
        yield return new WaitForSeconds(2.0f);

        if (bIsOn == true)
        {
            spriteRenderer.enabled = false;
            Destroy(rigidBody);
            bIsOn = false;
        }
        else
        {
            spriteRenderer.enabled = true;
            gameObject.AddComponent<Rigidbody2D>();
            bIsOn = true;
        }

        StartCoroutine(TurnFireOn());
    }
}
