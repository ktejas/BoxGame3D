using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehaviour : MonoBehaviour
{

	void Start ()
    {
        transform.position = new Vector3(Random.Range(-3.62f, 5.62f), Random.Range(8.15f, 11.3f), -8.35f);
    }
	
	void Update ()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 2.0f);

        if(transform.position.y < -11.25f)
        {
            transform.position = new Vector3(Random.Range(-3.62f,5.62f), Random.Range(8.15f, 11.3f), -8.35f);
        }
    }
}
