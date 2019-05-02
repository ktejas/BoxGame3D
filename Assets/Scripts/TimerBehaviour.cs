using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBehaviour : MonoBehaviour
{
    public GameObject gameOverObject;

    private Image image;
    private bool isGameOver = false;

    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 1.0f;
    }


    void Update ()
    {
        image.fillAmount -= 0.001f;
        if(image.fillAmount <= 0.0f && !isGameOver)
        {
            Instantiate(gameOverObject);
            isGameOver = true;
            GameManager.paused = true;
            Destroy(GameObject.FindGameObjectWithTag("MainBox"));
            Destroy(GameObject.FindGameObjectWithTag("MainBox2"));
            Destroy(GameObject.FindGameObjectWithTag("timer"));
        }
    }

}
