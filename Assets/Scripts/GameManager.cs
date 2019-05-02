using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script..
    public static bool paused;
    public static int starsPicked = 0;
    public static GameObject star0;
    public static GameObject star1;
    public static GameObject star2;
    public static GameObject adObject;
    public static bool bAdCreated = false;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        InitGame();
    }

    void InitGame()
    {
        paused = false;
        star0 = GameObject.FindGameObjectWithTag("star0");
        star1 = GameObject.FindGameObjectWithTag("star1");
        star2 = GameObject.FindGameObjectWithTag("star2");
    }

    void Update()
    {

    }

    public static void ShowBanner()
    {
        adObject.GetComponent<admobdemo>().AdmobShowBanner();
    }

    public static void ShowInterstial()
    {
        adObject.GetComponent<admobdemo>().AdmobShowInterstitial();
    }

    public static void ShowVideo()
    {
        adObject.GetComponent<admobdemo>().AdmobShowVideo();
    }
}