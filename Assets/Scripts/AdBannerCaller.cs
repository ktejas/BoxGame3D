using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdBannerCaller : MonoBehaviour
{
    public GameObject adObject;

    void Start()
    {
        if(!GameManager.bAdCreated)
        {
        GameManager.bAdCreated = true;
        adObject.GetComponent<admobdemo>().AdmobShowBanner();
        }

	}
	
	void Update () {
		
	}
}
