using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainBladeBehaviour : MonoBehaviour
{

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Rotate(Vector3.forward * -360 * Time.deltaTime);
    }

}
