using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxBehaviour : MonoBehaviour
{

    public GameObject box2;

    private Vector3 mousePosition;
    Vector3 offset;
    Vector3 scanPos;
    Vector3 screenPoint;
    Vector3 curScreenPoint;
    Vector3 curPosition;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Levels");
        }
    }



    void OnMouseDrag()
    {
        //Debug.Log("On Mouse Down");
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePos.x < -5.667f)
        {
            mousePos.x = -5.667f;
        }

        if (mousePos.y > 3.827f)
        {   
            mousePos.y = 3.827f;
        }

        if (mousePos.x > 5.667f)
        {
            mousePos.x = 5.667f;
        }

        if (mousePos.y < -3.827f)
        {
            mousePos.y = -3.827f;
        }

        mousePos.z = 6.0f;
        gameObject.transform.position = mousePos;
        mousePos.z = 6.0f;
        if(box2.gameObject != null)
            box2.gameObject.transform.position = -mousePos;
        
    }
}