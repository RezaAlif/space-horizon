using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterestAds : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}

    public void GameOver()
    {
        string adUnitId = "ca-app-pub-1457560942718397/5783814611";

        // Initialize an InterstitialAd.
        InterstitialAd interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }



    // Update is called once per frame
    void Update () {
		
	}
}
