using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickUI : MonoBehaviour
{
    public GameObject pauseObject;
    public string buttonClicked;
    public GameObject adObject;
    private AudioSource audioSource;

    void Start ()
    {
        //audioSource = GetComponent<AudioSource>();
        audioSource = GameObject.FindGameObjectWithTag("AudioPlayer").GetComponent<AudioSource>();
    }
	
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        //Debug.Log("Clicked");
        switch(buttonClicked)
        {
            case "Resume":
                GameManager.starsPicked = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                audioSource.Play();
                break;
            case "InstructionHome":
                SceneManager.LoadScene("Menu");
                audioSource.Play();
                break;
            case "Restart":
                GameManager.starsPicked = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                audioSource.Play();
                break;
            case "ExitToLevels":
                SceneManager.LoadScene("Levels");
                audioSource.Play();
                break;
            case "GameOverHome":
                SceneManager.LoadScene("Levels");
                audioSource.Play();
                break;
            case "GameOverNext":
                GameManager.starsPicked = 0;

                //Extracting level name
                string sceneLoaded = string.Format("{0}", SceneManager.GetActiveScene().name);
                string sceneToLoad = sceneLoaded.Substring(0, 5);
                sceneLoaded = sceneLoaded + "      ";
                int levelToLoad = Int32.Parse(sceneLoaded.Substring(5, 2)) + 1;
                Debug.Log(levelToLoad);
                sceneToLoad = string.Format("{0}" + levelToLoad, sceneToLoad);
                SceneManager.LoadScene(sceneToLoad);
                audioSource.Play();
                //Displaying Interstitial
                //GameManager.ShowInterstial();
                //if (UnityEngine.Random.Range(0, 10) > 7)
                //   GameManager.ShowInterstial();
                //adObject.GetComponent<admobdemo>().AdmobShowInterstitial();

                break;
            case "LevelsNextButton2":
                SceneManager.LoadScene("Levels2");
                audioSource.Play();
                break;
            case "LevelsNextButton3":
                SceneManager.LoadScene("Levels3");
                audioSource.Play();
                break;
            case "MenuPlay":
                SceneManager.LoadScene("Levels");
                audioSource.Play();
                break;
            case "MenuInstructions":
                SceneManager.LoadScene("Instructions");
                audioSource.Play();
                break;
            case "MenuRate":
                SceneManager.LoadScene("Rate");
                audioSource.Play();
                break;
            case "RateRate":
                //TODO Change all assets to original
#if UNITY_ANDROID
                Application.OpenURL("market://search?q=Mad+Logic+Games");
#elif UNITY_IPHONE
                Application.OpenURL("itms-apps://itunes.apple.com/app/id1225031902");
#endif
                break;
            case "ButtonLevel1":
                SceneManager.LoadScene("Level1");
                audioSource.Play();
                break;
            case "ButtonLevel2":
                SceneManager.LoadScene("Level2");
                audioSource.Play();
                break;
            case "ButtonLevel3":
                SceneManager.LoadScene("Level3");
                audioSource.Play();
                break;
            case "ButtonLevel4":
                SceneManager.LoadScene("Level4");
                audioSource.Play();
                break;
            case "ButtonLevel5":
                SceneManager.LoadScene("Level5");
                audioSource.Play();
                break;
            case "ButtonLevel6":
                SceneManager.LoadScene("Level6");
                audioSource.Play();
                break;
            case "ButtonLevel7":
                SceneManager.LoadScene("Level7");
                audioSource.Play();
                break;
            case "ButtonLevel8":
                SceneManager.LoadScene("Level8");
                audioSource.Play();
                break;
            case "ButtonLevel9":
                SceneManager.LoadScene("Level9");
                audioSource.Play();
                break;
            case "ButtonLevel10":
                SceneManager.LoadScene("Level10");
                audioSource.Play();
                break;
            case "ButtonLevel11":
                SceneManager.LoadScene("Level11");
                audioSource.Play();
                break;
            case "ButtonLevel12":
                SceneManager.LoadScene("Level12");
                audioSource.Play();
                break;
            case "ButtonLevel13":
                SceneManager.LoadScene("Level13");
                audioSource.Play();
                break;
            case "ButtonLevel14":
                SceneManager.LoadScene("Level14");
                audioSource.Play();
                break;
            case "ButtonLevel15":
                SceneManager.LoadScene("Level15");
                audioSource.Play();
                break;
            case "ButtonLevel16":
                SceneManager.LoadScene("Level16");
                audioSource.Play();
                break;
            case "ButtonLevel17":
                SceneManager.LoadScene("Level17");
                audioSource.Play();
                break;
            case "ButtonLevel18":
                SceneManager.LoadScene("Level18");
                audioSource.Play();
                break;
            case "ButtonLevel19":
                SceneManager.LoadScene("Level19");
                audioSource.Play();
                break;
            case "ButtonLevel20":
                SceneManager.LoadScene("Level20");
                audioSource.Play();
                break;
            case "ButtonLevel21":
                SceneManager.LoadScene("Level21");
                audioSource.Play();
                break;
            case "ButtonLevel22":
                SceneManager.LoadScene("Level22");
                audioSource.Play();
                break;
            case "ButtonLevel23":
                SceneManager.LoadScene("Level23");
                audioSource.Play();
                break;
            case "ButtonLevel24":
                SceneManager.LoadScene("Level24");
                audioSource.Play();
                break;
            case "ButtonLevel25":
                SceneManager.LoadScene("Level25");
                audioSource.Play();
                break;
            //case "ButtonLevel26":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel27":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel28":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel29":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel30":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel31":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel32":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel33":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel34":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel35":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            //case "ButtonLevel36":
            //    SceneManager.LoadScene("Level21");
            //    audioSource.Play();
            //    break;
            default:
                break;
        }
    }
}
