using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {

    public GameObject WelcomeUI;
    public GameObject IntroductionUI;
    public GameObject NavigationUI;

	// Use this for initialization
	void Start () {
        WelcomeUI.SetActive(true);
        IntroductionUI.SetActive(false);
        NavigationUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void skipIntro()
    {
        WelcomeUI.SetActive(false);
    }

    public void watchIntro()
    {
        WelcomeUI.SetActive(false);
        IntroductionUI.SetActive(true);
    }

    public void navigationInstruction()
    {
        IntroductionUI.SetActive(false);
        NavigationUI.SetActive(true);
    }

    public void startTour()
    {
        NavigationUI.SetActive(false);
    }
}
