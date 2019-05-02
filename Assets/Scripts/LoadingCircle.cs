using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingCircle : MonoBehaviour {

    private Vector3 rotateVector;

	void Start ()
    {
        rotateVector = new Vector3(0.0f, 0.0f, 360.0f);

    }

	void Update ()
    {
        transform.Rotate(Vector3.forward * -10);
    }
}
